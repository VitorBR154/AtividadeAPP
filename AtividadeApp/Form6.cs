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
    public partial class frmCircunferencia : Form
    {
        public frmCircunferencia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Area, R, P;
            R = Convert.ToDouble(txtR.Text);
            Area = 3.14 * R;
            P = Math.Pow(Area, 2);
            txtArea.Text = P.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtR.Clear();
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
