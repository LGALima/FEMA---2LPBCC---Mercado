using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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
                imagem.Save("C:\\Tudo\\Fema\\2020\\almir\\06-29 - Trabalho .net mercadin\\Mercado Thay and Lusca\\Imagens\\Clientes\\" + cliente.imagem);
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

        public List<Cliente> selectByUsuarioExato(string usuario)
        {
            return null;
        }
    }
}
