using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Dominio.Financeiro
{
    public class Venda
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdProduto { get; set; }
        public int IdEntregador { get; set; }
        public int QuantidadeVendida { get; set; }
        public DateTime? DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public string FormaPagamento { get; set; }
        public string Status { get; set; }
    }
}
