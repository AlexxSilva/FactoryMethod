using FactoryMethod.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FabricaDeCartoes.Interfaces
{
    public interface InotaFiscalFactory
    {
         IEntradaNotaFiscal BuscaNotaFiscalRecebimento();
    }
}
