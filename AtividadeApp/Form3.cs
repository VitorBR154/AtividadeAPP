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
    public partial class frmViagem : Form
    {
        public frmViagem()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double d, t, v, l;
            t = Convert.ToDouble(txtTempo.Text);
            v = Convert.ToDouble(txtVM.Text);
            d = t * v;
            l = d / 12;
            txtDist.Text = d.ToString();
            txtLitros.Text = l.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTempo.Clear();
            txtVM.Clear();
            txtDist.Clear();
            txtLitros.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }
    }
}
