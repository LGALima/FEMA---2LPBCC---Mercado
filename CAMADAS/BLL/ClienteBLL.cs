using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado_Thay_and_Lusca.CAMADAS.BLL
{
    public class ClienteBLL
    {
        public List<MODEL.Cliente> SelectAll()
        {
            DAL.ClienteDAL cliDal = new DAL.ClienteDAL();
            return cliDal.SelectAll();
        }
        public void Insert(MODEL.Cliente cliente, Image imagem)
        {
            string erro = "";
            if(cliente.usuario.Equals(""))
            {
                erro += "\tUsuario não pode ser nulo\n";
            }
            if(cliente.senha.Equals(""))
            {
                erro += "\tSenha não pode ser nula\n";
            }
            if(cliente.nome.Equals(""))
            {
                erro += "\tNome não pode ser nulo\n";
            }
            if(cliente.endereco.Equals(""))
            {
                erro += "\tEndereco não pode ser nulo\n";
            }
            if(cliente.saldo < 0 || cliente.saldo.Equals(null))
            {
                erro += "\tSaldo não pode ser" + (cliente.saldo < 0 ? " menor que zero" : " nulo") + "\n";
            }
            if(cliente.imagem.Equals(""))
            {
                erro += "\tSelecione uma imagem de perfil\n";
            }

            if (!erro.Equals(""))
            {
                MessageBox.Show("Erros detectados: \n" + erro);
            } else
            {
                DAL.ClienteDAL cliDal = new DAL.ClienteDAL();
                cliDal.Insert(cliente, imagem);
            }
        }

        public void Update(MODEL.Cliente cliente, Image imagem)
        {
            string erro = "";
            if(cliente.id < 1)
            {
                erro += "\tId invalido\n";
            }
            if (cliente.senha.Equals(""))
            {
                erro += "\tSenha não pode ser nula\n";
            }
            if (cliente.nome.Equals(""))
            {
                erro += "\tNome não pode ser nulo\n";
            }
            if (cliente.endereco.Equals(""))
            {
                erro += "\tEndereco não pode ser nulo\n";
            }
            if (cliente.saldo < 0 || cliente.saldo.Equals(null))
            {
                erro += "\tSaldo não pode ser" + (cliente.saldo < 0 ? " menor que zero" : " nulo") + "\n";
            }
            if (cliente.imagem.Equals(""))
            {
                erro += "\tSelecione uma imagem de perfil\n";
            }

            if (!erro.Equals(""))
            {
                MessageBox.Show("Erros detectados: \n" + erro);
            }
            else
            {
                DAL.ClienteDAL cliDal = new DAL.ClienteDAL();
                cliDal.UpdateByCliente(cliente, imagem);
            }
        }

        public void DeleteByCliente(MODEL.Cliente cliente)
        {
            if(cliente.id < 1)
            {
                MessageBox.Show("Cliente inválido, tente novamente");
            } else
            {
                DAL.ClienteDAL cliDal = new DAL.ClienteDAL();
                cliDal.DeleteByCliente(cliente);
            }
        }
        
        public List<MODEL.Cliente> SelectByUsuario(string usuario)
        { 
            DAL.ClienteDAL cliDal = new DAL.ClienteDAL();
            return cliDal.SelectByUsuario(usuario);   
        }

        public List<MODEL.Cliente> SelectById(int id)
        {
            DAL.ClienteDAL cliDal = new DAL.ClienteDAL();
            return cliDal.SelectById(id);
        }
    }
}
