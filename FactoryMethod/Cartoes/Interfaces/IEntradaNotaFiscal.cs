using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Produto
{
    public interface IEntradaNotaFiscal
    {
        public  string TipoNotaFiscal { get;  }
        public  string NotaFiscal { get; set; }
        public string Fornecedor { get; set; }
        public Decimal ValorTotal { get; set; }
    }
}
