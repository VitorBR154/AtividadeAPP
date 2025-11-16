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
    public partial class frmLivro : Form
    {
        public frmLivro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double L, T;
            L = Convert.ToDouble(txtL.Text);
            if (L <= 0)
                T = L * 12;
            else
                T = L * 8;

            txtVt.Text=T.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtL.Clear();
            txtVt.Clear();
            txtL.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }
    }
}
