using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcc_vacina.DTO
{
    class variaveisDTO
    {

        /////////////////////////////// F U N C I O N Á R I O ////////////////////////

        private int id_funcionario;
        private string nome_funcionario;
        private string telefone_funcionario;
        private string endereco_funcionario;
        private string email_funcionario;
        private string hospital_funcionario;
        private string usuario_funcionario;
        private string senha_funcionario;
   //   private int permit_funcionario;


        public int Id_funcionario
        {
            get
            {
                return id_funcionario;
            }

            set
            {
                id_funcionario = value;
            }
        }

        public string Nome_funcionario
        {
            get
            {
                return nome_funcionario;
            }

            set
            {
                nome_funcionario = value;
            }
        }

        public string Telefone_funcionario
        {
            get
            {
                return telefone_funcionario;
            }

            set
            {
                telefone_funcionario = value;
            }
        }

        public string Endereco_funcionario
        {
            get
            {
                return endereco_funcionario;
            }

            set
            {
                endereco_funcionario = value;
            }
        }

        public string Email_funcionario
        {
            get
            {
                return email_funcionario;
            }

            set
            {
                email_funcionario = value;
            }
        }

        public string Hospital_funcionario
        {
            get
            {
                return hospital_funcionario;
            }

            set
            {
                hospital_funcionario = value;
            }
        }

        public string Usuario_funcionario
        {
            get
            {
                return usuario_funcionario;
            }

            set
            {
                usuario_funcionario = value;
            }
        }

        public string Senha_funcionario
        {
            get
            {
                return senha_funcionario;
            }

            set
            {
                senha_funcionario = value;
            }
        }

   /*     public int Permit_funcionario
        {
            get
            {
                return permit_funcionario;
            }

            set
            {
                permit_funcionario = value;
            }
        } 
    */
    

        //////////////////////////  P E S S O A  /////////////////////////

        private string cpf_pessoa;
        private string nome_pessoa;
        private string nascimento_pessoa;
        private string email_pessoa;
        private string endereco_pessoa;
        private string cep_pessoa;
        private string telefone_pessoa;
        private string senha_pessoa;
        private string sexo_pessoa;


        public string CPF_pessoa
        {
            get
            {
                return cpf_pessoa;
            }

            set
            {
                cpf_pessoa = value;
            }
        }

        public string Nome_pessoa
        {
            get
            {
                return nome_pessoa;
            }

            set
            {
                nome_pessoa = value;
            }
        }

        public string Nascimento_pessoa
        {
            get
            {
                return nascimento_pessoa;
            }

            set
            {
                nascimento_pessoa = value;
            }
        }

        public string Email_pessoa
        {
            get
            {
                return email_pessoa;
            }

            set
            {
                email_pessoa = value;
            }
        }

        public string Endereco_pessoa
        {
            get
            {
                return endereco_pessoa;
            }

            set
            {
                endereco_pessoa = value;
            }
        }

        public string Telefone_pessoa
        {
            get
            {
                return telefone_pessoa;
            }

            set
            {
                telefone_pessoa = value;
            }
        }

        public string Senha_pessoa
        {
            get
            {
                return senha_pessoa;
            }

            set
            {
                senha_pessoa = value;
            }
        }

        public string CEP_pessoa
        {
            get
            {
                return cep_pessoa;
            }

            set
            {
                cep_pessoa = value;
            }
        }

        public string Sexo_pessoa
        {
            get
            {
                return sexo_pessoa;
            }

            set
            {
                sexo_pessoa = value;
            }
        }
        /////////////////////////////////////  V A C I N A  //////////////////////////

        private int id_vacina;
        private string nome_vacina;


        public int Id_vacina
        {
            get
            {
                return id_vacina;
            }

            set
            {
                id_vacina = value;
            }
        }

        public string Nome_vacina
        {
            get
            {
                return nome_vacina;
            }

            set
            {
                nome_vacina = value;
            }
        }


        ////////////////////////////////  C A R T A O  V A C I N A  ///////////////////

        private string id_cartaovacina;
        private int id_vacina_cartao;
        private string cpf_pessoa_cartao;
        private string tomou_vacina;
        private DateTime datavacina;
        private int id_funcionario_cartao;

       
        public string Id_cartaovacina
        {
            get
            {
                return id_cartaovacina;
            }

            set
            {
                id_cartaovacina = value;
            }
        }

        public int Id_vacina_cartao
        {
            get
            {
                return id_vacina_cartao;
            }

            set
            {
                id_vacina_cartao = value;
            }
        }

        public string Cpf_pessoa_cartao
        {
            get
            {
                return cpf_pessoa_cartao;
            }

            set
            {
                cpf_pessoa_cartao = value;
            }
        }

        public string Tomou_vacina
        {
            get
            {
                return tomou_vacina;
            }

            set
            {
                tomou_vacina = value;
            }
        }

        public DateTime Datavacina
        {
            get
            {
                return datavacina;
            }

            set
            {
                datavacina = value;
            }
        }

        public int Id_funcionario_cartao
        {
            get
            {
                return id_funcionario_cartao;
            }

            set
            {
                id_funcionario_cartao = value;
            }
        }
    }
}
