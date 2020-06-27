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
    public class CompraDAL
    {
        private static string strCon = Conexao.getConexao();
        public List<MODEL.Carrinho> SelectCarrinhoByCliente(int idCliente)
        {
            List<MODEL.Carrinho> lstCarrinho = new List<MODEL.Carrinho>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Carrinho WHERE idCliente=@idCliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", idCliente);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Carrinho carrinho = new MODEL.Carrinho();
                    carrinho.id = Convert.ToInt32(dados["id"].ToString());
                    carrinho.idCliente = Convert.ToInt32(dados["idCliente"].ToString());
                    carrinho.idProduto = Convert.ToInt32(dados["idProduto"].ToString());
                    carrinho.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    carrinho.total = Convert.ToSingle(dados["total"].ToString());
                    lstCarrinho.Add(carrinho);
                }
            }
            catch{
                MessageBox.Show("Erro ao buscar carrinho");
            }
            finally
            {
                conexao.Close();
            }
            return lstCarrinho;
        }

        public void adicionarAoCarrinho(MODEL.Carrinho carrinho)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql1 = "INSERT INTO Carrinho VALUES (@idCliente, @idProduto, @quantidade, @total)";
            SqlCommand cmd1 = new SqlCommand(sql1, conexao);
            cmd1.Parameters.AddWithValue("@idCliente", carrinho.idCliente);
            cmd1.Parameters.AddWithValue("@idProduto", carrinho.idProduto);
            cmd1.Parameters.AddWithValue("@quantidade", carrinho.quantidade);
            cmd1.Parameters.AddWithValue("@total", carrinho.total);

            try
            {
                conexao.Open();
                cmd1.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Erro ao inserir Produto no Carrinho, tente novamente!");
                return;
            }
            finally
            {
                conexao.Close();
            }
        }

        public int retornarQuantidadeEmEstoqueProdutoPorId(int idProduto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Produto WHERE id=@id";
            SqlCommand cmd2 = new SqlCommand(sql, conexao);
            cmd2.Parameters.AddWithValue("@id", idProduto);

            int quantidadeTotal = 0;
            try
            {
                conexao.Open();
                SqlDataReader dadosProduto = cmd2.ExecuteReader(CommandBehavior.CloseConnection);
                while (dadosProduto.Read())
                {
                    quantidadeTotal = Convert.ToInt32(dadosProduto["quantidadeEstoque"].ToString());
                }

            }
            catch
            {
                MessageBox.Show("Erro ao inserir retornar quantidade em estoque, tente novamente!");
            }
            finally
            {
                conexao.Close();
            }
            return quantidadeTotal;
        }
        public double retornarSaldoClientePorId(int idCliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Cliente WHERE id=@id";
            SqlCommand cmd2 = new SqlCommand(sql, conexao);
            cmd2.Parameters.AddWithValue("@id", idCliente);

            double saldoTotal = 0;
            try
            {
                conexao.Open();
                SqlDataReader dadosProduto = cmd2.ExecuteReader(CommandBehavior.CloseConnection);
                while (dadosProduto.Read())
                {
                    saldoTotal = Convert.ToDouble(dadosProduto["saldo"].ToString());
                }

            }
            catch
            {
                MessageBox.Show("Erro ao retornar saldo do cliente, tente novamente!");
            }
            finally
            {
                conexao.Close();
            }
            return saldoTotal;
        }

        public void setarNovoSaldoClientePorId(int idCliente, double saldo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Cliente SET saldo=@saldo WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idCliente);
            cmd.Parameters.AddWithValue("@saldo", saldo);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            } 
            catch
            {
                MessageBox.Show("Erro ao atualizar o saldo do cliente, faça manualment, SALDO: " + saldo);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void debitarProdutosById(int idProduto, int quantidade)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql3 = "UPDATE Produto SET quantidadeEstoque=@quantidade WHERE id=@id";
            SqlCommand cmd3 = new SqlCommand(sql3, conexao);
            cmd3.Parameters.AddWithValue("@id", idProduto);
            cmd3.Parameters.AddWithValue("@quantidade", quantidade);
            try
            {
                conexao.Open();
                cmd3.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Erro ao debitar estoque do produto, faça-o manualmente!");
                return;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void deletarCarrinhoPorIdCliente(int idCliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Carrinho WHERE idCliente=@idCliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", idCliente);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            } 
            catch
            {
                MessageBox.Show("Erro ao deletar Produtos do Carrinho, tente novamente!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public int gerarRegistroCompra(int idCliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Registro_Compra (data, idCliente) VALUES (@data, @idCliente); SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@data", DateTime.Now);
            cmd.Parameters.AddWithValue("@idCliente", idCliente);

            int idRecebido = -1;
            try
            {
                conexao.Open();
                idRecebido = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch
            {
                MessageBox.Show("Erro ao criar o registro de compra, tente novamente!");
            }
            finally
            {
                conexao.Close();
            }
            return idRecebido;
        }

        public void inserirTotalRegistroCompra(int idRegistroCompra, float total)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Registro_Compra SET total_pago=@total where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@id", idRegistroCompra);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Erro ao registrar o total pago no registro de compra, tente novamente!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public float criarCompra(int idRegistro, List<MODEL.Carrinho> lstCarrinho)
        {
            float total = 0;
            string sql = "INSERT INTO Compra_efetuada (idCliente, idProduto, idCompra, quantidade, total) VALUES (@idCliente, @idProduto, @idCompra, @quantidade, @total)";
            for(int i = 0; i < lstCarrinho.Count; i++) { 
                SqlConnection conexao = new SqlConnection(strCon);
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@idCliente", lstCarrinho[i].idCliente);
                cmd.Parameters.AddWithValue("@idProduto", lstCarrinho[i].idProduto);
                cmd.Parameters.AddWithValue("@idCompra", idRegistro);
                cmd.Parameters.AddWithValue("@quantidade", lstCarrinho[i].quantidade);
                cmd.Parameters.AddWithValue("@total", lstCarrinho[i].total);
                try
                {
                    conexao.Open();
                    total += lstCarrinho[i].total;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                } 
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    MessageBox.Show("Erro ao inserir o produto: " + lstCarrinho[i].idProduto + " a tabela de compras");
                }
                finally
                {
                    conexao.Close();
                }
             }
            return total;
        }

        public List<MODEL.RegistroCompra> SelectRegistroCompraByIdCliente(int idCliente)
        {
            List<MODEL.RegistroCompra> registros = new List<MODEL.RegistroCompra>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Registro_Compra WHERE idCliente=@idCliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", idCliente);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.RegistroCompra registro = new MODEL.RegistroCompra();
                    registro.id = Convert.ToInt32(dados["id"].ToString());
                    registro.data = Convert.ToDateTime(dados["data"].ToString());
                    registro.idCliente = Convert.ToInt32(dados["idCliente"].ToString());
                    registro.totalPago = Convert.ToSingle(dados["total_pago"].ToString());
                    registros.Add(registro);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao selecionar Registro de compra, tente novamente");
            }
            finally
            {
                conexao.Close();
            }
            return registros;
        }
    }
}
