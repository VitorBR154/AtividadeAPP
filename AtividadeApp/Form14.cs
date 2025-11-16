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
    public partial class frmProva : Form
    {
        public frmProva()
        {
            InitializeComponent();
        }

        private void lblmedia_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, ex, ger, id;
            id = Convert.ToDouble(txtId.Text);
            nota1 = Convert.ToDouble(txtN1.Text);
            nota2 = Convert.ToDouble(txtN2.Text);
            nota3 = Convert.ToDouble(txtN3.Text);
            ex = Convert.ToDouble(txtEx.Text);
            ger = (nota1 + nota2 * 2 + nota3 * 3 + ex) / 7;
            if (ger >= 90) 
            { 
               txtGer.Text = ger.ToString();
               txtAluno.Text = id.ToString();
               txtConceito.Text = "A";
               txtSituacao.Text = "aprovado";
            }
            else if(ger>=75 && ger<90)
            {
                txtGer.Text = ger.ToString();
                txtAluno.Text = id.ToString();
                txtConceito.Text = "B";
                txtSituacao.Text = "aprovado";
            }
            else if (ger>=60 && ger<75)
            {
                txtGer.Text = ger.ToString();
                txtAluno.Text = id.ToString();
                txtConceito.Text = "C";
                txtSituacao.Text = "aprovado";
            }
            else if (ger >= 40 && ger < 60)
            {
                txtGer.Text = ger.ToString();
                txtAluno.Text = id.ToString();
                txtConceito.Text = "D";
                txtSituacao.Text = "reprovado";
            }
            else if (ger < 40)
            {
                txtGer.Text = ger.ToString();
                txtAluno.Text = id.ToString();
                txtConceito.Text = "E";
                txtSituacao.Text = "reprovado";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtConceito.Clear();
            txtAluno.Clear();
            txtSituacao.Clear();
            txtEx.Clear();
            txtGer.Clear();
            txtId.Clear();
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtId.Focus();
        }
    }
}
