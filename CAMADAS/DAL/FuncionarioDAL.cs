using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado_Thay_and_Lusca.CAMADAS.DAL
{
    public class FuncionarioDAL
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Funcionario> Select()
        {
            List<MODEL.Funcionario> lstFuncionarios = new List<MODEL.Funcionario>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Funcionario;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Funcionario funcionario = new MODEL.Funcionario();
                    funcionario.id = Convert.ToInt32(dados[0].ToString());
                    funcionario.usuario = dados["usuario"].ToString();
                    funcionario.senha = dados["senha"].ToString();
                    funcionario.nome = dados["nome"].ToString();
                    funcionario.isAdm = dados["isAdm"].ToString();
                    funcionario.imagem = dados["imagem"].ToString();
                    lstFuncionarios.Add(funcionario);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na execução do comando select de funcionarios");
            }
            finally
            {
                conexao.Close();
            }
            return lstFuncionarios;
        }

        public List<MODEL.Funcionario> SelectByID(int id)
        {
            List<MODEL.Funcionario> lstFuncionario = new List<MODEL.Funcionario>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Funcionario WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Funcionario funcionario = new MODEL.Funcionario();
                    funcionario.id = Convert.ToInt32(dados["id"].ToString());
                    funcionario.usuario = dados["usuario"].ToString();
                    funcionario.senha = dados["senha"].ToString();
                    funcionario.nome = dados["nome"].ToString();
                    funcionario.isAdm = dados["isAdm"].ToString();
                    funcionario.imagem = dados["imagem"].ToString();
                    lstFuncionario.Add(funcionario);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na execução do comando select por ID de funcionarios");
            }
            finally
            {
                conexao.Close();
            }
            return lstFuncionario;
        }

        public List<MODEL.Funcionario> SelectByNome(string nome)
        {
            List<MODEL.Funcionario> lstFuncionarios = new List<MODEL.Funcionario>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Funcionario WHERE (nome LIKE @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Funcionario funcionario = new MODEL.Funcionario();
                    funcionario.id = Convert.ToInt32(dados[0].ToString());
                    funcionario.usuario = dados["usuario"].ToString();
                    funcionario.senha = dados["senha"].ToString();
                    funcionario.nome = dados["nome"].ToString();
                    funcionario.isAdm = dados["isAdm"].ToString();
                    funcionario.imagem = dados["imagem"].ToString();
                    lstFuncionarios.Add(funcionario);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na execução do comando select por nome de funcionarios");
            }
            finally
            {
                conexao.Close();
            }
            return lstFuncionarios;
        }

        public void Insert(MODEL.Funcionario funcionario, Image imagem)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Funcionario values (@usuario, @senha, @nome, @isAdm, @imagem);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@usuario", funcionario.usuario);
            cmd.Parameters.AddWithValue("@senha", funcionario.senha);
            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@isAdm", funcionario.isAdm);
            cmd.Parameters.AddWithValue("@imagem", funcionario.imagem);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                imagem.Save(Conexao.getPathImagens() + @"Funcionarios\" + funcionario.imagem);
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de funcionários...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Funcionario funcionario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Funcionario SET senha=@senha, nome=@nome, isAdm=@isAdm WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", funcionario.id);
            cmd.Parameters.AddWithValue("@senha", funcionario.senha);
            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@isAdm", funcionario.isAdm);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Deu erro na atualização de funcionários");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Funcionario  WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na exclusão de funcionários");
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
