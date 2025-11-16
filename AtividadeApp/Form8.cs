using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeApp
{
    public partial class frmRetangulo : Form
    {
        public frmRetangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Base, Altura, Area;
            Base = Convert.ToDouble(txtBase.Text);
            Altura = Convert.ToDouble(txtAltura.Text);
            Area = Base * Altura;
            txtArea.Text = Area.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtBase.Clear();
            txtArea.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }
    }
}
