using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Dominio.Financeiro;

namespace Delivery.Infraestrutura.Mapeamento.Financeiro
{
    class CompraMapeamento : EntityTypeConfiguration<Compra>
    {
        public CompraMapeamento()
        {
            this.ToTable("FIN_compras");
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasColumnName("ID_COMPRA").IsRequired();
            this.Property(c => c.IdFuncionario).HasColumnName("ID_FUNCIONARIO");
            this.Property(c => c.IdProduto).HasColumnName("ID_PRODUTO");
            this.Property(c => c.QuantidadeComprada).HasColumnName("QUANTIDADE_COMPRADA");
            this.Property(c => c.NumeroNotaFiscal).HasColumnName("NUMERO_NOTA_FISCAL");
            this.Property(c => c.CodigoFornecedor).HasColumnName("COD_FORNECEDOR");
            this.Property(c => c.DataCompra).HasColumnName("DATA_COMPRA");
        }
    }
}
