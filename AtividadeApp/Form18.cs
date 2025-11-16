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
    public partial class frmresidencia : Form
    {
        public frmresidencia()
        {
            InitializeComponent();
        }
         double i = 1, qtdC = 0, l, c, ac = 0, at = 0;
        private void lblCelsius_Click(object sender, EventArgs e)
        {

        }

        private void frmresidencia_Load(object sender, EventArgs e)
        {

        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
          
            qtdC = Convert.ToDouble(txtComodos.Text);
            while (qtdC>=i)
            {
                l = Convert.ToDouble(MessageBox.Show($"Digite a largura: {l}"));
                c = Convert.ToDouble(MessageBox.Show($"Digite o comprimento: {c}"));
                ac = l * c;
                at = at + ac;

                txtAc.Text = ac.ToString();
                txtLargura.Focus();
                txtComprimento.Focus();
                i++;
            }
            txtAt.Text = at.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtComodos.Clear();
            txtLargura.Clear();
            txtComprimento.Clear();
            txtAc.Clear();
            txtAt.Clear();
            txtComodos.Focus();
        }

        private void btndowhile_Click(object sender, EventArgs e)
        {
           
            qtdC = Convert.ToInt32(txtComodos.Text);
            do
            {
                l = Convert.ToDouble(txtLargura.Text);
                c = Convert.ToDouble(txtComprimento.Text);
                ac = l * c;
                at = at + ac;
                i++;
                txtAc.Text = String.Format(txtAc.Text + "\n" + ac.ToString());
            }
            while (i <= qtdC);
            txtAt.Text = at.ToString();
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
           
            qtdC = Convert.ToInt32(txtComodos.Text);
            for (i = 1; i >= qtdC; i++)
            {
                l = Convert.ToDouble(txtLargura.Text);
                c = Convert.ToDouble(txtComprimento.Text);
                ac = l * c;
                at = at + ac;
                txtAc.Text = String.Format(txtAc.Text + "\n" + ac.ToString());
            }
            txtAt.Text = at.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }
    }
}
