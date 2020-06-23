using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Thay_and_Lusca.CAMADAS.DAL
{
    public class FuncionarioDAL
    {
        private string strCon = Conexao.getConexao();
        public void Insert(MODEL.Funcionario funcionario)
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
    }
}
