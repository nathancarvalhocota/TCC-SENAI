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

namespace tcc_vacina.DTO
{

    public partial class PesquisarCartao : Form
    {
        int cartao;

        public PesquisarCartao()
        {
            InitializeComponent();
        }

        private void PesquisarCartao_Load(object sender, EventArgs e)
        {

        }

        public void CarregaGridPesquisaAdulto()
        {
         pesquisarCartaoBLL bll = new pesquisarCartaoBLL();
         variaveisDTO dto = new variaveisDTO();

         dataGridViewCartao.DataSource = bll.PesquisarAdulto(dto);

         dataGridViewCartao.Columns[0].HeaderCell.Value = "Vacina";
         dataGridViewCartao.Columns[1].HeaderCell.Value = "Dose";
         dataGridViewCartao.Columns[2].HeaderCell.Value = "Lote";
         dataGridViewCartao.Columns[3].HeaderCell.Value = "Data da vacinação";
         dataGridViewCartao.Columns[4].HeaderCell.Value = "Aplicador";
        }

        public void CarregaGridPesquisaInfantil()
        {
            pesquisarCartaoBLL bll = new pesquisarCartaoBLL();
            variaveisDTO dto = new variaveisDTO();

            dataGridViewCartao.DataSource = bll.PesquisarInfantil(dto);

            dataGridViewCartao.Columns[0].HeaderCell.Value = "Vacina";
            dataGridViewCartao.Columns[1].HeaderCell.Value = "Dose";
            dataGridViewCartao.Columns[2].HeaderCell.Value = "Lote";
            dataGridViewCartao.Columns[3].HeaderCell.Value = "Data da vacinação";
            dataGridViewCartao.Columns[4].HeaderCell.Value = "Aplicador";
        }

        private void buttonPesquisarAdulto_Click(object sender, EventArgs e)
        {
            cartao = 0;
            dataGridViewCartao.Visible = true;
            labelCPF.Visible = true;
            textBoxCPF.Visible = true;
            panelCPF.Visible = true;
            labelCPF.Location = new Point(259, 42);
            textBoxCPF.Location = new Point(260, 76);
            panelCPF.Location = new Point(262, 90);
            buttonPesquisar.Visible = true;
            buttonPesquisarAdulto.Visible = false;
            buttonPesquisarInfantil.Visible = false;
        }

        private void buttonPesquisarInfantil_Click(object sender, EventArgs e)
        {
            cartao = 1;
            dataGridViewCartao.Visible = true;
            labelCPF.Text = "CPF do responsável";
            labelCPF.Visible = true;
            textBoxCPF.Visible = true;
            panelCPF.Visible = true;
            labelNome.Visible = true;
            textBoxNome.Visible = true;
            panelNome.Visible = true;
            buttonPesquisar.Visible = true;
            buttonPesquisarAdulto.Visible = false;
            buttonPesquisarInfantil.Visible = false;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            variaveisDTO dto = new variaveisDTO();
            pesquisarCartaoBLL bll = new pesquisarCartaoBLL();

            string cpf = textBoxCPF.Text;

                if (cartao == 0)
                {
                 variaveisDTO.Pesquisa_cpf = cpf;

                 bll.PesquisarAdulto(dto);
                 CarregaGridPesquisaAdulto();

                 textBoxCPF.Clear(); 
                }

                else if (cartao == 1)
                {
                 string nome = textBoxNome.Text;
                 variaveisDTO.Pesquisa_cpf = cpf + "(" + nome + ")"; 

                 bll.PesquisarInfantil(dto);
                 CarregaGridPesquisaInfantil();

                 textBoxCPF.Clear();
                 textBoxNome.Clear();
                }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
