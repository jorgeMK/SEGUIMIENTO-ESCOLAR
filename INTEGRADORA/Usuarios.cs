using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INTEGRADORA;
using System.Data;

namespace INTEGRADORA
{
    class Usuarios
    {
        public string nomuser;
        public string passuser;
        FrameBDs MiConexion = new FrameBDs();
        public Usuarios()
        {
            MiConexion = new FrameBDs();
        }
        public DataTable ValidarUsuario(string usuario, string contrasenia)
        {

            string ComandoSQL = string.Format("SELECT * FROM usuarios where usuario='{0}' and contrasenia='{1}'", usuario,contrasenia);
            DataTable Datos = MiConexion.SQLCOMBO(ComandoSQL);
            return Datos;
        }
        //public string mostrar_tipousuario(string nombre, string pass)
        //{

        //    string ComandoSQL = string.Format("select evaluador.Puesto from evaluador where evaluador.Nombre = '{0}' and evaluador.Contrasenia = '{1}'", nombre, pass);
        //    DataTable Datos = MiConexion.EjecutarSentencia(ComandoSQL);
        //    string tipos = Datos.Rows[0]["Puesto"].ToString();
        //    return tipos;
        //}
    }
}
