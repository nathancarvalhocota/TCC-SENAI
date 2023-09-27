using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc_vacina.DAL;
using tcc_vacina.DTO;

namespace tcc_vacina.BLL
{
    class atualizarCartaoBLL
    {

        public bool LoginInfantil(variaveisDTO dto)
        {
            acessoBanco Acessar;

            try
            {
                Acessar = new acessoBanco();

                Acessar.ConectarMySql();

                bool insertok;

                string MyQuery = $"select * from tcc_vacina.pessoa_filho where id_filho = '{dto.Id_filho}';";

                insertok = Acessar.Conectar(MyQuery);

                return insertok;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao criar conta: " + ex.Message);
            }
        }

        public bool LoginCPF(variaveisDTO dto)
        {
            acessoBanco Acessar;

            try
            {

                Acessar = new acessoBanco();

                Acessar.ConectarMySql();

                bool insertok;

                string MyQuery = $"select * from tcc_vacina.pessoa where cpf_pessoa = '{dto.CPF_pessoa_cartao}';";

                insertok = Acessar.Conectar(MyQuery);

                return insertok;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao encontrar conta: " + ex.Message);
            }
        }

        public long AtualizarAdulto(variaveisDTO dto)
        {
            acessoBanco Acessar;

            try
            {          
                Acessar = new acessoBanco();

                Acessar.ConectarMySql();

                long loginok;

                string MyQuery = $"insert into tcc_vacina.cartaovacina values ('default','{dto.CPF_pessoa_cartao}','{dto.Nome_vacina}','{dto.Dose_vacina}','{dto.Datavacina}','{dto.Lote_vacina}', '{variaveisDTO.Id_funcionario_cartao}');";

                loginok = Acessar.Login(MyQuery);

                return loginok;               
            }

            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }

            finally
            {
                Acessar = null;
            }
        }

        public long AtualizarInfantil(variaveisDTO dto)
        {
            acessoBanco Acessar;

            try
            {
                Acessar = new acessoBanco();

                Acessar.ConectarMySql();

                long loginok;

                string MyQuery = $"insert into tcc_vacina.cartaovacina_infantil values ('default','{dto.Id_filho}','{dto.CPF_pessoa}','{dto.Nome_vacina}','{dto.Dose_vacina}','{dto.Lote_vacina}','{dto.Datavacina}', '{variaveisDTO.Id_funcionario_cartao}');";

                loginok = Acessar.Login(MyQuery);

                return loginok;
            }

            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }

            finally
            {
                Acessar = null;
            }
        }
    }
}

      
    

