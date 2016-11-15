using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Delivery.Infraestrutura.Mapeamento
{
    class ProdutoMapeamento : EntityTypeConfiguration<Produto>
    {
        public ProdutoMapeamento()
        {
            this.ToTable("Produtos");
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasColumnName("ID_PRODUTO").IsRequired();
            this.Property(c => c.Idade).HasColumnName("IDADE");
            this.Property(c => c.Nome).HasColumnName("NOME_PRODUTO");
            this.Property(c => c.Preco).HasColumnName("PRECO");
            this.Property(c => c.PrecoPromocional).HasColumnName("PRECO_PROMOCIONAL");
            this.Property(c => c.QuantidadeEstoque).HasColumnName("QUANTIDADE_ESTOQUE");
            this.Property(c => c.Sabor).HasColumnName("SABOR");
            this.Property(c => c.TeorAlcoolico).HasColumnName("TEOR_ALCOOLICO");
            this.Property(c => c.Volume).HasColumnName("VOLUME_ml");
            this.Property(c => c.CodigoBarra).HasColumnName("CODIGO_DE_BARRA");
            this.Property(c => c.CodigoFabricante).HasColumnName("COD_FABRICANTE");
            this.Property(c => c.CodigoTipo).HasColumnName("COD_TIPO");
            this.Property(c => c.Descricao).HasColumnName("DESCRICAO");
        }
    }
}
