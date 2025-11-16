
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
    public partial class frmDesconto : Form
    {
        public frmDesconto()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCod.Clear();
            txtDesc.Clear();
            txtPreco.Clear();

            txtPreco.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double preco, desc;
            int cod;

            preco = Convert.ToDouble(txtPreco.Text);
            cod = Convert.ToInt32(txtCod.Text);

            switch (cod){

                case 1:
                 desc = preco * 0.05;
                 txtDesc.Text = desc.ToString();
                 break;

                case 2:
                 desc = preco * 0.15;
                 txtDesc.Text = desc.ToString();
                 break;

                case 3:
                 desc = preco * 0.07;
                 txtDesc.Text = desc.ToString();
                 break;

                case 4:
                 desc = preco * 0.13;
                 txtDesc.Text = desc.ToString();
                 break;

                case 5:
                 desc = preco * 0.20;
                 txtDesc.Text = desc.ToString();
                 break;

                default:
                 txtDesc.Text = ("Produto Importado, sem desconto");
                 break;
            }
        }
    }
}
