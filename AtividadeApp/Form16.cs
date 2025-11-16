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
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            int i, num, tab;
            i = 1;
            num = Convert.ToInt32(txtnum.Text);
            while (i<=9){
                tab = num * i;
                txttab.Text = String.Format(txttab.Text + "\n" + tab.ToString());
                i++;
            }
        }

        private void btndowhile_Click(object sender, EventArgs e)
        {
            int i, num, tab;
            i = 1;
            num=Convert.ToInt32(txtnum.Text);
            do
            {
                tab = num * i;
                txttab.Text = String.Format(txttab.Text + "\n" + tab.ToString());
                i++;
            }
            while (i <= 9);
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            int i, num, tab;
            num= Convert.ToInt32(txtnum.Text);
            for(i=1; i<=9; i++){
                tab = num * i;
                txttab.Text = String.Format(txttab.Text + "\n" + tab.ToString());
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txttab.Clear();
            txtnum.Clear();
            txtnum.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }
    }
}
