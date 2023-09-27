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
        public bool CriarAdulto(variaveisDTO dto)
        { 
            acessoBanco Acessar;

            try
            {
                Acessar = new acessoBanco();

                Acessar.ConectarMySql();

                bool insertok;

                string MyQuery = $"insert into tcc_vacina.pessoa values ('{dto.CPF_pessoa}','{ dto.Sexo_pessoa}','{ dto.Nome_pessoa}','{ dto.Nascimento_pessoa}','{ dto.Email_pessoa}','{ dto.Endereco_pessoa}','{ dto.CEP_pessoa}','{ dto.Telefone_pessoa}','{dto.Senha_pessoa}');";

                insertok = Acessar.Conectar(MyQuery);

                return insertok;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao criar conta: " + ex.Message); 
            }
        }

        public bool CriarInfantil(variaveisDTO dto)
        {        
            acessoBanco Acessar;

            try
            {
                Acessar = new acessoBanco();

                Acessar.ConectarMySql();

                bool insertok;

                string MyQuery = $"insert into tcc_vacina.pessoa_filho values ('{dto.Id_filho}','{dto.Nome_filho}','{dto.Nascimento_filho}','{dto.Sexo_filho}','{variaveisDTO.CPF_filho_pessoa}');";

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
