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
    public partial class CriarCartaoInfantil : Form
    {
        public CriarCartaoInfantil()
        {
            InitializeComponent();

        }


        private void CriarCartaoInfantil_Load(object sender, EventArgs e)
        {
            dateNascimento.CustomFormat = "yyyy/MM/dd";
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void buttonOK_Click(object sender, EventArgs e)
        {

            variaveisDTO dto = new variaveisDTO();
            atualizarCartaoBLL bll = new atualizarCartaoBLL();

            dto.CPF_pessoa_cartao = textBoxCPF.Text;

            variaveisDTO.CPF_filho_pessoa = textBoxCPF.Text;

            bool loginok = false;

            loginok = bll.LoginCPF(dto);

            if (loginok == true)
            {
                labelDados.Visible = true;

                labelCPF.Visible = false;
                textBoxCPF.Visible = false;
                panelCPF.Visible = false;
                buttonOK.Visible = false;

                labelNome.Visible = true;
                textBoxNome.Visible = true;
                panelNome.Visible = true;

                labelDataNascimento.Visible = true;
                dateNascimento.Visible = true;

                labelSexo.Visible = true;
                radioButtonMasculino.Visible = true;
                radioButtonFeminino.Visible = true;

                buttonCriarCartao.Visible = true;
            }

            else
            {
                MessageBox.Show("CPF incorreto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

            string nome = textBoxNome.Text;

            dto.Nome_filho = nome;

            string cpf = variaveisDTO.CPF_filho_pessoa;

            string id = cpf + "(" + nome + ")";

            dto.Id_filho = id;

            string datanascimento = dateNascimento.Text;

            dto.Nascimento_filho = datanascimento.Replace("/", "-");

            if(radioButtonMasculino.Checked == true)
            {
                dto.Sexo_filho = "M";
            }

            if (radioButtonFeminino.Checked == true)
            {
                dto.Sexo_filho = "F";
            }

            bool insertOK = false;

            insertOK = bll.CriarInfantil(dto);

            if (insertOK == false)
            {

                MsgBox msgbox = new MsgBox();
                msgbox.ShowDialog();
                textBoxNome.Clear();
                radioButtonMasculino.Checked = false;
                radioButtonFeminino.Checked = false;
            }
            else
            {
                MessageBox.Show("Erro ao criar cartão");
            }
        }
    }
}

