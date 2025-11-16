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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void exemplo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTemp Temperatura = new frmTemp();
            Temperatura.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViagem Viagem = new frmViagem();
            Viagem.Show();
        }

        private void dinheiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDinheiro Dinheiro = new frmDinheiro();
            Dinheiro.Show();
        }

        private void somaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSoma Soma = new frmSoma();
            Soma.Show();
        }

        private void circunferênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCircunferencia circunferencia = new frmCircunferencia();
            circunferencia.Show();
        }

        private void mediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMedia Media = new frmMedia();
            Media.Show();
        }

        private void retânguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRetangulo Retângulo = new frmRetangulo();
            Retângulo.Show();
        }

        private void jogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmJogo jogo = new frmJogo();
            jogo.Show();
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLivro livro = new frmLivro();
            livro.Show();
        }

        private void salárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalario Salário = new frmSalario();
            Salário.Show();
        }

        private void iMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmIMC iMC = new frmIMC();
            iMC.Show();
        }

        private void cardápioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCardapio Cardapio = new frmCardapio();
            Cardapio.Show();
        }

        private void provaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProva Prova = new frmProva();
            Prova.Show();
        }

        private void descontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDesconto Desconto = new frmDesconto();
            Desconto.Show();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTabuada Tabuada = new frmTabuada();
            Tabuada.Show();
        }

        private void celsiusParaFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCF CF = new frmCF();
            CF.Show();
        }

        private void residênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmresidencia residencia = new frmresidencia();
            residencia.Show();
        }
    }
}
