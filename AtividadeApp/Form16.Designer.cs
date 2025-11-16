namespace AtividadeApp
{
    partial class frmTabuada
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
            this.btnwhile = new System.Windows.Forms.Button();
            this.btndowhile = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblnum = new System.Windows.Forms.Label();
            this.lbltab = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txttab = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnwhile
            // 
            this.btnwhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwhile.Location = new System.Drawing.Point(181, 254);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(83, 33);
            this.btnwhile.TabIndex = 0;
            this.btnwhile.Text = "While";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // btndowhile
            // 
            this.btndowhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndowhile.Location = new System.Drawing.Point(181, 308);
            this.btndowhile.Name = "btndowhile";
            this.btndowhile.Size = new System.Drawing.Size(106, 33);
            this.btndowhile.TabIndex = 1;
            this.btndowhile.Text = "Do while";
            this.btndowhile.UseVisualStyleBackColor = true;
            this.btndowhile.Click += new System.EventHandler(this.btndowhile_Click);
            // 
            // btnfor
            // 
            this.btnfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfor.Location = new System.Drawing.Point(181, 369);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(78, 32);
            this.btnfor.TabIndex = 2;
            this.btnfor.Text = "For";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(522, 312);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(78, 30);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(362, 312);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(76, 30);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(178, 84);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(316, 20);
            this.lblnum.TabIndex = 5;
            this.lblnum.Text = "Digite o número para ver sua tabuada:";
            this.lblnum.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbltab
            // 
            this.lbltab.AutoSize = true;
            this.lbltab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltab.Location = new System.Drawing.Point(177, 132);
            this.lbltab.Name = "lbltab";
            this.lbltab.Size = new System.Drawing.Size(129, 20);
            this.lbltab.TabIndex = 6;
            this.lbltab.Text = "sua tabuada é:";
            // 
            // txtnum
            // 
            this.txtnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.Location = new System.Drawing.Point(500, 84);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 26);
            this.txtnum.TabIndex = 7;
            // 
            // txttab
            // 
            this.txttab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttab.Location = new System.Drawing.Point(312, 126);
            this.txttab.Multiline = true;
            this.txttab.Name = "txttab";
            this.txttab.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txttab.Size = new System.Drawing.Size(47, 161);
            this.txttab.TabIndex = 8;
            // 
            // frmTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttab);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lbltab);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.btndowhile);
            this.Controls.Add(this.btnwhile);
            this.Name = "frmTabuada";
            this.Text = "tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Button btndowhile;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lbltab;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txttab;
    }
}