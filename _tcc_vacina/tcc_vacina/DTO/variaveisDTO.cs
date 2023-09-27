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
        
        private string nome_funcionario;
        private string telefone_funcionario;
        private string endereco_funcionario;
        private string email_funcionario;
        private string hospital_funcionario;
        private string usuario_funcionario;
        private string senha_funcionario;


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


        /////////////////////////////////  P E S S O A  F I L H O    ////////////////////////////////////

        private string id_filho;
        private string nome_filho;
        private string nascimento_filho;
        private string sexo_filho;
        private static string cpf_filho_pessoa;

        public string Id_filho
        {
            get
            {
                return id_filho;
            }

            set
            {
                id_filho = value;
            }
        }


        public string Nome_filho
        {
            get
            {
                return nome_filho;
            }

            set
            {
                nome_filho = value;
            }
        }


        public string Nascimento_filho
        {
            get
            {
                return nascimento_filho;
            }

            set
            {
                nascimento_filho = value;
            }
        }

        public string Sexo_filho
        {
            get
            {
                return sexo_filho;
            }

            set
            {
                sexo_filho = value;
            }
        }

        public static string CPF_filho_pessoa
        {
            get
            {
                return cpf_filho_pessoa;
            }

            set
            {
                cpf_filho_pessoa = value;
            }
        }

        ////////////////////////////////  C A R T A O  V A C I N A  ////////////////////////////////////


        private string cpf_pessoa_cartao;
        private string nome_vacina;
        private int dose_vacina;
        private string lote_vacina;
        private string datavacina;
        private static int id_funcionario_cartao;
        private static string pesquisa_cpf;

    
        public string CPF_pessoa_cartao
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


        public int Dose_vacina
        {
            get
            {
                return dose_vacina;
            }

            set
            {
                dose_vacina = value;
            }
        }

   

        public string Lote_vacina
        {
            get
            {
                return lote_vacina;
            }

            set
            {
                lote_vacina = value;
            }
        }


        public string Datavacina
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

        public static int Id_funcionario_cartao
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


        public static string Pesquisa_cpf
        {
            get
            {
                return pesquisa_cpf;
            }

            set
            {
                pesquisa_cpf = value;
            }
        }


    }
}
