using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado_Thay_and_Lusca.CAMADAS.DAL
{
    public class ClienteDAL
    {
        public static string strCon = Conexao.getConexao();

        public void Insert(MODEL.Cliente cliente, Image imagem)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Cliente values (@usuario, @senha, @nome, @endereco, @saldo, @imagem)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@usuario", cliente.usuario);
            cmd.Parameters.AddWithValue("@senha", cliente.senha);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@saldo", cliente.saldo);
            cmd.Parameters.AddWithValue("@imagem", cliente.imagem);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                imagem.Save(Conexao.getPathImagens() + @"Clientes\" + cliente.imagem);
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar cliente, tente novamente!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<MODEL.Cliente> SelectAll()
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Cliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            List<MODEL.Cliente> lstClientes = new List<MODEL.Cliente>();

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while(dados.Read())
                {
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    cliente.id = Convert.ToInt32(dados["id"].ToString());
                    cliente.usuario = dados["usuario"].ToString();
                    cliente.senha = dados["senha"].ToString();
                    cliente.nome = dados["nome"].ToString();
                    cliente.endereco = dados["endereco"].ToString();
                    cliente.saldo = Convert.ToSingle(dados["saldo"].ToString());
                    cliente.imagem = dados["imagem"].ToString();
                    lstClientes.Add(cliente);
                }
            } catch
            {
                MessageBox.Show("Erro ao buscar clientes, tente denovo");
            } finally
            {
                conexao.Close();
            }
            return lstClientes;
        }

        public void DeleteByCliente(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Cliente WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                /*if(File.Exists(Conexao.getPathImagens() + @"Clientes\" + cliente.imagem))
                {
                    File.Delete(Conexao.getPathImagens() + @"Clientes\" + cliente.imagem);
                }*/
            } catch
            {
                MessageBox.Show("Erro ao deletar cliente, tente novamente!");
            } finally
            {
                conexao.Close();
            }
        }
        public void UpdateByCliente(MODEL.Cliente cliente, Image imagem)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Cliente SET senha=@senha, nome=@nome, endereco=@endereco, saldo=@saldo WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            cmd.Parameters.AddWithValue("@senha", cliente.senha);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@saldo", cliente.saldo);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();/*
                imagem.Save(Conexao.getPathImagens() + @"Clientes\" + cliente.imagem);*/
            } catch
            {
                MessageBox.Show("Erro ae autualizar cliente! Tente novamente.");
            } finally
            {
                conexao.Close();
            }
        }


        public List<MODEL.Cliente> SelectByUsuario(string usuario)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Cliente WHERE usuario LIKE @usuario";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@usuario", "%" + usuario+ "%");
            List<MODEL.Cliente> lstClientes = new List<MODEL.Cliente>();

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    cliente.id = Convert.ToInt32(dados["id"].ToString());
                    cliente.usuario = dados["usuario"].ToString();
                    cliente.senha = dados["senha"].ToString();
                    cliente.nome = dados["nome"].ToString();
                    cliente.endereco = dados["endereco"].ToString();
                    cliente.saldo = Convert.ToSingle(dados["saldo"].ToString());
                    cliente.imagem = dados["imagem"].ToString();
                    lstClientes.Add(cliente);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao buscar clientes, tente denovo");
            }
            finally
            {
                conexao.Close();
            }
            return lstClientes;
        }

        public List<MODEL.Cliente> SelectById(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Cliente WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            List<MODEL.Cliente> lstClientes = new List<MODEL.Cliente>();

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    cliente.id = Convert.ToInt32(dados["id"].ToString());
                    cliente.usuario = dados["usuario"].ToString();
                    cliente.senha = dados["senha"].ToString();
                    cliente.nome = dados["nome"].ToString();
                    cliente.endereco = dados["endereco"].ToString();
                    cliente.saldo = Convert.ToSingle(dados["saldo"].ToString());
                    cliente.imagem = dados["imagem"].ToString();
                    lstClientes.Add(cliente);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao buscar clientes, tente denovo");
            }
            finally
            {
                conexao.Close();
            }
            return lstClientes;
        }
    }
}
