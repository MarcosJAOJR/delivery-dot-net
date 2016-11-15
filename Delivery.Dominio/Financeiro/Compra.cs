using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Dominio.Financeiro
{
    public class Compra
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int IdFuncionario { get; set; }
        public int QuantidadeComprada { get; set; }
        public long NumeroNotaFiscal { get; set; }
        public DateTime? DataCompra { get; set; }
        public int CodigoFornecedor { get; set; }
    }
}
