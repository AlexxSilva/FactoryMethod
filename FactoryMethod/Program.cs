
using FabricaDeCartoes.Interfaces;
using FactoryMethod.Prod_Factory;
using FactoryMethod.Produto;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            InotaFiscalFactory notafactory = null;
            Console.Write("Digite o tipo de nota fiscal:");
            string console = Console.ReadLine();

            switch (console.ToLower())
            {
                case "compra":
                    notafactory = new NotaFiscalCompraFactory();
                    break;
                case "serviço":
                    notafactory = new NotaFiscalTratamentoExternoFactory();
                    break;
                case "tratamento":
                    notafactory = new NotaFiscalServicoFactory();
                    break;
                default:
                    break;
            }

            IEntradaNotaFiscal nf = notafactory.BuscaNotaFiscalRecebimento();
            Console.Write("\nOs detalhes do seu cartão estão abaixo:\n");

            Console.Write("Nota Fiscal:{0} \n Tipo : {1} \n Valor R$: {2} \n Fornecedor: {3} \n",
                nf.NotaFiscal, nf.TipoNotaFiscal, nf.ValorTotal , nf.Fornecedor);
        }
    }
}
