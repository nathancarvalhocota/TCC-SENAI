using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc_vacina.DAL;
using tcc_vacina.DTO;
using System.Data;

namespace tcc_vacina.BLL
{
    class pesquisarCartaoBLL
    {

      public DataTable PesquisarAdulto(variaveisDTO dto)
        {
            DataTable cartao = new DataTable();

            acessoBanco Acessar = new acessoBanco();

            Acessar.ConectarMySql();

            string MyQuery = $"select nome_vacina , dose_vacina , lote_vacina , data_vacina, funcionario.nome_funcionario FROM cartaovacina INNER JOIN funcionario on cartaovacina.id_funcionario = funcionario.id_funcionario where cpf_pessoa = '{variaveisDTO.Pesquisa_cpf}';";

            cartao = Acessar.RetTabelaDados(MyQuery);

            return cartao;
        }

        public DataTable PesquisarInfantil(variaveisDTO dto)
        {
            DataTable cartao = new DataTable();

            acessoBanco Acessar = new acessoBanco();

            Acessar.ConectarMySql();

            string MyQuery = $"select nome_vacina , dose_vacina , lote_vacina , data_vacina , funcionario.nome_funcionario FROM cartaovacina_infantil INNER JOIN funcionario on cartaovacina_infantil.id_funcionario = funcionario.id_funcionario where id_filho = '{variaveisDTO.Pesquisa_cpf}';";

            cartao = Acessar.RetTabelaDados(MyQuery);

            return cartao;
        }
    }
}
