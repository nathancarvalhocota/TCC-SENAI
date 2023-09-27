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
       
        private int userID;
        

        public Inicio()
        {
            InitializeComponent();
        }

        public Inicio (int id)
        {

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

            buttonCriar.Size = new Size(320, 38);
            buttonCriar.Location = new Point(-3, 0);

            buttonAtualizar.Size = new Size(320,38);
            buttonAtualizar.Location = new Point(318,0);

            buttonPesquisar.Size = new Size(320,38);
            buttonPesquisar.Location = new Point(639,0);

            buttonAtualizarDados.Size = new Size(320,38);
            buttonAtualizarDados.Location = new Point(960,0);
        }


        private void buttonReduzir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            buttonReduzir.Visible = false;
            buttonAmpliar.Visible = true;


            buttonCriar.Size = new Size(205, 38);
            buttonCriar.Location = new Point(0,0);

            buttonAtualizar.Size = new Size(205, 38);
            buttonAtualizar.Location = new Point(206, 0);

            buttonPesquisar.Size = new Size(205, 38);
            buttonPesquisar.Location = new Point(412, 0);

            buttonAtualizarDados.Size = new Size(205, 38);
            buttonAtualizarDados.Location = new Point(618, 0);

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
    }



}
