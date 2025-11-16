namespace AtividadeApp
{
    partial class frmProva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblid = new System.Windows.Forms.Label();
            this.lbln1 = new System.Windows.Forms.Label();
            this.lbln2 = new System.Windows.Forms.Label();
            this.lbln3 = new System.Windows.Forms.Label();
            this.lblEx = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtEx = new System.Windows.Forms.TextBox();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblGer = new System.Windows.Forms.Label();
            this.txtGer = new System.Windows.Forms.TextBox();
            this.lblFoi = new System.Windows.Forms.Label();
            this.lblconceito = new System.Windows.Forms.Label();
            this.lblsituacao = new System.Windows.Forms.Label();
            this.txtConceito = new System.Windows.Forms.TextBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(156, 81);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(174, 20);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Digite o ID do aluno:";
            // 
            // lbln1
            // 
            this.lbln1.AutoSize = true;
            this.lbln1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbln1.Location = new System.Drawing.Point(156, 122);
            this.lbln1.Name = "lbln1";
            this.lbln1.Size = new System.Drawing.Size(132, 20);
            this.lbln1.TabIndex = 1;
            this.lbln1.Text = "Digite a nota 1:";
            // 
            // lbln2
            // 
            this.lbln2.AutoSize = true;
            this.lbln2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbln2.Location = new System.Drawing.Point(156, 159);
            this.lbln2.Name = "lbln2";
            this.lbln2.Size = new System.Drawing.Size(132, 20);
            this.lbln2.TabIndex = 2;
            this.lbln2.Text = "Digite a nota 2:";
            // 
            // lbln3
            // 
            this.lbln3.AutoSize = true;
            this.lbln3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbln3.Location = new System.Drawing.Point(156, 192);
            this.lbln3.Name = "lbln3";
            this.lbln3.Size = new System.Drawing.Size(132, 20);
            this.lbln3.TabIndex = 3;
            this.lbln3.Text = "Digite a nota 3:";
            // 
            // lblEx
            // 
            this.lblEx.AutoSize = true;
            this.lblEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEx.Location = new System.Drawing.Point(156, 224);
            this.lblEx.Name = "lblEx";
            this.lblEx.Size = new System.Drawing.Size(247, 20);
            this.lblEx.TabIndex = 4;
            this.lblEx.Text = "Digite a média dos exercícios:";
            this.lblEx.Click += new System.EventHandler(this.lblmedia_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(337, 78);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(79, 26);
            this.txtId.TabIndex = 7;
            // 
            // txtN1
            // 
            this.txtN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.Location = new System.Drawing.Point(294, 120);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(79, 26);
            this.txtN1.TabIndex = 8;
            // 
            // txtN2
            // 
            this.txtN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.Location = new System.Drawing.Point(294, 156);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(79, 26);
            this.txtN2.TabIndex = 9;
            // 
            // txtN3
            // 
            this.txtN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN3.Location = new System.Drawing.Point(294, 192);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(79, 26);
            this.txtN3.TabIndex = 10;
            // 
            // txtEx
            // 
            this.txtEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEx.Location = new System.Drawing.Point(400, 224);
            this.txtEx.Name = "txtEx";
            this.txtEx.Size = new System.Drawing.Size(79, 26);
            this.txtEx.TabIndex = 11;
            // 
            // txtAluno
            // 
            this.txtAluno.Enabled = false;
            this.txtAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAluno.Location = new System.Drawing.Point(353, 263);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(100, 26);
            this.txtAluno.TabIndex = 16;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(160, 352);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 32);
            this.btnCalcular.TabIndex = 18;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(480, 352);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(88, 32);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(332, 352);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(71, 32);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblGer
            // 
            this.lblGer.AutoSize = true;
            this.lblGer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGer.Location = new System.Drawing.Point(156, 265);
            this.lblGer.Name = "lblGer";
            this.lblGer.Size = new System.Drawing.Size(193, 20);
            this.lblGer.TabIndex = 14;
            this.lblGer.Text = "A média geral do aluno";
            this.lblGer.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGer
            // 
            this.txtGer.Enabled = false;
            this.txtGer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGer.Location = new System.Drawing.Point(494, 265);
            this.txtGer.Name = "txtGer";
            this.txtGer.Size = new System.Drawing.Size(100, 26);
            this.txtGer.TabIndex = 15;
            // 
            // lblFoi
            // 
            this.lblFoi.AutoSize = true;
            this.lblFoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoi.Location = new System.Drawing.Point(459, 269);
            this.lblFoi.Name = "lblFoi";
            this.lblFoi.Size = new System.Drawing.Size(29, 20);
            this.lblFoi.TabIndex = 17;
            this.lblFoi.Text = "foi";
            // 
            // lblconceito
            // 
            this.lblconceito.AutoSize = true;
            this.lblconceito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconceito.Location = new System.Drawing.Point(156, 293);
            this.lblconceito.Name = "lblconceito";
            this.lblconceito.Size = new System.Drawing.Size(118, 20);
            this.lblconceito.TabIndex = 5;
            this.lblconceito.Text = "Com conceito";
            // 
            // lblsituacao
            // 
            this.lblsituacao.AutoSize = true;
            this.lblsituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsituacao.Location = new System.Drawing.Point(358, 297);
            this.lblsituacao.Name = "lblsituacao";
            this.lblsituacao.Size = new System.Drawing.Size(95, 20);
            this.lblsituacao.TabIndex = 6;
            this.lblsituacao.Text = "ele(a) está";
            // 
            // txtConceito
            // 
            this.txtConceito.Enabled = false;
            this.txtConceito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConceito.Location = new System.Drawing.Point(273, 294);
            this.txtConceito.Name = "txtConceito";
            this.txtConceito.Size = new System.Drawing.Size(79, 26);
            this.txtConceito.TabIndex = 12;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Enabled = false;
            this.txtSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacao.Location = new System.Drawing.Point(459, 294);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(119, 26);
            this.txtSituacao.TabIndex = 13;
            // 
            // frmProva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblFoi);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.txtGer);
            this.Controls.Add(this.lblGer);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.txtConceito);
            this.Controls.Add(this.txtEx);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblsituacao);
            this.Controls.Add(this.lblconceito);
            this.Controls.Add(this.lblEx);
            this.Controls.Add(this.lbln3);
            this.Controls.Add(this.lbln2);
            this.Controls.Add(this.lbln1);
            this.Controls.Add(this.lblid);
            this.Name = "frmProva";
            this.Text = "Prova";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lbln1;
        private System.Windows.Forms.Label lbln2;
        private System.Windows.Forms.Label lbln3;
        private System.Windows.Forms.Label lblEx;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtEx;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblGer;
        private System.Windows.Forms.TextBox txtGer;
        private System.Windows.Forms.Label lblFoi;
        private System.Windows.Forms.Label lblconceito;
        private System.Windows.Forms.Label lblsituacao;
        private System.Windows.Forms.TextBox txtConceito;
        private System.Windows.Forms.TextBox txtSituacao;
    }
}