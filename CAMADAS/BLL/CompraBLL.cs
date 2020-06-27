using Mercado_Thay_and_Lusca.CAMADAS.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado_Thay_and_Lusca.CAMADAS.BLL
{
    public class CompraBLL
    {
        public List<MODEL.Carrinho> SelectCarrinhoByCliente(int idCliente)
        {
            DAL.CompraDAL dalCompra = new DAL.CompraDAL();
            return dalCompra.SelectCarrinhoByCliente(idCliente);
        }
        public void adicionarAoCarrinho(MODEL.Carrinho carrinho)
        {
            string erro = "";
            if (carrinho.idCliente <= 0)
            {
                erro += "\tLogue novamente, cliente invalido\n";
            }
            if (carrinho.idProduto <= 0)
            {
                erro += "\tProduto inválido, selecione novamente\n";
            }
            if (carrinho.total <= 0)
            {
                erro += "\tValor total inválido\n";
            }
            if (carrinho.quantidade <= 0)
            {
                erro += "\tQuantidade informada inválida\n";
            }
            if (erro.Equals(""))
            {
                DAL.CompraDAL dalCompra = new DAL.CompraDAL();

                int quantidadeTotal = dalCompra.retornarQuantidadeEmEstoqueProdutoPorId(carrinho.idProduto);
                if (quantidadeTotal < carrinho.quantidade)
                {
                    MessageBox.Show("A quantidade em estoque não é suficiente!");
                    return;
                }
                quantidadeTotal -= carrinho.quantidade;

                double saldoTotal = dalCompra.retornarSaldoClientePorId(carrinho.idCliente);
                if (saldoTotal < carrinho.total)
                {
                    MessageBox.Show("O seu saldo não é suficiente para cumprir a transação");
                    return;
                }
                saldoTotal -= carrinho.total;

                dalCompra.adicionarAoCarrinho(carrinho);
                dalCompra.debitarProdutosById(carrinho.idProduto, quantidadeTotal);
                dalCompra.setarNovoSaldoClientePorId(carrinho.idCliente, saldoTotal);
            }
            else
            {
                MessageBox.Show("Erros detectados: \n" + erro);
            }
        }

        public void finalizarCompra(int idCliente)
        {
            DAL.CompraDAL dalComp = new DAL.CompraDAL();
            List<MODEL.Carrinho> produtosCarrinho = dalComp.SelectCarrinhoByCliente(idCliente);
            if(produtosCarrinho.Count == 0)
            {
                MessageBox.Show("Escolha ao menos 1 item para efetuar a compra");
                return;
            }
            int idRegistroCompra = dalComp.gerarRegistroCompra(idCliente);
            float totalPago = dalComp.criarCompra(idRegistroCompra, produtosCarrinho);
            dalComp.deletarCarrinhoPorIdCliente(idCliente);
            dalComp.inserirTotalRegistroCompra(idRegistroCompra, totalPago);
        }

        public void deletarCarrinhoCliente(int idCliente)
        {
            DAL.CompraDAL dalComp = new DAL.CompraDAL();
            List<MODEL.Carrinho> produtosCarrinho = dalComp.SelectCarrinhoByCliente(idCliente);
            double retornoSaldo = 0;
            foreach(MODEL.Carrinho car in produtosCarrinho)
            {
                retornoSaldo += car.total;
                dalComp.debitarProdutosById(car.idProduto, dalComp.retornarQuantidadeEmEstoqueProdutoPorId(car.idProduto) + car.quantidade);
            }
            dalComp.deletarCarrinhoPorIdCliente(idCliente);
            retornoSaldo += dalComp.retornarSaldoClientePorId(idCliente);
            dalComp.setarNovoSaldoClientePorId(idCliente, retornoSaldo);
        }

        public List<MODEL.RegistroCompra> SelectRegistroCompraByIdCliente(int idCliente)
        {
            if(idCliente < 1)
            {
                MessageBox.Show("Cliente inválido");
                return null;
            } else
            {
                DAL.CompraDAL dalComp = new DAL.CompraDAL();
                return dalComp.SelectRegistroCompraByIdCliente(idCliente);
            }
        }

        public List<MODEL.RegistroCompra> SelectRegistroCompraById(int id)
        {
            if (id < 1)
            {
                MessageBox.Show("Cliente inválido");
                return null;
            }
            else
            {
                DAL.CompraDAL dalComp = new DAL.CompraDAL();
                return dalComp.SelectRegistroCompraById(id);
            }
        }

        public List<MODEL.Compra> SelectComprasRealizadasByIdRegistro(int idRegistro)
        {
            DAL.CompraDAL dalComp = new DAL.CompraDAL();
            return dalComp.SelectComprasRealizadasByIdRegistro(idRegistro);
        }

        public List<MODEL.RegistroCompra> SelectAllRegistroCompra()
        {
            DAL.CompraDAL dalComp = new DAL.CompraDAL();
            return dalComp.SelectAllRegistroCompra();
        }
    }
}

