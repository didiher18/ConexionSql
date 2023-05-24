using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Empadronamiento
{
    public partial class FrmConsultas : Form
    {
        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmInicio obj = new FrmInicio();
            obj.Show();
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            //Conexikon a la base de datos
            SqlConnection conexion = new SqlConnection();
            conexion = Conexión.crearInstancia().crearConexion();
            conexion.Open();

            //Envio de datos a la tabla
            string cadena = "Select * from Persona";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            DataTable person = new DataTable();
            adaptador.Fill(person);

            dgVisualizar.DataSource = person;
        }
    }
}
