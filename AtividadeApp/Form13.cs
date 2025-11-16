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
    public partial class frmCardapio : Form
    {
        public frmCardapio()
        {
            InitializeComponent();
        }

        private void btnApresentar_Click(object sender, EventArgs e)
        {
            {
                int cod;


                cod = Convert.ToInt32(txtCod.Text);

                switch (cod)
                {
                    case 100:
                        txtProd.Text = ("Cachorro-quente R$25,00");
                        break;
                    case 101:
                        txtProd.Text = ("Bauru R$15,00");
                        break;
                    case 102:
                        txtProd.Text = ("X-Burguer R$35,00");
                        break;
                    case 103:
                        txtProd.Text = ("Triplo X-Burguer R$47,00");
                        break;
                    default:
                        txtProd.Text = ("NÃO EXISTENTE...");
                        break;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCod.Clear();
            txtProd.Clear();
            txtCod.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }
    }
}

