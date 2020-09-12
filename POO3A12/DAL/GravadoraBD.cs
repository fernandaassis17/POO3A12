using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3A12.DAL
{
    class GravadoraBD
    {
        private MySqlConnection conexao;
        private string string_conexao = "Persist security info= false; " +
                                         "server = localhost; " +
                                         "Database= bd_gravadora ;" +
                                         "user = root; pwd=;";
        // Metodo para conexão com o BD

        public void AlterarTabelas(string sql)
        {
            conectar();
            MySqlCommand comandos = new MySqlCommand(sql, conexao);
            comandos.ExecuteNonQuery();
            conexao.Close();
        }

        public DataTable ConsultarTabelas(string sql)
        {
            conectar();
            MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
            DataTable resultado = new DataTable();
            consulta.Fill(resultado);
            conexao.Close();
            return resultado;
        }

        public void conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch (MySqlException e)
            {
                throw new Exception("Problemas na conexão com o banco de dados. Erro: " + e.Message + " " + string_conexao);

            }
        }
        // Metodo para Executar Consulta no Banco, sem necessidade de retorno de dados
        public void ExecutarComando(string sql)
        {
            try
            {
                conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possível executar a instrução no Banco. Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        // Metodo para retornar registros do banco de Dados - Retorna em um DataTable
        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possível executar a consulta no Banco de Dados. Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
