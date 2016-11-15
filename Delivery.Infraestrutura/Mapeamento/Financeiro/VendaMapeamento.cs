using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Delivery.Dominio.Financeiro;

namespace Delivery.Infraestrutura.Mapeamento.Financeiro
{
    class VendaMapeamento : EntityTypeConfiguration<Venda>
    {
        public VendaMapeamento()
        {
            this.ToTable("FIN_vendas");
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasColumnName("ID_VENDA").IsRequired();
            this.Property(c => c.IdCliente).HasColumnName("ID_CLIENTE");
            this.Property(c => c.IdEntregador).HasColumnName("ID_ENTREGADOR");
            this.Property(c => c.IdProduto).HasColumnName("ID_PRODUTO");
            this.Property(c => c.QuantidadeVendida).HasColumnName("QUANTIDADE_VENDIDA");
            this.Property(c => c.ValorTotal).HasColumnName("VALOR_TOTAL");
            this.Property(c => c.DataVenda).HasColumnName("DATA_VENDA");
            this.Property(c => c.FormaPagamento).HasColumnName("FORMA_DE_PAGAMENTO");
            this.Property(c => c.Status).HasColumnName("STATUS_VENDA");
        }
    }
}
