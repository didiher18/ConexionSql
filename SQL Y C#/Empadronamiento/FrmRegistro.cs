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
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmInicio obj = new FrmInicio();
            obj.Show();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection();
            conexion = Conexión.crearInstancia().crearConexion();
            conexion.Open();

            //Validaciones para Casillas vacias
            if (txtDpi.Text == string.Empty)
            {
                MessageBox.Show("Debe llenar todas las casillas");
            }
            else if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe llenar todas las casillas");
            }
            else if (txtApellido.Text == string.Empty)
            {
                MessageBox.Show("Debe llenar todas las casillas");
            }
            else if (txt_FechaNac.Text == string.Empty)
            {
                MessageBox.Show("Debe llenar todas las casillas");
            }
            else if (txt_Estado.Text == string.Empty)
            {
                MessageBox.Show("Debe llenar todas las casillas");
            }
            else if (txt_Depa.Text == string.Empty)
            {
                MessageBox.Show("Debe llenar todas las casillas");
            }
            else if (txt_Muni.Text == string.Empty)
            {
                MessageBox.Show("Debe llenar todas las casillas");
            }
            else if (txt_Edad.Text == string.Empty)
            {
                MessageBox.Show("Debe llenar todas las casillas");
            }
            else if (txt_Telefono.Text == string.Empty)
            {
                MessageBox.Show("Debe llenar todas las casillas");
            }
            else
            {
                //Validaciones para registrarse
                int Edad = Convert.ToInt32(txt_Edad.Text);
                if (Edad >= 18)
                {
                    string cadena = "insert into Persona values ('" + txtDpi.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txt_FechaNac.Text + "','" + txt_Estado.Text + "', '" + txt_Depa.Text + "','" + txt_Muni.Text + "','" + txt_Edad.Text + "','" + txt_Telefono.Text + "')";
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Su empadronamiento se ha registrado con exito");
                }
                else
                {
                    MessageBox.Show("Debe ser mayor de edad para poder empadronarse");
                }
            }
            //LIMPIAR CASILLAS
            txtDpi.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txt_FechaNac.Text = "";
            txt_Estado.Text = "";
            txt_Depa.Text = "";
            txt_Muni.Text = "";
            txt_Edad.Text = "";
            txt_Telefono.Text = "";
        }
    }
}
