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
    public partial class frmDinheiro : Form
    {
        public frmDinheiro()
        {
            InitializeComponent();
        }

        private void lblReal_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double R, D, X;
            R = Convert.ToDouble(txtReal.Text);
            D = Convert.ToDouble(txtDol.Text);
            X = R / D;
            txtResult.Text = X.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtReal.Clear();
            txtDol.Clear();
            txtResult.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }
    }
}
