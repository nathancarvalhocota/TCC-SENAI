namespace tcc_vacina.DTO
{
    partial class AtualizarCartao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizarCartao));
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelDose = new System.Windows.Forms.Label();
            this.panelCPF = new System.Windows.Forms.Panel();
            this.labelNomeVacina = new System.Windows.Forms.Label();
            this.radioButtonDose1 = new System.Windows.Forms.RadioButton();
            this.radioButtonDose2 = new System.Windows.Forms.RadioButton();
            this.radioButtonDose3 = new System.Windows.Forms.RadioButton();
            this.labelCPF = new System.Windows.Forms.Label();
            this.panelLote = new System.Windows.Forms.Panel();
            this.labelLote = new System.Windows.Forms.Label();
            this.textBoxLote = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.textBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.dateVacina = new System.Windows.Forms.DateTimePicker();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonCartaoAdulto = new System.Windows.Forms.Button();
            this.buttonCartaoInfantil = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.panelNome = new System.Windows.Forms.Panel();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.comboBoxNome = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonOK.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOK.Location = new System.Drawing.Point(362, 143);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(93, 35);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Visible = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelDose
            // 
            this.labelDose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDose.AutoSize = true;
            this.labelDose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDose.Location = new System.Drawing.Point(437, 53);
            this.labelDose.Name = "labelDose";
            this.labelDose.Size = new System.Drawing.Size(39, 18);
            this.labelDose.TabIndex = 101;
            this.labelDose.Text = "Dose";
            this.labelDose.Visible = false;
            // 
            // panelCPF
            // 
            this.panelCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelCPF.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelCPF.Location = new System.Drawing.Point(254, 101);
            this.panelCPF.Name = "panelCPF";
            this.panelCPF.Size = new System.Drawing.Size(281, 1);
            this.panelCPF.TabIndex = 100;
            this.panelCPF.Visible = false;
            // 
            // labelNomeVacina
            // 
            this.labelNomeVacina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNomeVacina.AutoSize = true;
            this.labelNomeVacina.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeVacina.Location = new System.Drawing.Point(97, 53);
            this.labelNomeVacina.Name = "labelNomeVacina";
            this.labelNomeVacina.Size = new System.Drawing.Size(106, 18);
            this.labelNomeVacina.TabIndex = 104;
            this.labelNomeVacina.Text = "Nome da vacina";
            this.labelNomeVacina.Visible = false;
            // 
            // radioButtonDose1
            // 
            this.radioButtonDose1.AutoSize = true;
            this.radioButtonDose1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDose1.Location = new System.Drawing.Point(440, 92);
            this.radioButtonDose1.Name = "radioButtonDose1";
            this.radioButtonDose1.Size = new System.Drawing.Size(72, 22);
            this.radioButtonDose1.TabIndex = 105;
            this.radioButtonDose1.TabStop = true;
            this.radioButtonDose1.Text = "1ª dose";
            this.radioButtonDose1.UseVisualStyleBackColor = true;
            this.radioButtonDose1.Visible = false;
            // 
            // radioButtonDose2
            // 
            this.radioButtonDose2.AutoSize = true;
            this.radioButtonDose2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDose2.Location = new System.Drawing.Point(530, 92);
            this.radioButtonDose2.Name = "radioButtonDose2";
            this.radioButtonDose2.Size = new System.Drawing.Size(72, 22);
            this.radioButtonDose2.TabIndex = 106;
            this.radioButtonDose2.TabStop = true;
            this.radioButtonDose2.Text = "2ª dose";
            this.radioButtonDose2.UseVisualStyleBackColor = true;
            this.radioButtonDose2.Visible = false;
            // 
            // radioButtonDose3
            // 
            this.radioButtonDose3.AutoSize = true;
            this.radioButtonDose3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDose3.Location = new System.Drawing.Point(624, 92);
            this.radioButtonDose3.Name = "radioButtonDose3";
            this.radioButtonDose3.Size = new System.Drawing.Size(72, 22);
            this.radioButtonDose3.TabIndex = 107;
            this.radioButtonDose3.TabStop = true;
            this.radioButtonDose3.Text = "3ª dose";
            this.radioButtonDose3.UseVisualStyleBackColor = true;
            this.radioButtonDose3.Visible = false;
            // 
            // labelCPF
            // 
            this.labelCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPF.Location = new System.Drawing.Point(251, 53);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(31, 18);
            this.labelCPF.TabIndex = 108;
            this.labelCPF.Text = "CPF";
            this.labelCPF.Visible = false;
            // 
            // panelLote
            // 
            this.panelLote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelLote.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelLote.Location = new System.Drawing.Point(102, 210);
            this.panelLote.Name = "panelLote";
            this.panelLote.Size = new System.Drawing.Size(281, 1);
            this.panelLote.TabIndex = 109;
            this.panelLote.Visible = false;
            // 
            // labelLote
            // 
            this.labelLote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLote.AutoSize = true;
            this.labelLote.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLote.Location = new System.Drawing.Point(97, 159);
            this.labelLote.Name = "labelLote";
            this.labelLote.Size = new System.Drawing.Size(95, 18);
            this.labelLote.TabIndex = 111;
            this.labelLote.Text = "Lote da vacina";
            this.labelLote.Visible = false;
            // 
            // textBoxLote
            // 
            this.textBoxLote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxLote.BackColor = System.Drawing.Color.White;
            this.textBoxLote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLote.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLote.Location = new System.Drawing.Point(104, 190);
            this.textBoxLote.Name = "textBoxLote";
            this.textBoxLote.Size = new System.Drawing.Size(279, 19);
            this.textBoxLote.TabIndex = 110;
            this.textBoxLote.Visible = false;
            // 
            // labelData
            // 
            this.labelData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(437, 159);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(114, 18);
            this.labelData.TabIndex = 113;
            this.labelData.Text = "Data da aplicação";
            this.labelData.Visible = false;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAtualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAtualizar.FlatAppearance.BorderSize = 0;
            this.buttonAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAtualizar.Location = new System.Drawing.Point(362, 259);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(93, 35);
            this.buttonAtualizar.TabIndex = 114;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = false;
            this.buttonAtualizar.Visible = false;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCPF.BackColor = System.Drawing.Color.White;
            this.textBoxCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCPF.Location = new System.Drawing.Point(254, 87);
            this.textBoxCPF.Mask = "999,999,999-99";
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(302, 13);
            this.textBoxCPF.TabIndex = 116;
            this.textBoxCPF.Visible = false;
            this.textBoxCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textBoxCPF_MaskInputRejected);
            // 
            // dateVacina
            // 
            this.dateVacina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateVacina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateVacina.Location = new System.Drawing.Point(437, 191);
            this.dateVacina.Name = "dateVacina";
            this.dateVacina.Size = new System.Drawing.Size(310, 20);
            this.dateVacina.TabIndex = 118;
            this.dateVacina.Visible = false;
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
            this.buttonFechar.TabIndex = 117;
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonCartaoAdulto
            // 
            this.buttonCartaoAdulto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCartaoAdulto.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCartaoAdulto.FlatAppearance.BorderSize = 0;
            this.buttonCartaoAdulto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCartaoAdulto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCartaoAdulto.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCartaoAdulto.Location = new System.Drawing.Point(176, 142);
            this.buttonCartaoAdulto.Name = "buttonCartaoAdulto";
            this.buttonCartaoAdulto.Size = new System.Drawing.Size(180, 35);
            this.buttonCartaoAdulto.TabIndex = 119;
            this.buttonCartaoAdulto.Text = "Atualizar cartão adulto";
            this.buttonCartaoAdulto.UseVisualStyleBackColor = false;
            this.buttonCartaoAdulto.Click += new System.EventHandler(this.buttonCartaoAdulto_Click);
            // 
            // buttonCartaoInfantil
            // 
            this.buttonCartaoInfantil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCartaoInfantil.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCartaoInfantil.FlatAppearance.BorderSize = 0;
            this.buttonCartaoInfantil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCartaoInfantil.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCartaoInfantil.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCartaoInfantil.Location = new System.Drawing.Point(463, 143);
            this.buttonCartaoInfantil.Name = "buttonCartaoInfantil";
            this.buttonCartaoInfantil.Size = new System.Drawing.Size(192, 35);
            this.buttonCartaoInfantil.TabIndex = 120;
            this.buttonCartaoInfantil.Text = "Atualizar cartão infantil";
            this.buttonCartaoInfantil.UseVisualStyleBackColor = false;
            this.buttonCartaoInfantil.Click += new System.EventHandler(this.buttonCartaoInfantil_Click);
            // 
            // labelNome
            // 
            this.labelNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(434, 53);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(207, 18);
            this.labelNome.TabIndex = 121;
            this.labelNome.Text = "Nome completo do dependente";
            this.labelNome.Visible = false;
            // 
            // panelNome
            // 
            this.panelNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelNome.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelNome.Location = new System.Drawing.Point(435, 109);
            this.panelNome.Name = "panelNome";
            this.panelNome.Size = new System.Drawing.Size(281, 1);
            this.panelNome.TabIndex = 122;
            this.panelNome.Visible = false;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNome.BackColor = System.Drawing.Color.White;
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNome.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(437, 89);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(279, 19);
            this.textBoxNome.TabIndex = 123;
            this.textBoxNome.Visible = false;
            // 
            // comboBoxNome
            // 
            this.comboBoxNome.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNome.FormattingEnabled = true;
            this.comboBoxNome.Items.AddRange(new object[] {
            "Antipólio",
            "DPT",
            "BCG",
            "Sarampo",
            "Tétano"});
            this.comboBoxNome.Location = new System.Drawing.Point(100, 80);
            this.comboBoxNome.Name = "comboBoxNome";
            this.comboBoxNome.Size = new System.Drawing.Size(283, 26);
            this.comboBoxNome.TabIndex = 124;
            this.comboBoxNome.Visible = false;
            this.comboBoxNome.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AtualizarCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 345);
            this.Controls.Add(this.comboBoxNome);
            this.Controls.Add(this.panelNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonCartaoInfantil);
            this.Controls.Add(this.buttonCartaoAdulto);
            this.Controls.Add(this.dateVacina);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.panelLote);
            this.Controls.Add(this.labelLote);
            this.Controls.Add(this.textBoxLote);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.radioButtonDose3);
            this.Controls.Add(this.radioButtonDose2);
            this.Controls.Add(this.radioButtonDose1);
            this.Controls.Add(this.labelNomeVacina);
            this.Controls.Add(this.labelDose);
            this.Controls.Add(this.panelCPF);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AtualizarCartao";
            this.Text = "AtualizarCartao";
            this.Load += new System.EventHandler(this.AtualizarCartao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelDose;
        private System.Windows.Forms.Panel panelCPF;
        private System.Windows.Forms.Label labelNomeVacina;
        private System.Windows.Forms.RadioButton radioButtonDose1;
        private System.Windows.Forms.RadioButton radioButtonDose2;
        private System.Windows.Forms.RadioButton radioButtonDose3;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Panel panelLote;
        private System.Windows.Forms.Label labelLote;
        private System.Windows.Forms.TextBox textBoxLote;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.MaskedTextBox textBoxCPF;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.DateTimePicker dateVacina;
        private System.Windows.Forms.Button buttonCartaoAdulto;
        private System.Windows.Forms.Button buttonCartaoInfantil;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Panel panelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.ComboBox comboBoxNome;
    }
}