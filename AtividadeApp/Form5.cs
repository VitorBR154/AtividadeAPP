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
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double X, Y, Z, Result, P;
            X = Convert.ToDouble(txtX.Text);
            Y = Convert.ToDouble(txtY.Text);
            Z = Convert.ToDouble(txtZ.Text);
            Result = (X + Y + Z);
            P = Math.Pow(Result, 2);
            txtResult.Text = P.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtX.Clear();
            txtY.Clear();
            txtZ.Clear();
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
