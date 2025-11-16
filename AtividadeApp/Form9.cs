using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AtividadeApp
{
    public partial class frmJogo : Form
    {
        public frmJogo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double totp, pop, ger, arq, cad, rdp = 0, rdg = 0, rda = 0, rdc = 0, totr;
            totp = Convert.ToDouble(txtPt.Text);
            pop = totp * 0.1;
            ger = totp * 0.5;
            arq = totp * 0.3;
            cad = totp * 0.1;
            if (pop > 0)
            rdp = pop*5;
            if (ger > 0)
            rdg = ger*10;
            if (arq > 0)
            rda = arq*20;
            if (cad > 0)
            rdc = cad * 30;

            totr = rdp + rdg + rda + rdc;
            txtRt.Text=totr.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPt.Clear();
            txtRt.Clear();
            txtPt.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }
    }
}
