using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc_vacina.DAL;
using tcc_vacina.DTO;

namespace tcc_vacina.BLL
{
    class criarCartaoBLL
    {

        public bool Criar(variaveisDTO dto)
        {

            acessoBanco Acessar;
            try
            {

                Acessar = new acessoBanco();
                Acessar.ConectarMySql();

                bool insertok;

                string MyQuery = $"insert into tcc_vacina.pessoa values ('{dto.CPF_pessoa}','{ dto.Sexo_pessoa}','{ dto.Nome_pessoa}','{ dto.Nascimento_pessoa}','{ dto.Email_pessoa}','{ dto.Endereco_pessoa}','{ dto.CEP_pessoa}','{ dto.Telefone_pessoa}','{dto.Senha_pessoa}'); insert into tcc_vacina.cartaovacina (id_cartaovacina , cpf_pessoa) values ({dto.Id_cartaovacina}, '{dto.CPF_pessoa}');";

                //  string MyQueryCartao = $"insert into tcc_vacina.cartaovacina (id_cartaovacina , cpf_pessoa) values ('default', '{dto.CPF_pessoa}'";

                insertok = Acessar.Conectar(MyQuery);

                return insertok;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao criar conta: " + ex.Message); 
            }

        }
    }
}
