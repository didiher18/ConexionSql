using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Empadronamiento
{
    class Conexión
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool seguridad;
        private static Conexión con = null;

        private Conexión()
        {
            this.Base = "Empadronamiento";
            this.Servidor = "DESKTOP-M0TQQ3V";
            this.Usuario = "sa";
            this.Clave = "her_14mami";
            this.seguridad = true;
        }

        //metodo para devolver el string de conexión
        public SqlConnection crearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                //Cadena de conexion
                cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
                //validamos el tipo de seguridad que utilizara la conexion
                
                //Autenticación de windows
                if (this.seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";

                }
                //Autenticación de sql
                else
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.Usuario + "; Password=" + this.Clave;
                }
            }
            catch(Exception ex)
            {
                cadena = null;
                throw ex; //Mensaje con el error
            }
            return cadena;

        }


        //Metodo para instancia al constructor de esta clase
        
        public static Conexión crearInstancia()
        {
            if(con == null)
            {
                con = new Conexión();
            }
            return con;
        }
    }
}
