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
    public partial class frmCF : Form
    {
        public frmCF()
        {
            InitializeComponent();
        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            int i = 1, c = 0;
            double f;
            while (i <= 10)
            {
                c = c + 10;
                f = (c * 1.8) + 32;
                txtFahrenheit.Text = String.Format(txtFahrenheit.Text +"\n" + f.ToString());
                i++;
            }
        }

        private void btndowhile_Click(object sender, EventArgs e)
        {
            int i = 1, c = 0;
            double f;
            do
            {
                c = c + 10;
                f = (c * 1.8) + 32;
                txtFahrenheit.Text = String.Format(txtFahrenheit.Text + "\n" + f.ToString());
                i++;
            }
            while (i <= 10);
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            int i, c = 0;
            double f;
            for (i = 1; i <= 10; i++)
            {
                c = c + 10;
                f = (c * 1.8) + 32;
                txtFahrenheit.Text = String.Format(txtFahrenheit.Text + "\n" + f.ToString());
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFahrenheit.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }
    }
}
