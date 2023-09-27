using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc_vacina.DAL;
using tcc_vacina.DTO;

namespace tcc_vacina.BLL
{
    class criarContaBLL
    {

        public bool Criar(variaveisDTO dto)
        {

            acessoBanco Acessar;
            try
            {

                Acessar = new acessoBanco();  
                Acessar.ConectarMySql(); 

                bool insertok;

                // string MyQuery = $"insert into tcc_vacina.funcionario values ('default','{dto.Nome_funcionario}','{ dto.Telefone_funcionario}','{ dto.Endereco_funcionario}','{ dto.Email_funcionario}','{ dto.Hospital_funcionario}','{ dto.Usuario_funcionario}','{ dto.Senha_funcionario}',{dto.Permit_funcionario});";

                string MyQuery = $"insert into tcc_vacina.funcionario values ('default','{dto.Nome_funcionario}','{ dto.Telefone_funcionario}','{ dto.Endereco_funcionario}','{ dto.Email_funcionario}','{ dto.Hospital_funcionario}','{ dto.Usuario_funcionario}','{ dto.Senha_funcionario}');";

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
