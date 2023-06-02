namespace calculo_imc
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
            this.tx_nome = new System.Windows.Forms.Label();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_peso = new System.Windows.Forms.TextBox();
            this.text_altura = new System.Windows.Forms.TextBox();
            this.text_idade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_resul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_nome
            // 
            this.tx_nome.AutoSize = true;
            this.tx_nome.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nome.ForeColor = System.Drawing.Color.Maroon;
            this.tx_nome.Location = new System.Drawing.Point(235, 53);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(310, 65);
            this.tx_nome.TabIndex = 0;
            this.tx_nome.Text = "Cálculo IMC";
            this.tx_nome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_sexo
            // 
            this.cb_sexo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cb_sexo.ForeColor = System.Drawing.Color.Maroon;
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Prefiro não dizer"});
            this.cb_sexo.Location = new System.Drawing.Point(296, 189);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(121, 21);
            this.cb_sexo.TabIndex = 1;
            this.cb_sexo.UseWaitCursor = true;
            this.cb_sexo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // text_nome
            // 
            this.text_nome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.text_nome.Location = new System.Drawing.Point(308, 137);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(229, 20);
            this.text_nome.TabIndex = 2;
            this.text_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_cpf
            // 
            this.text_cpf.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.text_cpf.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.text_cpf.ForeColor = System.Drawing.Color.Maroon;
            this.text_cpf.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.text_cpf.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.text_cpf.Location = new System.Drawing.Point(296, 163);
            this.text_cpf.Mask = "000.000.000-00";
            this.text_cpf.Name = "text_cpf";
            this.text_cpf.Size = new System.Drawing.Size(100, 20);
            this.text_cpf.TabIndex = 4;
            this.text_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Peso:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Altura:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(477, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Idade:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // text_peso
            // 
            this.text_peso.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.text_peso.ForeColor = System.Drawing.Color.Maroon;
            this.text_peso.Location = new System.Drawing.Point(190, 295);
            this.text_peso.Name = "text_peso";
            this.text_peso.Size = new System.Drawing.Size(71, 20);
            this.text_peso.TabIndex = 12;
            this.text_peso.TextChanged += new System.EventHandler(this.text_peso_TextChanged);
            // 
            // text_altura
            // 
            this.text_altura.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.text_altura.ForeColor = System.Drawing.Color.Maroon;
            this.text_altura.Location = new System.Drawing.Point(325, 295);
            this.text_altura.Name = "text_altura";
            this.text_altura.Size = new System.Drawing.Size(71, 20);
            this.text_altura.TabIndex = 13;
            this.text_altura.TextChanged += new System.EventHandler(this.text_altura_TextChanged);
            // 
            // text_idade
            // 
            this.text_idade.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.text_idade.ForeColor = System.Drawing.Color.Maroon;
            this.text_idade.Location = new System.Drawing.Point(466, 295);
            this.text_idade.Name = "text_idade";
            this.text_idade.Size = new System.Drawing.Size(71, 20);
            this.text_idade.TabIndex = 14;
            this.text_idade.TextChanged += new System.EventHandler(this.idade_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(342, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_resul
            // 
            this.lb_resul.AutoSize = true;
            this.lb_resul.Location = new System.Drawing.Point(346, 404);
            this.lb_resul.Name = "lb_resul";
            this.lb_resul.Size = new System.Drawing.Size(0, 13);
            this.lb_resul.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_resul);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_idade);
            this.Controls.Add(this.text_altura);
            this.Controls.Add(this.text_peso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_cpf);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.tx_nome);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tx_nome;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.MaskedTextBox text_cpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_peso;
        private System.Windows.Forms.TextBox text_altura;
        private System.Windows.Forms.TextBox text_idade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_resul;
    }
}

