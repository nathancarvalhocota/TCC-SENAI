using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcc_vacina.DAL;
using tcc_vacina.BLL;
using tcc_vacina.DTO;

namespace tcc_vacina.DTO
{
    public partial class AtualizarCartao : Form
    {
        int cartao;
        public AtualizarCartao()
        {
            InitializeComponent();
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
        }

        private void AtualizarCartao_Load(object sender, EventArgs e)
        {
            dateVacina.CustomFormat = "yyyy/MM/dd";
        }

        private void buttonCartaoInfantil_Click(object sender, EventArgs e)
        {
            cartao = 1;

            labelCPF.Text = "CPF do responsável";
            labelCPF.Visible = true;
            textBoxCPF.Visible = true;
            panelCPF.Visible = true;
            buttonOK.Visible = true;
            labelNome.Visible = true;
            textBoxNome.Visible = true;
            panelNome.Visible = true;
            buttonCartaoAdulto.Visible = false;
            buttonCartaoInfantil.Visible = false;

            labelCPF.Location = new Point(97, 53);
            textBoxCPF.Location = new Point(102, 95);
            panelCPF.Location = new Point(100, 109);
        }

        private void buttonCartaoAdulto_Click(object sender, EventArgs e)
        {
            cartao = 0;

            labelCPF.Visible = true;
            textBoxCPF.Visible = true;
            panelCPF.Visible = true;
            buttonOK.Visible = true;
            buttonCartaoAdulto.Visible = false;
            buttonCartaoInfantil.Visible = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            variaveisDTO dto = new variaveisDTO();
            atualizarCartaoBLL bll = new atualizarCartaoBLL();

            bool loginok = false;

            if (cartao == 1)
            {
                string cpf = textBoxCPF.Text;
                string nome = textBoxNome.Text;
                string cpfnome = cpf + "(" + nome + ")";
                dto.Id_filho = cpfnome;
                loginok = bll.LoginInfantil(dto);
            }

            if (cartao == 0)
            {
                dto.CPF_pessoa_cartao = textBoxCPF.Text;
                loginok = bll.LoginCPF(dto);
            }
         
            if (loginok == true)
            {
                labelCPF.Visible = false;
                textBoxCPF.Visible = false;
                panelCPF.Visible = false;
                buttonOK.Visible = false;


                labelNome.Visible = false;
                textBoxNome.Visible = false;
                panelNome.Visible = false;

                labelNomeVacina.Visible = true;
                comboBoxNome.Visible = true;              

                labelDose.Visible = true;
                radioButtonDose1.Visible = true;
                radioButtonDose2.Visible = true;
                radioButtonDose3.Visible = true;

                labelLote.Visible = true;
                textBoxLote.Visible = true;
                panelLote.Visible = true;

                labelData.Visible = true;
                dateVacina.Visible = true;

                buttonAtualizar.Visible = true;
            }

            else
            {
                MessageBox.Show("Dados incorretos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            variaveisDTO dto = new variaveisDTO();
            atualizarCartaoBLL bll = new atualizarCartaoBLL();

            long insertok = 0;

            int dose = 0;

            if (radioButtonDose1.Checked == true)
            {
                dose = 1;
            }

            else if (radioButtonDose2.Checked == true)
            {
                dose = 2;
            }

            else if (radioButtonDose3.Checked == true)
            {
                dose = 3;
            }

            dto.Nome_vacina = comboBoxNome.SelectedItem.ToString();

            dto.Dose_vacina = dose;

            dto.Lote_vacina = textBoxLote.Text;

            string data = dateVacina.Text;
            dto.Datavacina = data.Replace("/", "-");
           
            if (cartao == 1)
            {
                string cpf = textBoxCPF.Text;
                string nome = textBoxNome.Text;
                string cpfnome = cpf + "(" + nome + ")";
                dto.Id_filho = cpfnome;
                dto.CPF_pessoa = textBoxCPF.Text;
                insertok = bll.AtualizarInfantil(dto);
            }

            else if (cartao == 0)
            {
                dto.CPF_pessoa_cartao = textBoxCPF.Text;
                insertok = bll.AtualizarAdulto(dto);
            }

            if (insertok == 0)
            {
                MsgBox msgbox = new MsgBox();
                msgbox.ShowDialog();
            }

            else
            {
                MessageBox.Show("Erro ao inserir nova vacina", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
