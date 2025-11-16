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
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double media, nota1, nota2, nota3;
            nota1 = Convert.ToDouble (txtNota1.Text);
            nota2 = Convert.ToDouble (txtNota2.Text);
            nota3 = Convert.ToDouble (txtNota3.Text);
            media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5))/10;
            txtMedia.Text = media.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMedia.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }
    }
}
