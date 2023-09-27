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

namespace tcc_vacina
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CriarConta cria = new CriarConta();
            cria.Show();
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            variaveisDTO dto = new variaveisDTO();
            loginBLL bll = new loginBLL();


            if (textBoxUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Insira um nome de usuário", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUsuario.Focus();
                return;
            }

            if (textBoxSenha.Text.Trim() == "")
            {
                MessageBox.Show("Insira uma senha", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSenha.Focus();
                return;
            }
            int loginok = 0;
       //   int permit = 0;

            dto.Usuario_funcionario = textBoxUsuario.Text;
            dto.Senha_funcionario = textBoxSenha.Text;
            loginok = bll.Login(dto);


            if (loginok != 0)
            {
           //   permit = bll.validarpermit(dto);

                this.Hide();
                Inicio inicio = new Inicio();
                inicio.ShowDialog();
            }

            else
            {
                
                MessageBox.Show("Usuário ou senha incorreto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
