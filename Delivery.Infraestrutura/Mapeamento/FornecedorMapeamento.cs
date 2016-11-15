using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Delivery.Dominio;

namespace Delivery.Infraestrutura.Mapeamento
{
    class FornecedorMapeamento : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorMapeamento()
        {
            this.ToTable("Fornecedores");
            this.HasKey(f => f.Id);
            this.Property(f => f.Id).HasColumnName("ID_FORNECEDOR").IsRequired();
            this.Property(f => f.NomeFantasia).HasColumnName("NOME_FANTASIA_FORNECEDOR");
            this.Property(f => f.RazaoSocial).HasColumnName("RAZAO_SOCIAL_FORNECEDOR");
        }
    }
}
