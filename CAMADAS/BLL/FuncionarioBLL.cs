using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado_Thay_and_Lusca.CAMADAS.BLL
{
    public class FuncionarioBLL
    {
        public List<MODEL.Funcionario> Select()
        {
            DAL.FuncionarioDAL dalFunc = new DAL.FuncionarioDAL();
            return dalFunc.Select();
        }

        public List<MODEL.Funcionario> SelectByID(int id)
        {
            DAL.FuncionarioDAL dalFunc = new DAL.FuncionarioDAL();
            return dalFunc.SelectByID(id);
        }

        public List<MODEL.Funcionario> SelectByNome(string nome)
        {
            DAL.FuncionarioDAL dalFunc = new DAL.FuncionarioDAL();
            return dalFunc.SelectByNome(nome);
        }

        public void Insert(MODEL.Funcionario funcionario, Image imagem)
        {
            string erro = "";
            if (funcionario.usuario.Equals(""))
                erro += "\tUsuário não pode ser nulo\n";
            if (funcionario.senha.Equals(""))
                erro += "\tSenha não pode ser nula\n";
            if (funcionario.nome.Equals(""))
                erro += "\tNome não pode ser nulo\n";
            if (!erro.Equals(""))
            {
                string title = "Erros detectados";
                MessageBox.Show(erro, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DAL.FuncionarioDAL dalFunc = new DAL.FuncionarioDAL();
                dalFunc.Insert(funcionario, imagem);
            }
                
        }

        public void Update(MODEL.Funcionario funcionario)
        {
            DAL.FuncionarioDAL dalFunc = new DAL.FuncionarioDAL();
            dalFunc.Update(funcionario);
        }
        public void Delete(int idFuncionario)
        {
            DAL.FuncionarioDAL dalFunc = new DAL.FuncionarioDAL();
            dalFunc.Delete(idFuncionario);
        }

    }
}
