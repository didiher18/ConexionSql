using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Empadronamiento
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistro obj = new FrmRegistro();
            obj.Show();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConsultas obj = new FrmConsultas();
            obj.Show();
        }

        private void ptb_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
