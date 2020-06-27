using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Thay_and_Lusca.Relatórios
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
                sw.WriteLine("<title> Relatório de Funcionários </title>");
                sw.WriteLine("</HEAD>");
                sw.WriteLine("<BODY>");
                sw.WriteLine("<h1> Relatório de Funcionários </h1> <hr> <br>");
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
                sw.WriteLine("<title> Relatório de Clientes </title>");
                sw.WriteLine("</HEAD>");
                sw.WriteLine("<BODY>");
                sw.WriteLine("<h1> Relatório de Clientes </h1> <hr> <br>");
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
                    sw.WriteLine(cliente.saldo);
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

        }
    }
}
