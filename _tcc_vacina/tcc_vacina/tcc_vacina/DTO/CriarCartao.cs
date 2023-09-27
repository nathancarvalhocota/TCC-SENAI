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
             // dateTimeNascimento.Format = DateTimePickerFormat.Custom;
              dateNascimento.CustomFormat = "yyyy/MM/dd";
             // dateTimeNascimento.Value = DateTime.Now.Date;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCriarCartao_Click(object sender, EventArgs e)
        {
            variaveisDTO dto = new variaveisDTO();
            criarCartaoBLL bll = new criarCartaoBLL();

            if (radioButtonMasculino.Checked == false && radioButtonFeminino.Checked == false)
            {
                MessageBox.Show("Selecione um sexo!", "Campo sexo do usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNome.Focus();
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


                // if (textBoxCodigo.Visible == false)
                //{
                //dto.Permit_funcionario = 0;
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

                string cpf = dto.CPF_pessoa;

                string _cpf = cpf.Replace(".", "").Replace("-","");
                Array reverse = _cpf.ToArray();
                Array.Reverse(reverse);

                _cpf = string.Empty;

                foreach (char num in reverse)
                {
                    _cpf += num.ToString();
                }

                dto.Id_cartaovacina = _cpf;

                insertOK = bll.Criar(dto);

                if (insertOK == false)
                {

                    MsgBox msgbox = new MsgBox();
                    msgbox.ShowDialog();
                    textBoxCPF.Clear();
                    textBoxNome.Clear();
                    textBoxCEP.Clear();
                    textBoxEndereco.Clear();
                    textBoxEmail.Clear();
                    textBoxTelefone.Clear();
                    textBoxSenha.Clear();
                    textBoxConfirmarSenha.Clear();
                }
                else
                {
                    MessageBox.Show("Erro ao criar conta");
                }

            }
        }
    }
}
