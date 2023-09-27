using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcc_vacina.DTO;
using tcc_vacina.BLL;

namespace tcc_vacina.DTO
{
    public partial class CriarCartao : Form
    {
        public CriarCartao()
        {
            InitializeComponent();
        }

        private void CriarCartao_Load(object sender, EventArgs e)
        {
            dateNascimento.CustomFormat = "yyyy/MM/dd";
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.Dock = DockStyle.Fill;
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                    formulario.BringToFront();
            }
        }

        private void buttonCriarAdulto_Click(object sender, EventArgs e)
        {
            buttonCriarAdulto.Visible = false;
            buttonCriarInfantil.Visible = false;
            labelInstrucao.Visible = false;
            labelDados.Visible = true;

            buttonCriarCartao.Visible = true;

            labelCPF.Visible = true;
            textBoxCPF.Visible = true;
            panelCPF.Visible = true;

            labelNome.Visible = true;
            textBoxNome.Visible = true;
            panelNome.Visible = true;

            labelDataNascimento.Visible = true;
            dateNascimento.Visible = true;

            labelCEP.Visible = true;
            textBoxCEP.Visible = true;
            panelCEP.Visible = true;

            labelEndereco.Visible = true;
            textBoxEndereco.Visible = true;
            panelEndereco.Visible = true;

            labelEmail.Visible = true;
            textBoxEmail.Visible = true;
            panelEmail.Visible = true;

            labelTelefone.Visible = true;
            textBoxTelefone.Visible = true;
            panelTelefone.Visible = true;

            labelSexo.Visible = true;
            radioButtonMasculino.Visible = true;
            radioButtonFeminino.Visible = true;

            labelSenha.Visible = true;
            textBoxSenha.Visible = true;
            panelSenha.Visible = true;

            labelConfirmarSenha.Visible = true;
            textBoxConfirmarSenha.Visible = true;
            panelConfirmarSenha.Visible = true;
        }

        private void buttonCriarInfantil_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<CriarCartaoInfantil>();
        }

        private void buttonCriarCartao_Click(object sender, EventArgs e)
        {
            variaveisDTO dto = new variaveisDTO();
            criarCartaoBLL bll = new criarCartaoBLL();

            if (radioButtonMasculino.Checked == false && radioButtonFeminino.Checked == false)
            {
                MessageBox.Show("Selecione um sexo!", "Campo sexo do usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            if (textBoxCPF.Text.Trim() == "")
            {
                MessageBox.Show("CPF inválido!", " Campo CPF do usuário ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxCPF.Focus();
                return;
            }

            if (textBoxEmail.Text.Trim() == "-")
            {
                MessageBox.Show("Email inválido", "Campo email do usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                return;
            }

            if (textBoxCEP.Text.Trim() == "")
            {

                MessageBox.Show("CEP invalido", "Campo CEP do usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxCEP.Focus();
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

                if (radioButtonMasculino.Checked == true)
                {
                    dto.Sexo_pessoa = "M";
                }

                else if (radioButtonFeminino.Checked == true)
                {
                    dto.Sexo_pessoa = "F";
                }

                dto.CPF_pessoa = textBoxCPF.Text;
                dto.Nome_pessoa = textBoxNome.Text;
                string data = dateNascimento.Text;
                dto.Nascimento_pessoa = data.Replace("/", "-");
                dto.CEP_pessoa = textBoxCEP.Text;
                dto.Endereco_pessoa = textBoxEndereco.Text;
                dto.Email_pessoa = textBoxEmail.Text;
                dto.Telefone_pessoa = textBoxTelefone.Text;
                dto.Senha_pessoa = textBoxSenha.Text;

                insertOK = bll.CriarAdulto(dto);

                if (insertOK == false)
                {

                    MsgBox msgbox = new MsgBox();
                    msgbox.ShowDialog();
                    textBoxCPF.Clear();
                    textBoxNome.Clear();
                    textBoxCEP.Clear();
                    textBoxEndereco.Clear();
                    textBoxEmail.Clear();
                    radioButtonMasculino.Checked = false;
                    radioButtonFeminino.Checked = false;
                    textBoxTelefone.Clear();
                    textBoxSenha.Clear();
                    textBoxConfirmarSenha.Clear();
                }
                else
                {
                    MessageBox.Show("Erro ao criar cartão");
                }
            }
        }
    }
}
