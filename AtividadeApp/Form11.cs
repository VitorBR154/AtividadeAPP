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
    public partial class frmSalario : Form
    {
        public frmSalario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double I, A=0, SF, ST;
            string N, SX;
            I = Convert.ToDouble(txtIdade.Text);
            SF = Convert.ToDouble(txtSf.Text);
            N = Convert.ToString(txtNome.Text);
            SX = Convert.ToString(txtSexo.Text);
            if (SX == "M" && I >= 30)
                A = 100;
            else if (SX == "M" && I < 30)
                A = 50;
            else if (SX == "F" && I >= 30)
                A = 250;
            else if (SX == "F" && I < 30)
                A = 150;

            ST = SF + A;
            txtSt.Text = ST.ToString();
            txtF.Text=N.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtSexo.Clear();
            txtSf.Clear();
            txtSt.Clear();
            txtF.Clear();
            txtNome.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }
    }
}
