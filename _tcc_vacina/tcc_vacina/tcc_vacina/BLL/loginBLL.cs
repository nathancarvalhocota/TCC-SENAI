using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc_vacina.DAL;
using tcc_vacina.DTO;

namespace tcc_vacina.BLL
{
    class loginBLL
    {
      

        public int Login(variaveisDTO dto)
        {

            acessoBanco Acessar;
            try
            {

                Acessar = new acessoBanco();   
                Acessar.ConectarMySql();  

                int loginok;

                string MyQuery = $"select id_funcionario from tcc_vacina.funcionario where usuario_funcionario ='{dto.Usuario_funcionario}' and senha_funcionario ='{dto.Senha_funcionario}' ;";

                loginok = Acessar.Login(MyQuery);

                return loginok ;
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

      /*  public int validarpermit(variaveisDTO dto)
        {
            acessoBanco Acessar;
            try
            {
                Acessar = new acessoBanco();   
                Acessar.ConectarMySql();  

                int loginok;
                string MyQuery = $"select id_funcionario from tcc_vacina.funcionario where usuario_funcionario ='{dto.Usuario_funcionario}' and senha_funcionario ='{dto.Senha_funcionario}' ;";

                loginok = Acessar.Permit(MyQuery);  
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
        */
    }
}
