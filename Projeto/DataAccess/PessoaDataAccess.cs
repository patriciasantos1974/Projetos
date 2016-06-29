using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PessoaDataAccess
    {
        private string conectionstring = "server=127.0.0.1;uid=root;pwd=123Mudar;database=bdprojeto;";

        public void InserirPessoa(Pessoa pessoa)
        {
            MySqlConnection Conection = new MySqlConnection(conectionstring);
            Conection.Open();

            var sql = "Insert into tb_Pessoa (Nome, Sexo, Salario, DtNascimento) values (@Nome, @Sexo, @Salario,@DtNascimento)";

            MySqlCommand cmd = new MySqlCommand();
            
            cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
            cmd.Parameters.AddWithValue("@Sexo", pessoa.Sexo);
            cmd.Parameters.AddWithValue("@Salario", pessoa.Salario);
            cmd.Parameters.AddWithValue("@DtNascimento", pessoa.DataNascimento);

            cmd.CommandText = sql;
            cmd.Connection = Conection;
            //cmd.CommandType = CommandType.TableDirect;
            // MySqlDataReader reader = cmd.ExecuteReader();  Para Select
            cmd.ExecuteScalar();

        }

        public void AlterarPessoa(Pessoa pessoa)
        {
            MySqlConnection Conection = new MySqlConnection(conectionstring);
            Conection.Open();

            var sql = "Update tb_Pessoa set Nome = @Nome, Sexo = @Sexo, Salario=@Salario, DtNascimento = @DtNascimento where ID_Pessoa = @IdPessoa";

            MySqlCommand cmd = new MySqlCommand();

            cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
            cmd.Parameters.AddWithValue("@Sexo", pessoa.Sexo);
            cmd.Parameters.AddWithValue("@Salario", pessoa.Salario);
            cmd.Parameters.AddWithValue("@DtNascimento", pessoa.DataNascimento);
            cmd.Parameters.AddWithValue("@IdPessoa", pessoa.IDPessoa);

            cmd.CommandText = sql;
            cmd.Connection = Conection;
            //cmd.CommandType = CommandType.TableDirect;
            // MySqlDataReader reader = cmd.ExecuteReader();  Para Select
            cmd.ExecuteScalar();

        }

        public Pessoa SelecionarPessoaPorId(int idpessoa)
        {
            Pessoa pessoa = new Pessoa();

            MySqlConnection Conection = new MySqlConnection(conectionstring);
            Conection.Open();

            var sql = "Select * From tb_Pessoa where ID_Pessoa = @IdPessoa";

            MySqlCommand cmd = new MySqlCommand();

            cmd.Parameters.AddWithValue("@IdPessoa", idpessoa);
            cmd.CommandText = sql;
            cmd.Connection = Conection;
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pessoa.Nome = Convert.ToString(reader["Nome"]);
                pessoa.Sexo = Convert.ToString(reader["Sexo"]);
                pessoa.DataNascimento = Convert.ToDateTime(reader["DtNascimento"]);
                pessoa.Salario = Convert.ToDecimal(reader["Salario"]);
                pessoa.IDPessoa = Convert.ToInt32(reader["ID_Pessoa"]);
            }
            return pessoa;
        }
    }
}
