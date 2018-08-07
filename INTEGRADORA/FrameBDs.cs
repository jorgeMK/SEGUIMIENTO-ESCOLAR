using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
//using SEUTCV2.Properties;
using System.Windows.Forms;

namespace INTEGRADORA
{
    public class FrameBDs
    {
        public static MySqlConnection conex = new MySqlConnection();

        public static string servidor;
        public static uint puerto;
        public static string usuario;
        public static string password;
        public static string bd;
        public FrameBDs()
        {
            servidor = "localhost";
            puerto = 3309;
            usuario = "root";
            password = "linkingpark1";
            bd = "seguimiento_academico";


            conex.Close();
            MySqlConnectionStringBuilder conexs = new MySqlConnectionStringBuilder();
            
            conexs.Server = servidor;
            conexs.Port = puerto;
            conexs.Password = password;
            conexs.UserID = usuario;
            conexs.Database = bd;

            conex.ConnectionString = conexs.ConnectionString;

            conex.Open();

            MySqlCommand comando;
            comando = new MySqlCommand();

        }

        public static void conectar()
        {
            conex.Close();
            conex.Open();

        }

        public DataSet SQLSEL(string sql)
        {
            conectar();

            MySqlDataAdapter Adaptador = new MySqlDataAdapter(sql, conex);
            DataSet RsDatos = new DataSet();
            Adaptador.Fill(RsDatos, "datos");
            return (RsDatos);
        }
        
        public DataTable SQLCOMBO(string sql)
        {
            conectar();
            MySqlDataAdapter Adap = new MySqlDataAdapter(sql, conex);
            DataTable DT = new DataTable();
            Adap.Fill(DT);
            return DT;
        }

        public void SQLIDU(string sql)
        {
            try
            {
                conectar();
                MySqlCommand comando = new MySqlCommand(sql, conex);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number);
            }
        }

        public static MySqlDataReader SQLReader(string sql)
        {
            conectar();
            MySqlCommand comando = new MySqlCommand(sql, conex);

            MySqlDataReader Dr = comando.ExecuteReader();
            return Dr;


        }

        public static string[] ObtieneCampo(string tabla, string condicion, string campo)
        {

            string sqlaux = "SELECT " + campo +
                           " FROM " + tabla +
                           " WHERE " + condicion;

            MySqlDataReader dt = SQLReader(sqlaux);
            int cont = 0;

            string[] respaux = new string[1];
            respaux[0] = "";

            if (dt.HasRows)
            {

                while (dt.Read())
                {
                    Array.Resize(ref respaux, respaux.Length + 1);

                    if (dt.GetString(0) != null)
                    {
                        respaux[cont] = dt.GetString(0);
                        cont++;
                    }

                }
            }
            Array.Resize(ref respaux, respaux.Length - 1);
            return respaux;

        }
    }
}
