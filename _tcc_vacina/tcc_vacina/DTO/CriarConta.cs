using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcc_vacina.BLL;
using tcc_vacina.DTO;

namespace tcc_vacina
{
    public partial class CriarConta : Form
    {
        public CriarConta()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAmpliar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            buttonAmpliar.Visible = false;
            buttonReduzir.Visible = true;
        }

        private void buttonReduzir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            buttonReduzir.Visible = false;
            buttonAmpliar.Visible = true;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();      
        }

        private void buttonCriarConta_Click(object sender, EventArgs e)
        {
            variaveisDTO dto = new variaveisDTO();
            criarContaBLL bll = new criarContaBLL();

            if (textBoxNome.Text.Trim() == "")
            {
                MessageBox.Show("Nome inválido!", "Campo nome do usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNome.Focus();
                return;
            }
            if (textBoxTelefone.Text.Trim() == "")
            {
                MessageBox.Show("Telefone inválido!", "Campo telefone do usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTelefone.Focus();
                return;
            }
            if (textBoxHospital.Text.Trim() == "")
            {
                MessageBox.Show("Hospital inválido!", " Campo hospital do usuário ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxHospital.Focus();
                return;
            }

            if (textBoxEndereco.Text.Trim() == "")
            {
                MessageBox.Show("Endereço inválido!", " Campo endereço do usuário ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEndereco.Focus();
                return;
            }

            if (textBoxEmail.Text.Trim() == "-")
            {
                MessageBox.Show("Email inválido", "Campo email do usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                return;
            }

            if (textBoxUsuario.Text.Trim() == "")
            {

                MessageBox.Show("Nome de usuário invalido", "Campo login do usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUsuario.Focus();
                return;
            }

            if (textBoxSenha.Text.Trim() == "")
            {
                MessageBox.Show("Senha inválida", "Campo senha do usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSenha.Focus();
                return;
            }

            StringBuilder sb = new StringBuilder();
            foreach (char c in textBoxTelefone.Text)
            {
                if ((c >= '0' && c <= '9'))
                {
                    sb.Append(c);
                }
            }

            string tele = sb.ToString();
            bool checktel = textBoxTelefone.Text.Contains("-");
            bool checktel2 = textBoxTelefone.Text.Contains("(");
            bool checktel3 = textBoxTelefone.Text.Contains(")");

            bool check = false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(textBoxEmail.Text);
                check = true;
            }
            catch
            {
                check = false;
            }

            bool check2 = textBoxEmail.Text.Contains(".com");

            if (check == false || check2 == false)
            {
                MessageBox.Show("Email inválido");
            }

            else if (tele.Length < 11 || checktel == false || checktel2 == false || checktel3 == false)
            {
                MessageBox.Show("Número de telefone inserido incorretamente! Não se esqueça de inserir o DDD, os parênteses e o traço");
            }

            else if (textBoxSenha.Text != textBoxConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas são diferentes! Digite novamente");
            }


            else if (textBoxSenha.Text == textBoxConfirmarSenha.Text)
            {
                bool insertOK = false;

                dto.Nome_funcionario = textBoxNome.Text;
                dto.Telefone_funcionario = textBoxTelefone.Text;
                dto.Endereco_funcionario = textBoxEndereco.Text;
                dto.Email_funcionario = textBoxEmail.Text;
                dto.Hospital_funcionario = textBoxHospital.Text;
                dto.Usuario_funcionario = textBoxUsuario.Text;
                dto.Senha_funcionario = textBoxSenha.Text;

                insertOK = bll.Criar(dto);

                if (insertOK == false)
                {

                    MsgBox msgbox = new MsgBox();
                    msgbox.ShowDialog();
                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Erro ao criar conta");
                }
            }
        } 
    }
}
