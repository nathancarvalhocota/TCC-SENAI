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

namespace tcc_vacina.DTO
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonAmpliar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            buttonAmpliar.Visible = false;
            buttonReduzir.Visible = true;

            buttonCriar.Size = new Size(459, 38);
            buttonCriar.Location = new Point(-1, 0);

            buttonAtualizar.Size = new Size(459,38);
            buttonAtualizar.Location = new Point(459,0);

            buttonPesquisar.Size = new Size(459,38);
            buttonPesquisar.Location = new Point(919,0);
            
        }

        private void buttonReduzir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            buttonReduzir.Visible = false;
            buttonAmpliar.Visible = true;

            buttonCriar.Size = new Size(274, 38);
            buttonCriar.Location = new Point(1,0);

            buttonAtualizar.Size = new Size(274, 38);
            buttonAtualizar.Location = new Point(276, 0);

            buttonPesquisar.Size = new Size(274, 38);
            buttonPesquisar.Location = new Point(551, 0);
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        
        private void buttonCriar_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<CriarCartao>();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<AtualizarCartao>();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<PesquisarCartao>();
        }

        
    }



}
