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
using tcc_vacina.DAL;

namespace tcc_vacina.DTO
{
    public partial class AtualizarCartao : Form
    {
        public AtualizarCartao()
        {
            InitializeComponent();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            variaveisDTO dto = new variaveisDTO();
            atualizarCartaoBLL bll = new atualizarCartaoBLL();

            int loginok = 0;

            //dto.CPF_pessoa = Convert.ToString(textBoxCPF);

            dto.CPF_pessoa = textBoxCPF.Text;
            
            loginok = bll.Login(dto);


            if (loginok != 0)
            {
                
                labelCPF.Visible = false;
                textBoxCPF.Visible = false;
                panelCPF.Visible = false;
                buttonOK.Visible = false;

                labelNomeVacina.Visible = true;
                textBoxNomeVacina.Visible = true;
                panelNomeVacina.Visible = true;
                labelDose.Visible = true;
                radioButtonDose1.Visible = true;
                radioButtonDose2.Visible = true;
                radioButtonDose3.Visible = true;
                labelLote.Visible = true;
                textBoxLote.Visible = true;
                panelLote.Visible = true;
                labelDataVacina.Visible = true;
                dateTimeDataVacina.Visible = true;


            }

            else
            {

                MessageBox.Show("CPF incorreto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
