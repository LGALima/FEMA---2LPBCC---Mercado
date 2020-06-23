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
    }
}
