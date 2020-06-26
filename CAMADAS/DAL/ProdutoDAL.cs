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
    public class ProdutoDAL
    {
        public static string strCon = Conexao.getConexao();

        public void Insert(MODEL.Produto produto, Image imagem)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Produto VALUES (@produto, @idCategoria, @quantidadeEstoque, @preco, @imagem)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@produto", produto.produto);
            cmd.Parameters.AddWithValue("@idCategoria", produto.idCategoria);
            cmd.Parameters.AddWithValue("@quantidadeEstoque", produto.quantidadeEstoque);
            cmd.Parameters.AddWithValue("@preco", produto.preco);
            cmd.Parameters.AddWithValue("@imagem", produto.imagem);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                imagem.Save(Conexao.getPathImagens() + @"Produtos\" + produto.imagem);
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar Produto, tente novamente!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Produto SET produto=@produto, idCategoria=@idCategoria, quantidadeEstoque=@quantidadeEstoque, preco=@preco where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", produto.id);
            cmd.Parameters.AddWithValue("@produto", produto.produto);
            cmd.Parameters.AddWithValue("@idCategoria", produto.idCategoria);
            cmd.Parameters.AddWithValue("@quantidadeEstoque", produto.quantidadeEstoque);
            cmd.Parameters.AddWithValue("@preco", produto.preco);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Erro ao Editar Produto, tente novamente!");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Produto WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Erro ao Editar Produto, tente novamente!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<MODEL.Produto> SelectAll()
        {
            List<MODEL.Produto> lstProdutos = new List<MODEL.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Produto";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while(dados.Read())
                {
                    MODEL.Produto produto = new MODEL.Produto();
                    produto.produto = dados["produto"].ToString();
                    produto.preco = Convert.ToSingle(dados["preco"].ToString());
                    produto.idCategoria = Convert.ToInt32(dados["idCategoria"].ToString());
                    produto.id = Convert.ToInt32(dados["id"].ToString());
                    produto.quantidadeEstoque = Convert.ToInt32(dados["quantidadeEstoque"].ToString());
                    produto.imagem = dados["imagem"].ToString();
                    lstProdutos.Add(produto);
                }
            } catch
            {
                MessageBox.Show("Erro ao buscar produtos! Tente novamente mais tarde!");
            } finally
            {
                conexao.Close();
            }
           return lstProdutos;
        }
        public List<MODEL.Produto> SelectById(int id)
        {
            List<MODEL.Produto> lstProdutos = new List<MODEL.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Produto WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Produto produto = new MODEL.Produto();
                    produto.produto = dados["produto"].ToString();
                    produto.preco = Convert.ToSingle(dados["preco"].ToString());
                    produto.idCategoria = Convert.ToInt32(dados["idCategoria"].ToString());
                    produto.id = Convert.ToInt32(dados["id"].ToString());
                    produto.quantidadeEstoque = Convert.ToInt32(dados["quantidadeEstoque"].ToString());
                    produto.imagem = dados["imagem"].ToString();
                    lstProdutos.Add(produto);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao buscar produtos! Tente novamente mais tarde!");
            }
            finally
            {
                conexao.Close();
            }
            return lstProdutos;
        }
        public List<MODEL.Produto> SelectByIdCategoria(int idCategoria)
        {
            List<MODEL.Produto> lstProdutos = new List<MODEL.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Produto WHERE idCategoria=@idCategoria";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Produto produto = new MODEL.Produto();
                    produto.produto = dados["produto"].ToString();
                    produto.preco = Convert.ToSingle(dados["preco"].ToString());
                    produto.idCategoria = Convert.ToInt32(dados["idCategoria"].ToString());
                    produto.id = Convert.ToInt32(dados["id"].ToString());
                    produto.quantidadeEstoque = Convert.ToInt32(dados["quantidadeEstoque"].ToString());
                    produto.imagem = dados["imagem"].ToString();
                    lstProdutos.Add(produto);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao buscar produtos! Tente novamente mais tarde!");
            }
            finally
            {
                conexao.Close();
            }
            return lstProdutos;
        }

        public List<MODEL.Produto> SelectByProduto(string prod)
        {
            List<MODEL.Produto> lstProdutos = new List<MODEL.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Produto WHERE produto LIKE @produto";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@produto", "%" + prod + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Produto produto = new MODEL.Produto();
                    produto.produto = dados["produto"].ToString();
                    produto.preco = Convert.ToSingle(dados["preco"].ToString());
                    produto.idCategoria = Convert.ToInt32(dados["idCategoria"].ToString());
                    produto.id = Convert.ToInt32(dados["id"].ToString());
                    produto.quantidadeEstoque = Convert.ToInt32(dados["quantidadeEstoque"].ToString());
                    produto.imagem = dados["imagem"].ToString();
                    lstProdutos.Add(produto);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao buscar produtos! Tente novamente mais tarde!");
            }
            finally
            {
                conexao.Close();
            }
            return lstProdutos;
        }
    }
}
