using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado_Thay_and_Lusca.CAMADAS.DAL
{
    public class CategoriaDAL
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Categoria> SelectAll()
        {
            List<MODEL.Categoria> lstCategorias = new List<MODEL.Categoria>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Categoria";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while(dados.Read())
                {
                    MODEL.Categoria categoria = new MODEL.Categoria();
                    categoria.id = Convert.ToInt32(dados["id"].ToString());
                    categoria.descricao = dados["descricao"].ToString();
                    lstCategorias.Add(categoria);
                }
            } catch
            {
                MessageBox.Show("Erro ao buscar categorias, tente novamente!");
            } finally
            {
                conexao.Close();
            }
            return lstCategorias;
        }

        public void Insert(MODEL.Categoria categoria)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Categoria (descricao) VALUES (@descricao)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", categoria.descricao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            } catch
            {
                MessageBox.Show("Erro ao cadastrar Categoria! Tente mais tarde!");
            } finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Categoria categoria)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Categoria SET descricao=@descricao WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", categoria.id);
            cmd.Parameters.AddWithValue("@descricao", categoria.descricao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Erro ao editar Categoria! Tente mais tarde!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(MODEL.Categoria categoria)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Categoria WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", categoria.id);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Erro ao deletar Categoria! Tente mais tarde!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<MODEL.Categoria> SelectById(int id)
        {
            List<MODEL.Categoria> lstCategorias = new List<MODEL.Categoria>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Categoria WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Categoria categoria = new MODEL.Categoria();
                    categoria.id = Convert.ToInt32(dados["id"].ToString());
                    categoria.descricao = dados["descricao"].ToString();
                    lstCategorias.Add(categoria);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao buscar categorias, tente novamente!");
            }
            finally
            {
                conexao.Close();
            }
            return lstCategorias;
        }

        public List<MODEL.Categoria> SelectByDescricao(string descricao)
        {
            List<MODEL.Categoria> lstCategorias = new List<MODEL.Categoria>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Categoria WHERE descricao LIKE @descricao";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", "%" + descricao + "%");

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Categoria categoria = new MODEL.Categoria();
                    categoria.id = Convert.ToInt32(dados["id"].ToString());
                    categoria.descricao = dados["descricao"].ToString();
                    lstCategorias.Add(categoria);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao buscar categorias, tente novamente!");
            }
            finally
            {
                conexao.Close();
            }
            return lstCategorias;
        }
    }
}
