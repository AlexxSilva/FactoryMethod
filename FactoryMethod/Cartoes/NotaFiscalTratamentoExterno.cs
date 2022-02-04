using FactoryMethod.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.ProdutosConcretos
{
    public class NotaFiscalTratamentoExterno : IEntradaNotaFiscal
    {

        private string _tipoNotaFiscal;
        public string TipoNotaFiscal
        {
            get { return _tipoNotaFiscal; }
        }

        private string _notaFiscal;
        public string NotaFiscal
        {
            get { return _notaFiscal; }
            set { _notaFiscal = value; }
        }

        private string _fornecedor;
        public string Fornecedor
        {
            get { return _fornecedor; }
            set { _fornecedor = value; }
        }

        private Decimal _valorTotal;
        public Decimal ValorTotal
        {
            get { return _valorTotal; }
            set { _valorTotal = value; }
        }


        public NotaFiscalTratamentoExterno()
        {
            this._tipoNotaFiscal = "Nota Fiscal de Serviço";
            this._notaFiscal = "10";
            this._fornecedor = "IBM";
            this._valorTotal = 1000;
        }

    }
}
