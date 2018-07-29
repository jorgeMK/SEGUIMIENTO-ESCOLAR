using System;
using System.Data;
using System.Windows.Forms;

namespace INTEGRADORA
{
    public partial class frmLogin : Form
    {
        FrameBDs objconect = new FrameBDs();
        Usuarios objbo = new Usuarios();
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            objbo.nomuser = txtUsuario.Text;
            objbo.passuser = txtContrasenia.Text;
            DataTable Datitos = objbo.ValidarUsuario(objbo.nomuser, objbo.passuser);
            if(Datitos.Rows.Count >= 1)
            {
                Datos_Login.nomuser = objbo.nomuser;
                Datos_Login.passuser = objbo.passuser;
                Form1 objf = new Form1();
                this.Hide();
                objf.Show();
            }
            else
            {
                MessageBox.Show("Usuario no Registrado");
            }
            

            
           



            //string condicion = String.Format("login='{0}'", txtUsuario.Text);

            //string[] datos = FrameBDs.ObtieneCampos("usuarios", condicion, "login, pass, rol, tratamiento, usuario");

            //if (datos.Length > 1)
            //{
            //    if (datos[1] == txtContrasenia.Text)
            //    {
            //        //MessageBox.Show("Bienvenido	" + datos[2])
            //        FrameBD.rol = datos[2];
            //        FrameBD.quienAccede = datos[3] + "	" + datos[4];

            //        Form1 menu = new Form1();
            //        this.Hide();
            //        menu.ShowDialog();
            //        this.Close();
            //    }
            //    else
            //        MessageBox.Show("La contraseña es incorecta");
            //}
            //else
            //{
            //    MessageBox.Show("El usuario no existe");
            //}
        }
    }
}
