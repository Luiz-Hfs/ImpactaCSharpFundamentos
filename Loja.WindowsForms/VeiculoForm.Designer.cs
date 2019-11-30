namespace Loja.WindowsForms
{
    partial class VeiculoForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.placaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.anoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
            this.modeloComboBox = new System.Windows.Forms.ComboBox();
            this.cambioComboBox = new System.Windows.Forms.ComboBox();
            this.combustivelComboBox = new System.Windows.Forms.ComboBox();
            this.gravarButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.observacaoTextBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.corComboBox = new System.Windows.Forms.ComboBox();
            this.veiculoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.observacaoTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Câmbio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Combustível";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(419, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cor";
            // 
            // placaMaskedTextBox
            // 
            this.placaMaskedTextBox.Location = new System.Drawing.Point(112, 13);
            this.placaMaskedTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.placaMaskedTextBox.Mask = ">LLL<-0000";
            this.placaMaskedTextBox.Name = "placaMaskedTextBox";
            this.placaMaskedTextBox.Size = new System.Drawing.Size(252, 26);
            this.placaMaskedTextBox.TabIndex = 1;
            this.placaMaskedTextBox.Tag = "*PLACA";
            this.placaMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            
            // anoMaskedTextBox
            // 
            this.anoMaskedTextBox.Location = new System.Drawing.Point(112, 156);
            this.anoMaskedTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.anoMaskedTextBox.Mask = "0000";
            this.anoMaskedTextBox.Name = "anoMaskedTextBox";
            this.anoMaskedTextBox.Size = new System.Drawing.Size(252, 26);
            this.anoMaskedTextBox.TabIndex = 7;
            this.anoMaskedTextBox.Tag = "*ANO";
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Location = new System.Drawing.Point(112, 54);
            this.marcaComboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(252, 27);
            this.marcaComboBox.TabIndex = 3;
            this.marcaComboBox.Tag = "*";
            this.marcaComboBox.SelectedIndexChanged += new System.EventHandler(this.marcaComboBox_SelectedIndexChanged);
            // 
            // modeloComboBox
            // 
            this.modeloComboBox.FormattingEnabled = true;
            this.modeloComboBox.Location = new System.Drawing.Point(112, 106);
            this.modeloComboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.modeloComboBox.Name = "modeloComboBox";
            this.modeloComboBox.Size = new System.Drawing.Size(252, 27);
            this.modeloComboBox.TabIndex = 5;
            this.modeloComboBox.Tag = "*";
            // 
            // cambioComboBox
            // 
            this.cambioComboBox.FormattingEnabled = true;
            this.cambioComboBox.Location = new System.Drawing.Point(493, 106);
            this.cambioComboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cambioComboBox.Name = "cambioComboBox";
            this.cambioComboBox.Size = new System.Drawing.Size(252, 27);
            this.cambioComboBox.TabIndex = 13;
            this.cambioComboBox.Tag = "*";
            // 
            // combustivelComboBox
            // 
            this.combustivelComboBox.FormattingEnabled = true;
            this.combustivelComboBox.Location = new System.Drawing.Point(493, 54);
            this.combustivelComboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.combustivelComboBox.Name = "combustivelComboBox";
            this.combustivelComboBox.Size = new System.Drawing.Size(252, 27);
            this.combustivelComboBox.TabIndex = 11;
            this.combustivelComboBox.Tag = "*";
            // 
            // gravarButton
            // 
            this.gravarButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravarButton.Location = new System.Drawing.Point(774, 10);
            this.gravarButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(103, 44);
            this.gravarButton.TabIndex = 15;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // limparButton
            // 
            this.limparButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparButton.Location = new System.Drawing.Point(774, 62);
            this.limparButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(103, 44);
            this.limparButton.TabIndex = 16;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.Controls.Add(this.textBox1);
            this.observacaoTextBox.Location = new System.Drawing.Point(12, 189);
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(877, 141);
            this.observacaoTextBox.TabIndex = 14;
            this.observacaoTextBox.TabStop = false;
            this.observacaoTextBox.Text = "Observação (300)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(873, 121);
            this.textBox1.TabIndex = 0;
            // 
            // corComboBox
            // 
            this.corComboBox.FormattingEnabled = true;
            this.corComboBox.Location = new System.Drawing.Point(493, 10);
            this.corComboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.corComboBox.Name = "corComboBox";
            this.corComboBox.Size = new System.Drawing.Size(252, 27);
            this.corComboBox.TabIndex = 9;
            this.corComboBox.Tag = "*";
            // 
            // veiculoErrorProvider
            // 
            this.veiculoErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.veiculoErrorProvider.ContainerControl = this;
            // 
            // VeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 339);
            this.Controls.Add(this.corComboBox);
            this.Controls.Add(this.observacaoTextBox);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.cambioComboBox);
            this.Controls.Add(this.combustivelComboBox);
            this.Controls.Add(this.modeloComboBox);
            this.Controls.Add(this.marcaComboBox);
            this.Controls.Add(this.anoMaskedTextBox);
            this.Controls.Add(this.placaMaskedTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "VeiculoForm";
            this.Tag = "*";
            this.Text = "Cadastro de Veiculos";
            this.observacaoTextBox.ResumeLayout(false);
            this.observacaoTextBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox placaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox anoMaskedTextBox;
        private System.Windows.Forms.ComboBox marcaComboBox;
        private System.Windows.Forms.ComboBox modeloComboBox;
        private System.Windows.Forms.ComboBox cambioComboBox;
        private System.Windows.Forms.ComboBox combustivelComboBox;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.GroupBox observacaoTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox corComboBox;
        private System.Windows.Forms.ErrorProvider veiculoErrorProvider;
    }
}

