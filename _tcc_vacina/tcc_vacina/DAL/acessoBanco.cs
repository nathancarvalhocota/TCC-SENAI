
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace tcc_vacina.DAL
{
    class acessoBanco
    {
        private MySqlConnection MyConect;
        private MySqlDataReader MyReader;
        private MySqlDataAdapter MyAdapter;
        private MySqlCommandBuilder MyComandBuilder;
        private DataTable MyTabela;

        private string SERVER = "localhost";
        private string PORT = "3306";
        private string DATABASE = "tcc_vacina";
        private string UID = "root";
        private string PASSWORD = "";

        public string id;
        public string cep;
        public string endereco;
        public string email;
        public string telefone;
        public string senha;

        public void ConectarMySql()
        {
            if (MyConect != null)
                MyConect.Close();

            string MyBanco = String.Format("SERVER={0}; PORT={1}; DATABASE={2}; UID={3}; PASSWORD={4};", SERVER, PORT, DATABASE, UID, PASSWORD);

            try
            {
                MyConect = new MySqlConnection(MyBanco);
                MyConect.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExecutaSql(String MyQuery)
        {
            try
            {
                MySqlCommand MyCommand = new MySqlCommand(MyQuery, MyConect);
                MyCommand.ExecuteNonQuery();
                MyConect.Close();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable RetTabelaDados(String Sql)
        {
            try
            {
                MyTabela = new DataTable();
                MyAdapter = new MySqlDataAdapter(Sql, MyConect);
                MyComandBuilder = new MySqlCommandBuilder(MyAdapter);
                MyAdapter.Fill(MyTabela);

                return MyTabela;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public MySqlDataReader RetDataReader(String Sql)
        {
            try
            {
                MySqlCommand MyComand = new MySqlCommand(Sql, MyConect);
                MySqlDataReader MyReader = MyComand.ExecuteReader();
                return MyReader;

            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Login(String MyQuery)
        {
            int teste = 0;
            int retornoMysql;

            try
            {
                MySqlCommand MyCommand = new MySqlCommand(MyQuery, MyConect);
                MyReader = MyCommand.ExecuteReader();
                retornoMysql = 0;

                while (MyReader.Read())
                {
                    retornoMysql = retornoMysql + 1;
                }

                if (retornoMysql > 0)
                {
                    teste = MyReader.GetInt32(0);
                }

                else
                {
                    teste = 0;
                }

                MyReader.Close();
                MyConect.Close();
                return teste;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public long Login64(String MyQuery)
        {
            long teste = 0;
            long retornoMysql;

            try
            {
                MySqlCommand MyCommand = new MySqlCommand(MyQuery, MyConect);
                MyReader = MyCommand.ExecuteReader();
                retornoMysql = 0;

                while (MyReader.Read())
                {
                    retornoMysql = retornoMysql + 1;
                }

                if (retornoMysql > 0)
                {
                    teste = MyReader.GetInt64(0);
                }

                else
                {
                    teste = 0;
                }

                MyConect.Close();

                return teste;
            }

            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Conectar(String MyQuery)
        {
            bool teste = false;
            int retornoMysql;

            try
            {
                MySqlCommand MyCommand = new MySqlCommand(MyQuery, MyConect);
                MyReader = MyCommand.ExecuteReader();
                retornoMysql = 0;

                while (MyReader.Read())
                {
                    retornoMysql = retornoMysql + 1;
                }

                MyConect.Close();
                if (retornoMysql > 0)
                {
                    teste = true;
                }

                else
                {
                    teste = false;
                }

                return teste;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string LerID(String MyQuery)
        {
            try
            {
                MySqlCommand MyCommand = new MySqlCommand(MyQuery, MyConect);
                MyReader = MyCommand.ExecuteReader();

                while (MyReader.Read())
                {
                    id = (MyReader["id_funcionario"].ToString());
                }

                MyReader.Close();
                MyConect.Close();
                return id;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string LerCEP(String MyQuery)
        {
            try
            {
                MySqlCommand MyCommand = new MySqlCommand(MyQuery, MyConect);
                MyReader = MyCommand.ExecuteReader();

                while (MyReader.Read())
                {
                    cep = (MyReader["cep_pessoa"].ToString());
                }

                MyReader.Close();
                MyConect.Close();
                return cep;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string LerEndereco(String MyQuery)
        {
            try
            {
                MySqlCommand MyCommand = new MySqlCommand(MyQuery, MyConect);
                MyReader = MyCommand.ExecuteReader();

                while (MyReader.Read())
                {
                    endereco = (MyReader["endereco_pessoa"].ToString());
                }

                MyReader.Close();
                MyConect.Close();
                return endereco;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string LerEmail(String MyQuery)
        {
            try
            {
                MySqlCommand MyCommand = new MySqlCommand(MyQuery, MyConect);
                MyReader = MyCommand.ExecuteReader();

                while (MyReader.Read())
                {
                    email = (MyReader["email_pessoa"].ToString());
                }

                MyReader.Close();
                MyConect.Close();
                return email;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string LerTelefone(String MyQuery)
        {
            try
            {
                MySqlCommand MyCommand = new MySqlCommand(MyQuery, MyConect);
                MyReader = MyCommand.ExecuteReader();

                while (MyReader.Read())
                {
                    telefone = (MyReader["telefone_pessoa"].ToString());
                }

                MyReader.Close();
                MyConect.Close();
                return telefone;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string LerSenha(String MyQuery)
        {
            try
            {
                MySqlCommand MyCommand = new MySqlCommand(MyQuery, MyConect);
                MyReader = MyCommand.ExecuteReader();

                while (MyReader.Read())
                {
                    senha = (MyReader["senha_pessoa"].ToString());
                }

                MyReader.Close();
                MyConect.Close();
                return senha;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}







