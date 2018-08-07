using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTEGRADORA
{
    class ABCAlumnos
    {
        FrameBDs MiConexion;
		public ABCAlumnos()
        {
            MiConexion = new FrameBDs();	
        }
        public void Agregar(DatosAlumno datos)
        {
            string ComandoSQL = string.Format("INSERT INTO alumnos (matricula,nombres,apellidoP,apellidoM,id_pocedencia,id_grupos,direccion,id_carrera)VALUES('{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}');", datos.nmatricula, datos.nnombres, datos.napellidop, datos.napellidom, datos.nid_procedencia, datos.nid_grupos, datos.ndireciion, datos.nid_Carrera);
            MiConexion.SQLIDU(ComandoSQL);
        }

        public DataTable Buscar()
        {

            string ComandoSQL = "SELECT matricula,id_pocedencia,nombres,apellidop,apellidom,id_grupos,direccion,id_carrera from alumnos";

            return MiConexion.SQLCOMBO(ComandoSQL);
        }

        public void Borrar(DatosAlumno datos)
        {
            string ComandoSQL = string.Format("DELETE FROM alumnos WHERE matricula={0}", datos.nmatricula);
            MiConexion.SQLIDU(ComandoSQL);
        }
        public void editar(DatosAlumno datos)
        {
			string ComandoSQL = string.Format("UPDATE alumnos SET nombres= ['+txtNombre.Text+'],apellidoP= (' + txtApellidoP.Text + '),apellidoM= (' + txtApellidoM.Text + '),id_pocedencia=  (+ txtProcedencia.Text +) ,id_grupos= (' + cmbGrupo.Items +' ),direccion= (' + txtDireccion.Text +'),id_carrera= (' + cmbCarrera.Items + ') WHERE matricula='{0}'", datos.nnombres, datos.napellidop, datos.napellidom, datos.nid_procedencia, datos.nid_grupos, datos.ndireciion, datos.nid_Carrera, datos.nmatricula);

			MiConexion.SQLIDU(ComandoSQL);
		}
	}
}
