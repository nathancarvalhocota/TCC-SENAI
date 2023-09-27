namespace tcc_vacina.DTO
{
    partial class CriarCartaoInfantil
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
            this.labelDados = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.dateNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.panelNome = new System.Windows.Forms.Panel();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.textBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.panelCPF = new System.Windows.Forms.Panel();
            this.labelSexo = new System.Windows.Forms.Label();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.buttonCriarCartao = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDados
            // 
            this.labelDados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDados.AutoSize = true;
            this.labelDados.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDados.Location = new System.Drawing.Point(352, 19);
            this.labelDados.Name = "labelDados";
            this.labelDados.Size = new System.Drawing.Size(86, 18);
            this.labelDados.TabIndex = 144;
            this.labelDados.Text = "SEUS DADOS";
            this.labelDados.Visible = false;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonFechar.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonFechar.BackgroundImage = global::tcc_vacina.Properties.Resources.fechar;
            this.buttonFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFechar.FlatAppearance.BorderSize = 0;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Location = new System.Drawing.Point(776, 0);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(24, 24);
            this.buttonFechar.TabIndex = 145;
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // dateNascimento
            // 
            this.dateNascimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNascimento.Location = new System.Drawing.Point(464, 106);
            this.dateNascimento.Name = "dateNascimento";
            this.dateNascimento.Size = new System.Drawing.Size(310, 20);
            this.dateNascimento.TabIndex = 151;
            this.dateNascimento.Visible = false;
            // 
            // labelNome
            // 
            this.labelNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(68, 70);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(108, 18);
            this.labelNome.TabIndex = 148;
            this.labelNome.Text = "Nome completo";
            this.labelNome.Visible = false;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNome.BackColor = System.Drawing.Color.White;
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNome.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(71, 99);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(302, 19);
            this.textBoxNome.TabIndex = 147;
            this.textBoxNome.Visible = false;
            // 
            // panelNome
            // 
            this.panelNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelNome.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelNome.Location = new System.Drawing.Point(71, 119);
            this.panelNome.Name = "panelNome";
            this.panelNome.Size = new System.Drawing.Size(302, 1);
            this.panelNome.TabIndex = 146;
            this.panelNome.Visible = false;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataNascimento.Location = new System.Drawing.Point(461, 70);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(130, 18);
            this.labelDataNascimento.TabIndex = 152;
            this.labelDataNascimento.Text = "Data de nascimento";
            this.labelDataNascimento.Visible = false;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCPF.BackColor = System.Drawing.Color.White;
            this.textBoxCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCPF.Location = new System.Drawing.Point(259, 103);
            this.textBoxCPF.Mask = "999,999,999-99";
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(302, 13);
            this.textBoxCPF.TabIndex = 155;
            // 
            // labelCPF
            // 
            this.labelCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPF.Location = new System.Drawing.Point(255, 70);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(128, 18);
            this.labelCPF.TabIndex = 154;
            this.labelCPF.Text = "CPF do responsável";
            // 
            // panelCPF
            // 
            this.panelCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelCPF.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelCPF.Location = new System.Drawing.Point(259, 119);
            this.panelCPF.Name = "panelCPF";
            this.panelCPF.Size = new System.Drawing.Size(302, 1);
            this.panelCPF.TabIndex = 153;
            // 
            // labelSexo
            // 
            this.labelSexo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.Location = new System.Drawing.Point(288, 159);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(38, 18);
            this.labelSexo.TabIndex = 158;
            this.labelSexo.Text = "Sexo";
            this.labelSexo.Visible = false;
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.radioButtonFeminino.Location = new System.Drawing.Point(417, 190);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(85, 22);
            this.radioButtonFeminino.TabIndex = 157;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            this.radioButtonFeminino.Visible = false;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.radioButtonMasculino.Location = new System.Drawing.Point(294, 190);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(89, 22);
            this.radioButtonMasculino.TabIndex = 156;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            this.radioButtonMasculino.Visible = false;
            // 
            // buttonCriarCartao
            // 
            this.buttonCriarCartao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCriarCartao.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCriarCartao.FlatAppearance.BorderSize = 0;
            this.buttonCriarCartao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCriarCartao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarCartao.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCriarCartao.Location = new System.Drawing.Point(338, 243);
            this.buttonCriarCartao.Name = "buttonCriarCartao";
            this.buttonCriarCartao.Size = new System.Drawing.Size(127, 35);
            this.buttonCriarCartao.TabIndex = 160;
            this.buttonCriarCartao.Text = "Criar cartão";
            this.buttonCriarCartao.UseVisualStyleBackColor = false;
            this.buttonCriarCartao.Visible = false;
            this.buttonCriarCartao.Click += new System.EventHandler(this.buttonCriarCartao_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonOK.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOK.Location = new System.Drawing.Point(354, 150);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(93, 35);
            this.buttonOK.TabIndex = 159;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // CriarCartaoInfantil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCriarCartao);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.radioButtonFeminino);
            this.Controls.Add(this.radioButtonMasculino);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.panelCPF);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.dateNascimento);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.panelNome);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.labelDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CriarCartaoInfantil";
            this.Text = "CriarCartaoInfantil";
            this.Load += new System.EventHandler(this.CriarCartaoInfantil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDados;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.DateTimePicker dateNascimento;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Panel panelNome;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.MaskedTextBox textBoxCPF;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Panel panelCPF;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.Button buttonCriarCartao;
        private System.Windows.Forms.Button buttonOK;
    }
}