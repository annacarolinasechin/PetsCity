namespace PetsCity
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
            this.lblNomePet = new System.Windows.Forms.Label();
            this.lblPrecoServico = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblIdadeAnimal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.lblParcela = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomePet = new System.Windows.Forms.TextBox();
            this.txtIdadeAnimal = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPrecoServico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomePet
            // 
            this.lblNomePet.AutoSize = true;
            this.lblNomePet.BackColor = System.Drawing.Color.Transparent;
            this.lblNomePet.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePet.ForeColor = System.Drawing.Color.Green;
            this.lblNomePet.Location = new System.Drawing.Point(31, 200);
            this.lblNomePet.Name = "lblNomePet";
            this.lblNomePet.Size = new System.Drawing.Size(140, 23);
            this.lblNomePet.TabIndex = 0;
            this.lblNomePet.Text = "NOME DO PET:";
            // 
            // lblPrecoServico
            // 
            this.lblPrecoServico.AutoSize = true;
            this.lblPrecoServico.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecoServico.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoServico.ForeColor = System.Drawing.Color.Green;
            this.lblPrecoServico.Location = new System.Drawing.Point(27, 238);
            this.lblPrecoServico.Name = "lblPrecoServico";
            this.lblPrecoServico.Size = new System.Drawing.Size(197, 23);
            this.lblPrecoServico.TabIndex = 1;
            this.lblPrecoServico.Text = "PREÇO DO SERVIÇO:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.Green;
            this.lblQuantidade.Location = new System.Drawing.Point(27, 278);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(246, 23);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "QNT. DE BANHOS NO MES:";
            this.lblQuantidade.Click += new System.EventHandler(this.lblQuantidade_Click);
            // 
            // lblIdadeAnimal
            // 
            this.lblIdadeAnimal.AutoSize = true;
            this.lblIdadeAnimal.BackColor = System.Drawing.Color.Transparent;
            this.lblIdadeAnimal.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdadeAnimal.ForeColor = System.Drawing.Color.Green;
            this.lblIdadeAnimal.Location = new System.Drawing.Point(33, 321);
            this.lblIdadeAnimal.Name = "lblIdadeAnimal";
            this.lblIdadeAnimal.Size = new System.Drawing.Size(138, 23);
            this.lblIdadeAnimal.TabIndex = 3;
            this.lblIdadeAnimal.Text = "IDADE DO PET:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(496, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 4;
            // 
            // btnCalculo
            // 
            this.btnCalculo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculo.ForeColor = System.Drawing.Color.Green;
            this.btnCalculo.Location = new System.Drawing.Point(206, 374);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 5;
            this.btnCalculo.Text = "Calcular!";
            this.btnCalculo.UseVisualStyleBackColor = false;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(79, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 10;
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblValorFinal.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFinal.ForeColor = System.Drawing.Color.Green;
            this.lblValorFinal.Location = new System.Drawing.Point(489, 278);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(136, 23);
            this.lblValorFinal.TabIndex = 9;
            this.lblValorFinal.Text = "VALOR TOTAL:";
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.BackColor = System.Drawing.Color.Transparent;
            this.lblParcela.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcela.ForeColor = System.Drawing.Color.Green;
            this.lblParcela.Location = new System.Drawing.Point(490, 321);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(158, 23);
            this.lblParcela.TabIndex = 8;
            this.lblParcela.Text = "PARCELAMENTO";
            this.lblParcela.Click += new System.EventHandler(this.lblParcela_Click);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.BackColor = System.Drawing.Color.Transparent;
            this.lblDesconto.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.ForeColor = System.Drawing.Color.Green;
            this.lblDesconto.Location = new System.Drawing.Point(490, 232);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(117, 23);
            this.lblDesconto.TabIndex = 7;
            this.lblDesconto.Text = "DESCONTO:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Green;
            this.lblNome.Location = new System.Drawing.Point(490, 184);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(140, 23);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "NOME DO PET:";
            // 
            // txtNomePet
            // 
            this.txtNomePet.Location = new System.Drawing.Point(206, 200);
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.Size = new System.Drawing.Size(146, 20);
            this.txtNomePet.TabIndex = 11;
            // 
            // txtIdadeAnimal
            // 
            this.txtIdadeAnimal.Location = new System.Drawing.Point(193, 321);
            this.txtIdadeAnimal.Name = "txtIdadeAnimal";
            this.txtIdadeAnimal.Size = new System.Drawing.Size(146, 20);
            this.txtIdadeAnimal.TabIndex = 13;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(298, 282);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(146, 20);
            this.txtQuantidade.TabIndex = 16;
            // 
            // txtPrecoServico
            // 
            this.txtPrecoServico.Location = new System.Drawing.Point(255, 238);
            this.txtPrecoServico.Name = "txtPrecoServico";
            this.txtPrecoServico.Size = new System.Drawing.Size(146, 20);
            this.txtPrecoServico.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PetsCity.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(903, 512);
            this.Controls.Add(this.txtPrecoServico);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtIdadeAnimal);
            this.Controls.Add(this.txtNomePet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValorFinal);
            this.Controls.Add(this.lblParcela);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblIdadeAnimal);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPrecoServico);
            this.Controls.Add(this.lblNomePet);
            this.Name = "Form1";
            this.Text = "PetsCity!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomePet;
        private System.Windows.Forms.Label lblPrecoServico;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblIdadeAnimal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomePet;
        private System.Windows.Forms.TextBox txtIdadeAnimal;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPrecoServico;
    }
}

