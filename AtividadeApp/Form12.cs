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
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            {
                double p, h, imc;

                p = Convert.ToDouble(txtP.Text);

                h = Convert.ToDouble(txtH.Text);

                imc = p / (h * h);

                if (imc < 17)
                    txtIMC.Text = ("Magreza extrema");
                else if (imc < 18.5)
                    txtIMC.Text = ("Magreza leve");
                else if (imc < 25)
                    txtIMC.Text = ("Peso normal");
                else if (imc < 30)
                    txtIMC.Text = ("Sobrepeso");
                else if (imc < 35)
                    txtIMC.Text = ("Obesidade classe I");
                else if (imc < 40)
                    txtIMC.Text = ("Obesidade classe II");
                else if (imc >= 40)
                    txtIMC.Text = ("Obesidade classe III");
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
            txtH.Clear();
            txtP.Clear();
            txtIMC.Clear();
            txtH.Focus();
        }
    }
}
