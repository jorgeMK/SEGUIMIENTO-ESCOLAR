using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTEGRADORA
{
    public partial class IngresosyBajas : Form
    {
        FrameBDs frame = new FrameBDs();
        DatosAlumno datAlu = new DatosAlumno();
        ABCAlumnos abcalu = new ABCAlumnos();
        DataTable datos;
        public IngresosyBajas()
        {
            InitializeComponent();
            cmbCarrera.SelectedIndex = 0;
            cmbGrupo.SelectedIndex = 0;

            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.DataSource = abcalu.Buscar();
            dgvAlumnos.Columns[1].Visible = false;
        }
             private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (
               String.IsNullOrEmpty(txtMatricula.Text) ||
               String.IsNullOrEmpty(txtNombre.Text) ||
               String.IsNullOrEmpty(txtApellidoP.Text) ||
               String.IsNullOrEmpty(txtApellidoM.Text) ||
               String.IsNullOrEmpty(txtProcedencia.Text) ||
               String.IsNullOrEmpty(txtDireccion.Text) ||
               String.IsNullOrEmpty(cmbCarrera.Text) || (cmbCarrera.Text == " ") ||
               String.IsNullOrEmpty(cmbGrupo.Text) || (cmbGrupo.Text == " ")
                )
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else 
            {
                abcalu.Agregar(RecuperarInformacion());
                MessageBox.Show("Registro Agregado");
            }
            dgvAlumnos.DataSource = abcalu.Buscar();
            limpiarcontroles();
        }
        private void limpiarcontroles()
        {
            txtMatricula.Clear();
            txtNombre.Clear();
            txtApellidoP.Clear();
            txtApellidoM.Clear();
            txtProcedencia.Clear();
            txtDireccion.Clear();
            cmbCarrera.SelectedIndex = 0;
            cmbGrupo.SelectedIndex = 0;
        }
        private void seleccionar_alumno(object sender, DataGridViewCellMouseEventArgs e)
        {
            int filaSeleccionada = e.RowIndex;

            try
            {
                txtMatricula.Text = dgvAlumnos.Rows[filaSeleccionada].Cells[0].Value.ToString();
                txtNombre.Text = dgvAlumnos.Rows[filaSeleccionada].Cells[1].Value.ToString();
                txtApellidoP.Text = dgvAlumnos.Rows[filaSeleccionada].Cells[2].Value.ToString();
                txtApellidoM.Text = dgvAlumnos.Rows[filaSeleccionada].Cells[3].Value.ToString();
                txtProcedencia.Text = dgvAlumnos.Rows[filaSeleccionada].Cells[4].Value.ToString();
                txtDireccion.Text = dgvAlumnos.Rows[filaSeleccionada].Cells[5].Value.ToString();
                cmbCarrera.Text = dgvAlumnos.Rows[filaSeleccionada].Cells[7].Value.ToString();
                cmbGrupo.Text = dgvAlumnos.Rows[filaSeleccionada].Cells[8].Value.ToString();

            }
            catch (Exception)
            {

            }
        }

        private DatosAlumno RecuperarInformacion()
        {
            datAlu.nmatricula = (txtMatricula.Text);
            datAlu.nnombres = txtNombre.Text;
            datAlu.napellidop = txtApellidoP.Text;
            datAlu.napellidom = txtApellidoM.Text;
            datAlu.nid_procedencia = Convert.ToInt32(txtProcedencia.Text);
            datAlu.ndireciion = txtDireccion.Text;
            datAlu.nid_Carrera = Convert.ToString(cmbCarrera.SelectedItem);
            datAlu.nid_grupos = Convert.ToString(cmbGrupo.SelectedItem);
            return datAlu;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMatricula.Text) ||
              String.IsNullOrEmpty(txtNombre.Text) ||
              String.IsNullOrEmpty(txtApellidoP.Text) ||
              String.IsNullOrEmpty(txtApellidoM.Text) ||
             String.IsNullOrEmpty(txtProcedencia.Text) ||
             String.IsNullOrEmpty(txtDireccion.Text) ||
              String.IsNullOrEmpty(cmbCarrera.Text) || (cmbCarrera.Text == "Seleccionar") ||
              String.IsNullOrEmpty(cmbGrupo.Text) || (cmbGrupo.Text == "Seleccionar")
               )
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else if (MessageBox.Show("¿Estás seguro? El cambio será permanente", "Se requiere confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                abcalu.Borrar(RecuperarInformacion());
                MessageBox.Show("Registro Borrado");

                dgvAlumnos.DataSource = abcalu.Buscar();
                limpiarcontroles();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            datos = abcalu.Buscar();
            DataView view = datos.DefaultView;
            view.RowFilter = string.Empty;
            if (txtBusqueda.Text != string.Empty)
            {
                view.RowFilter = string.Format("matricula LIKE '%{0}%'", txtBusqueda.Text);
            }
            dgvAlumnos.DataSource = view;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            datos = abcalu.Buscar();
            DataView view = datos.DefaultView;
            view.RowFilter = string.Empty;
            if (txtBusqueda.Text != string.Empty)
            {
                view.RowFilter = string.Format("matricula LIKE '%{0}%'", txtBusqueda.Text);
            }
            dgvAlumnos.DataSource = view;
        }

        public void btnModificar_Click(object sender, EventArgs e)
        {
            if (
              String.IsNullOrEmpty(txtMatricula.Text) ||
              String.IsNullOrEmpty(txtNombre.Text) ||
              String.IsNullOrEmpty(txtApellidoP.Text) ||
              String.IsNullOrEmpty(txtApellidoM.Text) ||
              String.IsNullOrEmpty(txtProcedencia.Text) ||
              String.IsNullOrEmpty(txtDireccion.Text) ||
              String.IsNullOrEmpty(cmbCarrera.Text) || (cmbCarrera.Text == " ") ||
              String.IsNullOrEmpty(cmbGrupo.Text) || (cmbGrupo.Text == " ")
               )
            {
                MessageBox.Show("Error al editar. Debe llenar todos los campos");
            }
            else
            {
                abcalu.editar(RecuperarInformacion());
                MessageBox.Show("Edicion completa");
            }
            dgvAlumnos.DataSource = abcalu.Buscar();
            limpiarcontroles();
        }
	}
}
