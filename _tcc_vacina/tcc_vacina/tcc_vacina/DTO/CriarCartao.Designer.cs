namespace tcc_vacina.DTO
{
    partial class CriarCartao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarCartao));
            this.buttonFechar = new System.Windows.Forms.Button();
            this.textBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.labelConfirmarSenha = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxConfirmarSenha = new System.Windows.Forms.TextBox();
            this.panelConfirmarSenha = new System.Windows.Forms.Panel();
            this.panelSenha = new System.Windows.Forms.Panel();
            this.labelCPF = new System.Windows.Forms.Label();
            this.panelCPF = new System.Windows.Forms.Panel();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.panelTelefone = new System.Windows.Forms.Panel();
            this.panelNome = new System.Windows.Forms.Panel();
            this.labelCEP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateNascimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEndereco = new System.Windows.Forms.Panel();
            this.textBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.buttonCriarConta = new System.Windows.Forms.Button();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFechar
            // 
            this.buttonFechar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonFechar.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonFechar.BackgroundImage = global::tcc_vacina.Properties.Resources.fechar;
            this.buttonFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFechar.FlatAppearance.BorderSize = 0;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Location = new System.Drawing.Point(799, 0);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(24, 24);
            this.buttonFechar.TabIndex = 66;
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxTelefone.BackColor = System.Drawing.Color.White;
            this.textBoxTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTelefone.Location = new System.Drawing.Point(63, 365);
            this.textBoxTelefone.Mask = "(99) 00000-0000";
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(302, 13);
            this.textBoxTelefone.TabIndex = 92;
            // 
            // labelConfirmarSenha
            // 
            this.labelConfirmarSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelConfirmarSenha.AutoSize = true;
            this.labelConfirmarSenha.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmarSenha.Location = new System.Drawing.Point(456, 428);
            this.labelConfirmarSenha.Name = "labelConfirmarSenha";
            this.labelConfirmarSenha.Size = new System.Drawing.Size(109, 18);
            this.labelConfirmarSenha.TabIndex = 91;
            this.labelConfirmarSenha.Text = "Confirmar senha";
            // 
            // labelSenha
            // 
            this.labelSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(60, 428);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(46, 18);
            this.labelSenha.TabIndex = 90;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSenha.BackColor = System.Drawing.Color.White;
            this.textBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSenha.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.Location = new System.Drawing.Point(61, 457);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(302, 19);
            this.textBoxSenha.TabIndex = 89;
            this.textBoxSenha.UseSystemPasswordChar = true;
            // 
            // textBoxConfirmarSenha
            // 
            this.textBoxConfirmarSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxConfirmarSenha.BackColor = System.Drawing.Color.White;
            this.textBoxConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirmarSenha.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmarSenha.Location = new System.Drawing.Point(459, 457);
            this.textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            this.textBoxConfirmarSenha.PasswordChar = '*';
            this.textBoxConfirmarSenha.Size = new System.Drawing.Size(302, 19);
            this.textBoxConfirmarSenha.TabIndex = 88;
            this.textBoxConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // panelConfirmarSenha
            // 
            this.panelConfirmarSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelConfirmarSenha.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelConfirmarSenha.Location = new System.Drawing.Point(459, 477);
            this.panelConfirmarSenha.Name = "panelConfirmarSenha";
            this.panelConfirmarSenha.Size = new System.Drawing.Size(302, 1);
            this.panelConfirmarSenha.TabIndex = 86;
            // 
            // panelSenha
            // 
            this.panelSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelSenha.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelSenha.Location = new System.Drawing.Point(61, 477);
            this.panelSenha.Name = "panelSenha";
            this.panelSenha.Size = new System.Drawing.Size(302, 1);
            this.panelSenha.TabIndex = 87;
            // 
            // labelCPF
            // 
            this.labelCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPF.Location = new System.Drawing.Point(60, 50);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(31, 18);
            this.labelCPF.TabIndex = 84;
            this.labelCPF.Text = "CPF";
            // 
            // panelCPF
            // 
            this.panelCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelCPF.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelCPF.Location = new System.Drawing.Point(64, 99);
            this.panelCPF.Name = "panelCPF";
            this.panelCPF.Size = new System.Drawing.Size(302, 1);
            this.panelCPF.TabIndex = 81;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(462, 235);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 18);
            this.labelEmail.TabIndex = 79;
            this.labelEmail.Text = "Email";
            // 
            // labelEndereco
            // 
            this.labelEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.Location = new System.Drawing.Point(60, 235);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(66, 18);
            this.labelEndereco.TabIndex = 78;
            this.labelEndereco.Text = "Endereço";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxEndereco.BackColor = System.Drawing.Color.White;
            this.textBoxEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEndereco.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEndereco.Location = new System.Drawing.Point(63, 262);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(302, 19);
            this.textBoxEndereco.TabIndex = 77;
            // 
            // panelEmail
            // 
            this.panelEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelEmail.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelEmail.Location = new System.Drawing.Point(462, 282);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(302, 1);
            this.panelEmail.TabIndex = 74;
            // 
            // labelTelefone
            // 
            this.labelTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone.Location = new System.Drawing.Point(60, 334);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(63, 18);
            this.labelTelefone.TabIndex = 73;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelNome
            // 
            this.labelNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(462, 50);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(108, 18);
            this.labelNome.TabIndex = 72;
            this.labelNome.Text = "Nome completo";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNome.BackColor = System.Drawing.Color.White;
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNome.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(465, 79);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(302, 19);
            this.textBoxNome.TabIndex = 71;
            // 
            // panelTelefone
            // 
            this.panelTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelTelefone.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelTelefone.Location = new System.Drawing.Point(63, 381);
            this.panelTelefone.Name = "panelTelefone";
            this.panelTelefone.Size = new System.Drawing.Size(302, 1);
            this.panelTelefone.TabIndex = 69;
            // 
            // panelNome
            // 
            this.panelNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelNome.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelNome.Location = new System.Drawing.Point(465, 99);
            this.panelNome.Name = "panelNome";
            this.panelNome.Size = new System.Drawing.Size(302, 1);
            this.panelNome.TabIndex = 70;
            // 
            // labelCEP
            // 
            this.labelCEP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCEP.AutoSize = true;
            this.labelCEP.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCEP.Location = new System.Drawing.Point(466, 141);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(31, 18);
            this.labelCEP.TabIndex = 95;
            this.labelCEP.Text = "CEP";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(467, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 1);
            this.panel1.TabIndex = 93;
            // 
            // dateNascimento
            // 
            this.dateNascimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNascimento.Location = new System.Drawing.Point(63, 171);
            this.dateNascimento.Name = "dateNascimento";
            this.dateNascimento.Size = new System.Drawing.Size(310, 20);
            this.dateNascimento.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 97;
            this.label1.Text = "Data de nascimento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelEndereco
            // 
            this.panelEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelEndereco.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelEndereco.Location = new System.Drawing.Point(63, 282);
            this.panelEndereco.Name = "panelEndereco";
            this.panelEndereco.Size = new System.Drawing.Size(302, 1);
            this.panelEndereco.TabIndex = 98;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCPF.BackColor = System.Drawing.Color.White;
            this.textBoxCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCPF.Location = new System.Drawing.Point(64, 83);
            this.textBoxCPF.Mask = "999,999,999-99";
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(302, 13);
            this.textBoxCPF.TabIndex = 99;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxEmail.BackColor = System.Drawing.Color.White;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(462, 262);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(302, 19);
            this.textBoxEmail.TabIndex = 76;
            // 
            // textBoxCEP
            // 
            this.textBoxCEP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCEP.BackColor = System.Drawing.Color.White;
            this.textBoxCEP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCEP.Location = new System.Drawing.Point(468, 174);
            this.textBoxCEP.Mask = "99999-000";
            this.textBoxCEP.Name = "textBoxCEP";
            this.textBoxCEP.Size = new System.Drawing.Size(302, 13);
            this.textBoxCEP.TabIndex = 100;
            // 
            // buttonCriarConta
            // 
            this.buttonCriarConta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCriarConta.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCriarConta.FlatAppearance.BorderSize = 0;
            this.buttonCriarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCriarConta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarConta.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCriarConta.Location = new System.Drawing.Point(347, 551);
            this.buttonCriarConta.Name = "buttonCriarConta";
            this.buttonCriarConta.Size = new System.Drawing.Size(159, 35);
            this.buttonCriarConta.TabIndex = 101;
            this.buttonCriarConta.Text = "Criar cartão";
            this.buttonCriarConta.UseVisualStyleBackColor = false;
            this.buttonCriarConta.Click += new System.EventHandler(this.buttonCriarCartao_Click);
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.radioButtonMasculino.Location = new System.Drawing.Point(462, 365);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(89, 22);
            this.radioButtonMasculino.TabIndex = 102;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.radioButtonFeminino.Location = new System.Drawing.Point(585, 365);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(85, 22);
            this.radioButtonFeminino.TabIndex = 103;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 104;
            this.label2.Text = "Sexo";
            // 
            // CriarCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonFeminino);
            this.Controls.Add(this.radioButtonMasculino);
            this.Controls.Add(this.buttonCriarConta);
            this.Controls.Add(this.textBoxCEP);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.panelEndereco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateNascimento);
            this.Controls.Add(this.labelCEP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.labelConfirmarSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxConfirmarSenha);
            this.Controls.Add(this.panelConfirmarSenha);
            this.Controls.Add(this.panelSenha);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.panelCPF);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.panelTelefone);
            this.Controls.Add(this.panelNome);
            this.Controls.Add(this.buttonFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriarCartao";
            this.Load += new System.EventHandler(this.CriarCartao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.MaskedTextBox textBoxTelefone;
        private System.Windows.Forms.Label labelConfirmarSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxConfirmarSenha;
        private System.Windows.Forms.Panel panelConfirmarSenha;
        private System.Windows.Forms.Panel panelSenha;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Panel panelCPF;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Panel panelTelefone;
        private System.Windows.Forms.Panel panelNome;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateNascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEndereco;
        private System.Windows.Forms.MaskedTextBox textBoxCPF;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.MaskedTextBox textBoxCEP;
        private System.Windows.Forms.Button buttonCriarConta;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.Label label2;
    }
}