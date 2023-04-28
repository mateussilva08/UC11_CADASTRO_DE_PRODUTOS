namespace UC11_CADASTRO_DE_PRODUTOS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDESCRICAO = new System.Windows.Forms.TextBox();
            this.textBoxCATEGORIA = new System.Windows.Forms.TextBox();
            this.textBoxPRECO = new System.Windows.Forms.TextBox();
            this.labelDESCRICAO = new System.Windows.Forms.Label();
            this.labelCATEGORIA = new System.Windows.Forms.Label();
            this.labelPRECO = new System.Windows.Forms.Label();
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.buttonLIMPAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDESCRICAO
            // 
            this.textBoxDESCRICAO.Location = new System.Drawing.Point(167, 88);
            this.textBoxDESCRICAO.Name = "textBoxDESCRICAO";
            this.textBoxDESCRICAO.Size = new System.Drawing.Size(194, 20);
            this.textBoxDESCRICAO.TabIndex = 0;
            // 
            // textBoxCATEGORIA
            // 
            this.textBoxCATEGORIA.Location = new System.Drawing.Point(167, 163);
            this.textBoxCATEGORIA.Name = "textBoxCATEGORIA";
            this.textBoxCATEGORIA.Size = new System.Drawing.Size(194, 20);
            this.textBoxCATEGORIA.TabIndex = 1;
            // 
            // textBoxPRECO
            // 
            this.textBoxPRECO.Location = new System.Drawing.Point(167, 248);
            this.textBoxPRECO.Name = "textBoxPRECO";
            this.textBoxPRECO.Size = new System.Drawing.Size(194, 20);
            this.textBoxPRECO.TabIndex = 2;
            // 
            // labelDESCRICAO
            // 
            this.labelDESCRICAO.AutoSize = true;
            this.labelDESCRICAO.BackColor = System.Drawing.Color.Transparent;
            this.labelDESCRICAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDESCRICAO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDESCRICAO.Location = new System.Drawing.Point(164, 50);
            this.labelDESCRICAO.Name = "labelDESCRICAO";
            this.labelDESCRICAO.Size = new System.Drawing.Size(158, 16);
            this.labelDESCRICAO.TabIndex = 3;
            this.labelDESCRICAO.Text = "Descrição do Produto";
            // 
            // labelCATEGORIA
            // 
            this.labelCATEGORIA.AutoSize = true;
            this.labelCATEGORIA.BackColor = System.Drawing.Color.Transparent;
            this.labelCATEGORIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCATEGORIA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCATEGORIA.Location = new System.Drawing.Point(164, 131);
            this.labelCATEGORIA.Name = "labelCATEGORIA";
            this.labelCATEGORIA.Size = new System.Drawing.Size(155, 16);
            this.labelCATEGORIA.TabIndex = 4;
            this.labelCATEGORIA.Text = "Categoria do Produto";
            // 
            // labelPRECO
            // 
            this.labelPRECO.AutoSize = true;
            this.labelPRECO.BackColor = System.Drawing.Color.Transparent;
            this.labelPRECO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPRECO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPRECO.Location = new System.Drawing.Point(164, 207);
            this.labelPRECO.Name = "labelPRECO";
            this.labelPRECO.Size = new System.Drawing.Size(48, 16);
            this.labelPRECO.TabIndex = 5;
            this.labelPRECO.Text = "Preço";
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCADASTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCADASTRAR.Location = new System.Drawing.Point(167, 308);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(75, 23);
            this.buttonCADASTRAR.TabIndex = 6;
            this.buttonCADASTRAR.Text = "Cadastrar";
            this.buttonCADASTRAR.UseVisualStyleBackColor = false;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.buttonCADASTRAR_Click);
            // 
            // buttonLIMPAR
            // 
            this.buttonLIMPAR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLIMPAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLIMPAR.Location = new System.Drawing.Point(286, 308);
            this.buttonLIMPAR.Name = "buttonLIMPAR";
            this.buttonLIMPAR.Size = new System.Drawing.Size(75, 23);
            this.buttonLIMPAR.TabIndex = 7;
            this.buttonLIMPAR.Text = "Limpar";
            this.buttonLIMPAR.UseVisualStyleBackColor = false;
            this.buttonLIMPAR.Click += new System.EventHandler(this.buttonLIMPAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UC11_CADASTRO_DE_PRODUTOS.Properties.Resources.bg_azul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(538, 485);
            this.Controls.Add(this.buttonLIMPAR);
            this.Controls.Add(this.buttonCADASTRAR);
            this.Controls.Add(this.labelPRECO);
            this.Controls.Add(this.labelCATEGORIA);
            this.Controls.Add(this.labelDESCRICAO);
            this.Controls.Add(this.textBoxPRECO);
            this.Controls.Add(this.textBoxCATEGORIA);
            this.Controls.Add(this.textBoxDESCRICAO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDESCRICAO;
        private System.Windows.Forms.TextBox textBoxCATEGORIA;
        private System.Windows.Forms.TextBox textBoxPRECO;
        private System.Windows.Forms.Label labelDESCRICAO;
        private System.Windows.Forms.Label labelCATEGORIA;
        private System.Windows.Forms.Label labelPRECO;
        private System.Windows.Forms.Button buttonCADASTRAR;
        private System.Windows.Forms.Button buttonLIMPAR;
    }
}

