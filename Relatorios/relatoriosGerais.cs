using Mercado_Thay_and_Lusca.Relatórios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Thay_and_Lusca.Relatorios
{
    public class relatoriosGerais
    {
        public static void relatorioFuncionarios()
        {
            CAMADAS.BLL.FuncionarioBLL bllFunc = new CAMADAS.BLL.FuncionarioBLL();
            List<CAMADAS.MODEL.Funcionario> lstFuncionarios = new List<CAMADAS.MODEL.Funcionario>();
            lstFuncionarios = bllFunc.Select().OrderByDescending(adm => adm.isAdm).ThenBy(nm => nm.nome.ToLower()).ToList();

            string pasta = Funcoes.diretorioPasta();
            string arquivo = pasta + @"\RelatoriosFunc.html";
            StreamWriter sw = new StreamWriter(arquivo);
            using (sw)
            {
                sw.WriteLine("<!DOCTYPE html>");
                sw.WriteLine("<HTML lang = 'pt - br'>");
                sw.WriteLine("<HEAD>");
                sw.WriteLine("<META http-equiv = 'Content-Type' content='text/css; charset=utf-8'/");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css\' integrity='sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk' crossorigin='anonymous'>");
                sw.WriteLine("<title> Relatorio de Funcionários </title>");
                sw.WriteLine("</HEAD>");
                sw.WriteLine("<BODY>");
                sw.WriteLine("<h1> Relatorio de Funcionários </h1> <hr> <br>");
                sw.WriteLine("<table class='table table-striped' width=100% border='2px' align='center'>");
                sw.WriteLine("<tr>");
                sw.WriteLine("<th>  ID </th>");
                sw.WriteLine("<th>  USUÁRIO </th>");
                sw.WriteLine("<th> NOME </th>");
                sw.WriteLine("<th>  ADMINISTRADOR </th>");
                sw.WriteLine("</tr>");
                int cont = 0;
                foreach (CAMADAS.MODEL.Funcionario func in lstFuncionarios)
                {
                    sw.WriteLine("<tr align='center'>");
                    sw.WriteLine("<td>");
                    sw.WriteLine(func.id);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td>");
                    sw.WriteLine(func.usuario);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td>");
                    sw.WriteLine(func.nome);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td>");
                    sw.WriteLine(func.isAdm.Equals("S") ? "Sim":"Não");
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                    cont++;
                }
                sw.WriteLine("</table> <br> <hr>");
                sw.WriteLine("<h2> Quantidade de Funcionários: {0}", cont);
                sw.WriteLine("</h2>");
                sw.WriteLine("</BODY>");
                sw.WriteLine("</HTML>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }

        public static void relatorioClientes()
        {
            CAMADAS.BLL.ClienteBLL bllCli = new CAMADAS.BLL.ClienteBLL();
            List<CAMADAS.MODEL.Cliente> lstClientes = new List<CAMADAS.MODEL.Cliente>();
            lstClientes = bllCli.SelectAll().OrderByDescending(nm => nm.nome.ToLower()).ToList();
            string pasta = Funcoes.diretorioPasta();
            string arquivo = pasta + @"\RelatoriosCli.html";
            StreamWriter sw = new StreamWriter(arquivo);
            using (sw)
            {
                sw.WriteLine("<!DOCTYPE html>");
                sw.WriteLine("<HTML lang = 'pt - br'>");
                sw.WriteLine("<HEAD>");
                sw.WriteLine("<META http-equiv = 'Content-Type' content='text/css; text='text/css' charset=utf-8'/");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");
                sw.WriteLine("<title> Relatorio de Clientes </title>");
                sw.WriteLine("</HEAD>");
                sw.WriteLine("<BODY>");
                sw.WriteLine("<h1> Relatorio de Clientes </h1> <hr> <br>");
                sw.WriteLine("<table class='table table-striped' width=100% border='2px' align='center'>");
                sw.WriteLine("<tr>");
                sw.WriteLine("<th> ID </th>");
                sw.WriteLine("<th> USUÁRIO </th>");
                sw.WriteLine("<th> NOME </th>");
                sw.WriteLine("<th> ENDEREÇO </th>");
                sw.WriteLine("<th> SALDO </th>");
                sw.WriteLine("</tr>");
                int cont = 0;
                foreach (CAMADAS.MODEL.Cliente cliente in lstClientes)
                {
                    sw.WriteLine("<tr align='center'>");
                    sw.WriteLine("<td>");
                    sw.WriteLine(cliente.id);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td>");
                    sw.WriteLine(cliente.usuario);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td>");
                    sw.WriteLine(cliente.nome);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td>");
                    sw.WriteLine(cliente.endereco);
                    sw.WriteLine("<td>");
                    sw.WriteLine(string.Format("{0:C2}", cliente.saldo));
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                    cont++;
                }
                sw.WriteLine("</table> <br> <hr>");
                sw.WriteLine("<h2> Quantidade de Clientes: {0}", cont);
                sw.WriteLine("</h2>");
                sw.WriteLine("</BODY>");
                sw.WriteLine("</HTML>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }

        public static void  relatorioVendas()
        {
            CAMADAS.BLL.CompraBLL bllCompra = new CAMADAS.BLL.CompraBLL();
            List<CAMADAS.MODEL.RegistroCompra> lstVenda = new List<CAMADAS.MODEL.RegistroCompra>();
            lstVenda = bllCompra.SelectAllRegistroCompra();
            string pasta = Funcoes.diretorioPasta();
            string arquivo = pasta + @"\RelatoriosVenda.html";
            StreamWriter sw = new StreamWriter(arquivo);
            using (sw)
            {
                sw.WriteLine("<!DOCTYPE html>");
                sw.WriteLine("<HTML lang = 'pt - br'>");
                sw.WriteLine("<HEAD>");
                sw.WriteLine("<META http-equiv = 'Content-Type' content='text/css; text='text/css' charset=utf-8'/");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");
                sw.WriteLine("<title> Relatorio de Vendas </title>");
                sw.WriteLine("</HEAD>");
                sw.WriteLine("<BODY>");
                sw.WriteLine("<h1> Relatorio de Venda </h1> <hr> <br>");
                sw.WriteLine("<table class='table table-striped' width=100% border='2px' align='center'>");
                sw.WriteLine("<tr>");
                sw.WriteLine("<th> ID </th>");
                sw.WriteLine("<th> ID-CLIENTE </th>");
                sw.WriteLine("<th> DATA </th>");
                sw.WriteLine("<th> TOTAL </th>");
                sw.WriteLine("</tr>");
                int cont = 0;
                float total = 0;
                foreach (CAMADAS.MODEL.RegistroCompra registro in lstVenda)
                {
                    sw.WriteLine("<tr align='center'>");
                    sw.WriteLine("<td>");
                    sw.WriteLine(registro.id);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td>");
                    sw.WriteLine(registro.idCliente);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td>");
                    sw.WriteLine(registro.data);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td>");
                    sw.WriteLine(string.Format("{0:C2}", registro.totalPago));
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                    cont++;
                    total+=registro.totalPago;
                }
                sw.WriteLine("</table> <br> <hr>");
                sw.WriteLine("<h2> Quantidade de Vendas: {0}", cont);
                sw.WriteLine("<h2> Valor total de vendas: {0}", string.Format("{0:C2}", total));
                sw.WriteLine("</h2>");
                sw.WriteLine("</BODY>");
                sw.WriteLine("</HTML>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }

        public static void relatorioVendaDetalhada(int registro, int idCliente)
        {
            CAMADAS.BLL.CompraBLL bllCompra = new CAMADAS.BLL.CompraBLL();
            CAMADAS.BLL.ClienteBLL bllCli = new CAMADAS.BLL.ClienteBLL();
            List<CAMADAS.MODEL.Compra> lstVendaD = new List<CAMADAS.MODEL.Compra>();

            CAMADAS.MODEL.RegistroCompra registroCompra = bllCompra.SelectRegistroCompraById(registro)[0];
            lstVendaD = bllCompra.SelectComprasRealizadasByIdRegistro(registro);
            CAMADAS.MODEL.Cliente cliente = bllCli.SelectById(idCliente)[0];
            
            string pasta = Funcoes.diretorioPasta();
            string arquivo = pasta + @"\RelatoriosVendaDetalhada-" + registro + ".html";
            StreamWriter sw = new StreamWriter(arquivo);
            using (sw)
            {
                sw.WriteLine("<!DOCTYPE html>");
                sw.WriteLine("<HTML lang = 'pt - br'>");
                sw.WriteLine("<HEAD>");
                sw.WriteLine("<META http-equiv = 'Content-Type' content='text/css; text='text/css' charset=utf-8'/");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");
                sw.WriteLine("<title> Relatorio de Vendas </title>");
                sw.WriteLine("</HEAD>");
                sw.WriteLine("<BODY>");
                sw.WriteLine("<h1> Relatorio de Venda, " + registroCompra.data.ToString() + "</h1> <hr> <br>");
                sw.WriteLine("<h1> Cliente: " + cliente.nome +"</h1> <hr> <br>");
                sw.WriteLine("<table class='table table-striped' width=100% border='2px' align='center'>");
                sw.WriteLine("<tr>");
                sw.WriteLine("<th> ID </th>");
                sw.WriteLine("<th> ID-PRODUTO </th>");
                sw.WriteLine("<th> QUANTIDADE </th>");
                sw.WriteLine("<th> TOTAL </th>");
                sw.WriteLine("</tr>");
                int cont = 0;
                foreach (CAMADAS.MODEL.Compra compra in lstVendaD)
                {
                    sw.WriteLine("<tr align='center'>");
                    sw.WriteLine("<td>");
                    sw.WriteLine(compra.id);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td>");
                    sw.WriteLine(compra.idProduto);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td>");
                    sw.WriteLine(compra.quantidade);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td>");
                    sw.WriteLine(string.Format("{0:C2}", compra.total));
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                    cont++;
                }
                sw.WriteLine("</table> <br> <hr>");
                sw.WriteLine("<h2> Quantidade de Vendas: {0}", cont);
                sw.WriteLine("<h2> Valor total da venda: {0}", string.Format("{0:C2}", registroCompra.totalPago));
                sw.WriteLine("</h2>");
                sw.WriteLine("</BODY>");
                sw.WriteLine("</HTML>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
