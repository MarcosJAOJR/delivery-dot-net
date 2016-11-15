using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Dominio
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sabor { get; set; }
        public int CodigoTipo { get; set; }
        public int Idade { get; set; }
        public decimal TeorAlcoolico { get; set; }
        public int Volume { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal PrecoPromocional { get; set; }
        public int CodigoFabricante { get; set; }
        public long CodigoBarra { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}
