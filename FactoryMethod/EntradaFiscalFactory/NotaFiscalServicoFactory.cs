
using FabricaDeCartoes.Interfaces;
using FactoryMethod.Produto;
using FactoryMethod.ProdutosConcretos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Prod_Factory
{
    public class NotaFiscalServicoFactory : InotaFiscalFactory
    {
        public IEntradaNotaFiscal BuscaNotaFiscalRecebimento()
        {
            return new NotaFiscalServico();
        }
    }
}
