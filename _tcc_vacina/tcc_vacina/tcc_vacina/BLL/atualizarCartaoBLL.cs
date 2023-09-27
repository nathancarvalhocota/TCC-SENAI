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


        public int Login(variaveisDTO dto)
        {

            acessoBanco Acessar;
            try
            {

                Acessar = new acessoBanco();
                Acessar.ConectarMySql();

                int loginok;
                
                    string MyQuery = $"select id_cartaovacina from tcc_vacina.cartaovacina where cpf_pessoa = + '{dto.CPF_pessoa}';";

                loginok = Acessar.Login(MyQuery);

                return loginok;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao fazer login: " + ex.Message);
            }
            finally
            {
                Acessar = null;
            }


        }

      
    }
}
