using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Delivery.Dominio;

namespace Delivery.Infraestrutura.Mapeamento
{
    class TipoProdutoMapeamento : EntityTypeConfiguration<TipoProduto>
    {
        public TipoProdutoMapeamento()
        {
            this.ToTable("Tipos");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasColumnName("ID_TIPO").IsRequired();
            this.Property(t => t.Nome).HasColumnName("NOME_TIPO");
            this.Property(t => t.Descricao).HasColumnName("DESCRICAO");
        }

    }
}
