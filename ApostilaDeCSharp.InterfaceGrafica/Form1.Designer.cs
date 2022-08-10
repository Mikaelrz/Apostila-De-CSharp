namespace ApostilaDeCSharp.InterfaceGrafica
{
    partial class Form1
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
            this.btnVoar = new System.Windows.Forms.Button();
            this.btnNadar = new System.Windows.Forms.Button();
            this.btnPular = new System.Windows.Forms.Button();
            this.btnVirarAEsquerda = new System.Windows.Forms.Button();
            this.btnVirarADireita = new System.Windows.Forms.Button();
            this.btnAndar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPonto = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVoar
            // 
            this.btnVoar.Location = new System.Drawing.Point(58, 125);
            this.btnVoar.Name = "btnVoar";
            this.btnVoar.Size = new System.Drawing.Size(75, 23);
            this.btnVoar.TabIndex = 0;
            this.btnVoar.Text = "Voar";
            this.btnVoar.UseVisualStyleBackColor = true;
            this.btnVoar.Click += new System.EventHandler(this.btnVoar_Click);
            // 
            // btnNadar
            // 
            this.btnNadar.Location = new System.Drawing.Point(165, 125);
            this.btnNadar.Name = "btnNadar";
            this.btnNadar.Size = new System.Drawing.Size(75, 23);
            this.btnNadar.TabIndex = 1;
            this.btnNadar.Text = "Nadar";
            this.btnNadar.UseVisualStyleBackColor = true;
            this.btnNadar.Click += new System.EventHandler(this.btnNadar_Click);
            // 
            // btnPular
            // 
            this.btnPular.Location = new System.Drawing.Point(292, 125);
            this.btnPular.Name = "btnPular";
            this.btnPular.Size = new System.Drawing.Size(75, 23);
            this.btnPular.TabIndex = 2;
            this.btnPular.Text = "Pular";
            this.btnPular.UseVisualStyleBackColor = true;
            this.btnPular.Click += new System.EventHandler(this.btnPular_Click);
            // 
            // btnVirarAEsquerda
            // 
            this.btnVirarAEsquerda.Location = new System.Drawing.Point(403, 125);
            this.btnVirarAEsquerda.Name = "btnVirarAEsquerda";
            this.btnVirarAEsquerda.Size = new System.Drawing.Size(107, 23);
            this.btnVirarAEsquerda.TabIndex = 3;
            this.btnVirarAEsquerda.Text = "Virar a Esquerda";
            this.btnVirarAEsquerda.UseVisualStyleBackColor = true;
            this.btnVirarAEsquerda.Click += new System.EventHandler(this.btnVirarAEsquerda_Click);
            // 
            // btnVirarADireita
            // 
            this.btnVirarADireita.Location = new System.Drawing.Point(58, 185);
            this.btnVirarADireita.Name = "btnVirarADireita";
            this.btnVirarADireita.Size = new System.Drawing.Size(103, 23);
            this.btnVirarADireita.TabIndex = 4;
            this.btnVirarADireita.Text = "Virar a Direita";
            this.btnVirarADireita.UseVisualStyleBackColor = true;
            this.btnVirarADireita.Click += new System.EventHandler(this.btnVirarADireita_Click);
            // 
            // btnAndar
            // 
            this.btnAndar.Location = new System.Drawing.Point(187, 185);
            this.btnAndar.Name = "btnAndar";
            this.btnAndar.Size = new System.Drawing.Size(75, 23);
            this.btnAndar.TabIndex = 5;
            this.btnAndar.Text = "Andar";
            this.btnAndar.UseVisualStyleBackColor = true;
            this.btnAndar.Click += new System.EventHandler(this.btnAndar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(292, 185);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 6;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(403, 185);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total de Pontos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome do Personagem";
            // 
            // txtPonto
            // 
            this.txtPonto.Location = new System.Drawing.Point(185, 13);
            this.txtPonto.Name = "txtPonto";
            this.txtPonto.Size = new System.Drawing.Size(182, 20);
            this.txtPonto.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(185, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(182, 20);
            this.txtNome.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 283);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtPonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnAndar);
            this.Controls.Add(this.btnVirarADireita);
            this.Controls.Add(this.btnVirarAEsquerda);
            this.Controls.Add(this.btnPular);
            this.Controls.Add(this.btnNadar);
            this.Controls.Add(this.btnVoar);
            this.Name = "Form1";
            this.Text = "Drive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoar;
        private System.Windows.Forms.Button btnNadar;
        private System.Windows.Forms.Button btnPular;
        private System.Windows.Forms.Button btnVirarAEsquerda;
        private System.Windows.Forms.Button btnVirarADireita;
        private System.Windows.Forms.Button btnAndar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPonto;
        private System.Windows.Forms.TextBox txtNome;
    }
}

