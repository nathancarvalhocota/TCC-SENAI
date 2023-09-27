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
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.textBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.panelCPF = new System.Windows.Forms.Panel();
            this.labelNomeVacina = new System.Windows.Forms.Label();
            this.panelNomeVacina = new System.Windows.Forms.Panel();
            this.textBoxNomeVacina = new System.Windows.Forms.TextBox();
            this.radioButtonDose1 = new System.Windows.Forms.RadioButton();
            this.radioButtonDose2 = new System.Windows.Forms.RadioButton();
            this.radioButtonDose3 = new System.Windows.Forms.RadioButton();
            this.labelDose = new System.Windows.Forms.Label();
            this.textBoxLote = new System.Windows.Forms.TextBox();
            this.labelLote = new System.Windows.Forms.Label();
            this.panelLote = new System.Windows.Forms.Panel();
            this.dateTimeDataVacina = new System.Windows.Forms.DateTimePicker();
            this.labelDataVacina = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAtualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAtualizar.FlatAppearance.BorderSize = 0;
            this.buttonAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAtualizar.Location = new System.Drawing.Point(369, 284);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(93, 35);
            this.buttonAtualizar.TabIndex = 11;
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
            this.textBoxCPF.Location = new System.Drawing.Point(285, 146);
            this.textBoxCPF.Mask = "999,999,999-99";
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(302, 13);
            this.textBoxCPF.TabIndex = 102;
            this.textBoxCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textBoxCPF_MaskInputRejected);
            // 
            // labelCPF
            // 
            this.labelCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPF.Location = new System.Drawing.Point(281, 113);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(31, 18);
            this.labelCPF.TabIndex = 101;
            this.labelCPF.Text = "CPF";
            // 
            // panelCPF
            // 
            this.panelCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelCPF.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelCPF.Location = new System.Drawing.Point(285, 162);
            this.panelCPF.Name = "panelCPF";
            this.panelCPF.Size = new System.Drawing.Size(302, 1);
            this.panelCPF.TabIndex = 100;
            // 
            // labelNomeVacina
            // 
            this.labelNomeVacina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNomeVacina.AutoSize = true;
            this.labelNomeVacina.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeVacina.Location = new System.Drawing.Point(99, 60);
            this.labelNomeVacina.Name = "labelNomeVacina";
            this.labelNomeVacina.Size = new System.Drawing.Size(106, 18);
            this.labelNomeVacina.TabIndex = 105;
            this.labelNomeVacina.Text = "Nome da vacina";
            this.labelNomeVacina.Visible = false;
            // 
            // panelNomeVacina
            // 
            this.panelNomeVacina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelNomeVacina.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelNomeVacina.Location = new System.Drawing.Point(102, 109);
            this.panelNomeVacina.Name = "panelNomeVacina";
            this.panelNomeVacina.Size = new System.Drawing.Size(302, 1);
            this.panelNomeVacina.TabIndex = 104;
            this.panelNomeVacina.Visible = false;
            // 
            // textBoxNomeVacina
            // 
            this.textBoxNomeVacina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNomeVacina.BackColor = System.Drawing.Color.White;
            this.textBoxNomeVacina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomeVacina.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeVacina.Location = new System.Drawing.Point(103, 90);
            this.textBoxNomeVacina.Name = "textBoxNomeVacina";
            this.textBoxNomeVacina.Size = new System.Drawing.Size(302, 19);
            this.textBoxNomeVacina.TabIndex = 106;
            this.textBoxNomeVacina.Visible = false;
            // 
            // radioButtonDose1
            // 
            this.radioButtonDose1.AutoSize = true;
            this.radioButtonDose1.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.radioButtonDose1.Location = new System.Drawing.Point(456, 91);
            this.radioButtonDose1.Name = "radioButtonDose1";
            this.radioButtonDose1.Size = new System.Drawing.Size(72, 22);
            this.radioButtonDose1.TabIndex = 107;
            this.radioButtonDose1.TabStop = true;
            this.radioButtonDose1.Text = "1ª dose";
            this.radioButtonDose1.UseVisualStyleBackColor = true;
            this.radioButtonDose1.Visible = false;
            // 
            // radioButtonDose2
            // 
            this.radioButtonDose2.AutoSize = true;
            this.radioButtonDose2.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.radioButtonDose2.Location = new System.Drawing.Point(554, 91);
            this.radioButtonDose2.Name = "radioButtonDose2";
            this.radioButtonDose2.Size = new System.Drawing.Size(72, 22);
            this.radioButtonDose2.TabIndex = 108;
            this.radioButtonDose2.TabStop = true;
            this.radioButtonDose2.Text = "2ª dose";
            this.radioButtonDose2.UseVisualStyleBackColor = true;
            this.radioButtonDose2.Visible = false;
            // 
            // radioButtonDose3
            // 
            this.radioButtonDose3.AutoSize = true;
            this.radioButtonDose3.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.radioButtonDose3.Location = new System.Drawing.Point(647, 91);
            this.radioButtonDose3.Name = "radioButtonDose3";
            this.radioButtonDose3.Size = new System.Drawing.Size(72, 22);
            this.radioButtonDose3.TabIndex = 109;
            this.radioButtonDose3.TabStop = true;
            this.radioButtonDose3.Text = "3ª dose";
            this.radioButtonDose3.UseVisualStyleBackColor = true;
            this.radioButtonDose3.Visible = false;
            // 
            // labelDose
            // 
            this.labelDose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDose.AutoSize = true;
            this.labelDose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDose.Location = new System.Drawing.Point(453, 60);
            this.labelDose.Name = "labelDose";
            this.labelDose.Size = new System.Drawing.Size(39, 18);
            this.labelDose.TabIndex = 110;
            this.labelDose.Text = "Dose";
            this.labelDose.Visible = false;
            // 
            // textBoxLote
            // 
            this.textBoxLote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxLote.BackColor = System.Drawing.Color.White;
            this.textBoxLote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLote.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLote.Location = new System.Drawing.Point(103, 188);
            this.textBoxLote.Name = "textBoxLote";
            this.textBoxLote.Size = new System.Drawing.Size(302, 19);
            this.textBoxLote.TabIndex = 113;
            this.textBoxLote.Visible = false;
            // 
            // labelLote
            // 
            this.labelLote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLote.AutoSize = true;
            this.labelLote.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLote.Location = new System.Drawing.Point(99, 158);
            this.labelLote.Name = "labelLote";
            this.labelLote.Size = new System.Drawing.Size(35, 18);
            this.labelLote.TabIndex = 112;
            this.labelLote.Text = "Lote";
            this.labelLote.Visible = false;
            // 
            // panelLote
            // 
            this.panelLote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelLote.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelLote.Location = new System.Drawing.Point(102, 207);
            this.panelLote.Name = "panelLote";
            this.panelLote.Size = new System.Drawing.Size(302, 1);
            this.panelLote.TabIndex = 111;
            this.panelLote.Visible = false;
            // 
            // dateTimeDataVacina
            // 
            this.dateTimeDataVacina.CustomFormat = "yyyy/MM/dd";
            this.dateTimeDataVacina.Location = new System.Drawing.Point(456, 189);
            this.dateTimeDataVacina.Name = "dateTimeDataVacina";
            this.dateTimeDataVacina.Size = new System.Drawing.Size(302, 20);
            this.dateTimeDataVacina.TabIndex = 114;
            this.dateTimeDataVacina.Visible = false;
            // 
            // labelDataVacina
            // 
            this.labelDataVacina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDataVacina.AutoSize = true;
            this.labelDataVacina.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataVacina.Location = new System.Drawing.Point(453, 158);
            this.labelDataVacina.Name = "labelDataVacina";
            this.labelDataVacina.Size = new System.Drawing.Size(78, 18);
            this.labelDataVacina.TabIndex = 115;
            this.labelDataVacina.Text = "Data e hora";
            this.labelDataVacina.Visible = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonOK.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOK.Location = new System.Drawing.Point(369, 215);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(93, 35);
            this.buttonOK.TabIndex = 116;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // AtualizarCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 379);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelDataVacina);
            this.Controls.Add(this.dateTimeDataVacina);
            this.Controls.Add(this.textBoxLote);
            this.Controls.Add(this.labelLote);
            this.Controls.Add(this.panelLote);
            this.Controls.Add(this.labelDose);
            this.Controls.Add(this.radioButtonDose3);
            this.Controls.Add(this.radioButtonDose2);
            this.Controls.Add(this.radioButtonDose1);
            this.Controls.Add(this.textBoxNomeVacina);
            this.Controls.Add(this.labelNomeVacina);
            this.Controls.Add(this.panelNomeVacina);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.panelCPF);
            this.Controls.Add(this.buttonAtualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AtualizarCartao";
            this.Text = "AtualizarCartao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.MaskedTextBox textBoxCPF;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Panel panelCPF;
        private System.Windows.Forms.Label labelNomeVacina;
        private System.Windows.Forms.Panel panelNomeVacina;
        private System.Windows.Forms.TextBox textBoxNomeVacina;
        private System.Windows.Forms.RadioButton radioButtonDose1;
        private System.Windows.Forms.RadioButton radioButtonDose2;
        private System.Windows.Forms.RadioButton radioButtonDose3;
        private System.Windows.Forms.Label labelDose;
        private System.Windows.Forms.TextBox textBoxLote;
        private System.Windows.Forms.Label labelLote;
        private System.Windows.Forms.Panel panelLote;
        private System.Windows.Forms.DateTimePicker dateTimeDataVacina;
        private System.Windows.Forms.Label labelDataVacina;
        private System.Windows.Forms.Button buttonOK;
    }
}