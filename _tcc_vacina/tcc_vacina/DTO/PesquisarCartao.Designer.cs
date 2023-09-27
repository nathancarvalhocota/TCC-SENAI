namespace tcc_vacina.DTO
{
    partial class PesquisarCartao
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
            this.textBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.panelCPF = new System.Windows.Forms.Panel();
            this.buttonPesquisarAdulto = new System.Windows.Forms.Button();
            this.dataGridViewCartao = new System.Windows.Forms.DataGridView();
            this.buttonPesquisarInfantil = new System.Windows.Forms.Button();
            this.panelNome = new System.Windows.Forms.Panel();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartao)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCPF.BackColor = System.Drawing.Color.White;
            this.textBoxCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCPF.Location = new System.Drawing.Point(109, 76);
            this.textBoxCPF.Mask = "999,999,999-99";
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(302, 13);
            this.textBoxCPF.TabIndex = 122;
            this.textBoxCPF.Visible = false;
            // 
            // labelCPF
            // 
            this.labelCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPF.Location = new System.Drawing.Point(108, 42);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(31, 18);
            this.labelCPF.TabIndex = 121;
            this.labelCPF.Text = "CPF";
            this.labelCPF.Visible = false;
            // 
            // panelCPF
            // 
            this.panelCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelCPF.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelCPF.Location = new System.Drawing.Point(111, 90);
            this.panelCPF.Name = "panelCPF";
            this.panelCPF.Size = new System.Drawing.Size(281, 1);
            this.panelCPF.TabIndex = 118;
            this.panelCPF.Visible = false;
            // 
            // buttonPesquisarAdulto
            // 
            this.buttonPesquisarAdulto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPesquisarAdulto.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPesquisarAdulto.FlatAppearance.BorderSize = 0;
            this.buttonPesquisarAdulto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisarAdulto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisarAdulto.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPesquisarAdulto.Location = new System.Drawing.Point(170, 56);
            this.buttonPesquisarAdulto.Name = "buttonPesquisarAdulto";
            this.buttonPesquisarAdulto.Size = new System.Drawing.Size(184, 35);
            this.buttonPesquisarAdulto.TabIndex = 117;
            this.buttonPesquisarAdulto.Text = "Pesquisar cartão adulto";
            this.buttonPesquisarAdulto.UseVisualStyleBackColor = false;
            this.buttonPesquisarAdulto.Click += new System.EventHandler(this.buttonPesquisarAdulto_Click);
            // 
            // dataGridViewCartao
            // 
            this.dataGridViewCartao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCartao.Location = new System.Drawing.Point(132, 211);
            this.dataGridViewCartao.Name = "dataGridViewCartao";
            this.dataGridViewCartao.Size = new System.Drawing.Size(579, 189);
            this.dataGridViewCartao.TabIndex = 123;
            this.dataGridViewCartao.Visible = false;
            // 
            // buttonPesquisarInfantil
            // 
            this.buttonPesquisarInfantil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPesquisarInfantil.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPesquisarInfantil.FlatAppearance.BorderSize = 0;
            this.buttonPesquisarInfantil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisarInfantil.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisarInfantil.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPesquisarInfantil.Location = new System.Drawing.Point(464, 56);
            this.buttonPesquisarInfantil.Name = "buttonPesquisarInfantil";
            this.buttonPesquisarInfantil.Size = new System.Drawing.Size(184, 35);
            this.buttonPesquisarInfantil.TabIndex = 124;
            this.buttonPesquisarInfantil.Text = "Pesquisar cartão infantil";
            this.buttonPesquisarInfantil.UseVisualStyleBackColor = false;
            this.buttonPesquisarInfantil.Click += new System.EventHandler(this.buttonPesquisarInfantil_Click);
            // 
            // panelNome
            // 
            this.panelNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelNome.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelNome.Location = new System.Drawing.Point(442, 90);
            this.panelNome.Name = "panelNome";
            this.panelNome.Size = new System.Drawing.Size(281, 1);
            this.panelNome.TabIndex = 127;
            this.panelNome.Visible = false;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNome.BackColor = System.Drawing.Color.White;
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNome.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(444, 70);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(279, 19);
            this.textBoxNome.TabIndex = 128;
            this.textBoxNome.Visible = false;
            // 
            // labelNome
            // 
            this.labelNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(441, 42);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(207, 18);
            this.labelNome.TabIndex = 126;
            this.labelNome.Text = "Nome completo do dependente";
            this.labelNome.Visible = false;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPesquisar.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPesquisar.FlatAppearance.BorderSize = 0;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPesquisar.Location = new System.Drawing.Point(355, 149);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(140, 35);
            this.buttonPesquisar.TabIndex = 129;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Visible = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
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
            this.buttonFechar.TabIndex = 146;
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // PesquisarCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 760);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.panelNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonPesquisarInfantil);
            this.Controls.Add(this.dataGridViewCartao);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.panelCPF);
            this.Controls.Add(this.buttonPesquisarAdulto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PesquisarCartao";
            this.Text = "PesquisarCartao";
            this.Load += new System.EventHandler(this.PesquisarCartao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox textBoxCPF;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Panel panelCPF;
        private System.Windows.Forms.Button buttonPesquisarAdulto;
        private System.Windows.Forms.DataGridView dataGridViewCartao;
        private System.Windows.Forms.Button buttonPesquisarInfantil;
        private System.Windows.Forms.Panel panelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonFechar;
    }
}