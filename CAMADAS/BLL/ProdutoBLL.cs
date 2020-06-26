using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado_Thay_and_Lusca.CAMADAS.BLL
{
    public class ProdutoBLL
    {
        public void Insert(MODEL.Produto produto, Image imagem)
        {
            string erro = "";
            if(produto.produto.Equals(""))
            {
                erro += "\tO nome do produto não pode ser nulo\n";
            }
            if(produto.idCategoria.Equals(0))
            {
                erro += "\tSelecione uma categoria\n";
            }
            if(produto.preco < 0.00)
            {
                erro += "\tPreço não pode ser menor que R$0.00\n";
            }
            if(produto.quantidadeEstoque < 0)
            {
                erro += "\tEstoque não pode ser negativo\n";
            }
            if(erro.Equals(""))
            {
                DAL.ProdutoDAL dalProd = new DAL.ProdutoDAL();
                dalProd.Insert(produto, imagem);
            } else
            {
                MessageBox.Show("Erros detectados: \n" + erro);
            }
        }

        public List<MODEL.Produto> SelectAll()
        {
            DAL.ProdutoDAL dalProd = new DAL.ProdutoDAL();
            return dalProd.SelectAll();
        }

        public void Update(MODEL.Produto produto)
        {
            string erro = "";
            if(produto.id < 0) {
                erro += "\tSelecione um produto na tabela!\n";
            }

            if (produto.produto.Equals(""))
            {
                erro += "\tO nome do produto não pode ser nulo\n";
            }
            if (produto.idCategoria.Equals(0))
            {
                erro += "\tSelecione uma categoria\n";
            }
            if (produto.preco < 0.00)
            {
                erro += "\tPreço não pode ser menor que R$0.00\n";
            }
            if (produto.quantidadeEstoque < 0)
            {
                erro += "\tEstoque não pode ser negativo\n";
            }
            if (erro.Equals(""))
            {
                DAL.ProdutoDAL dalProd = new DAL.ProdutoDAL();
                dalProd.Update(produto);
            }
            else
            {
                MessageBox.Show("Erros detectados: \n" + erro);
            } 
        }

        public void Delete(int id)
        {
            if (id < 0)
            {
                MessageBox.Show("Selecione um produto na tabela!");
            }
             else
            {
                DAL.ProdutoDAL dalProd = new DAL.ProdutoDAL();
                dalProd.Delete(id);
            }
        } 

        public List<MODEL.Produto> SelectById(int id)
        {
            DAL.ProdutoDAL dalProd = new DAL.ProdutoDAL();
            return dalProd.SelectById(id);
        }
        public List<MODEL.Produto> SelectByIdCategoria(int idCategoria)
        {
            DAL.ProdutoDAL dalProd = new DAL.ProdutoDAL();
            return dalProd.SelectByIdCategoria(idCategoria);
        }
        public List<MODEL.Produto> SelectByProduto(string produto)
        {
            DAL.ProdutoDAL dalProd = new DAL.ProdutoDAL();
            return dalProd.SelectByProduto(produto);
        }

    }
}
