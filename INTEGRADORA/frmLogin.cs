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

        }

		private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
		{

		}
	}
}
