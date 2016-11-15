using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Delivery.Dominio;

namespace Delivery.Infraestrutura.Mapeamento
{
    class FabricanteMapeamento : EntityTypeConfiguration<Fabricante>
    {
        public FabricanteMapeamento()
        {
            this.ToTable("Fabricantes");
            this.HasKey(f => f.Id);
            this.Property(f => f.Id).HasColumnName("ID_FABRICANTE").IsRequired();
            this.Property(f => f.NomeFantasia).HasColumnName("NOME_FANTASIA_FABRICANTE");
            this.Property(f => f.RazaoSocial).HasColumnName("RAZAO_SOCIAL_FABRICANTE");
            this.Property(f => f.Pais).HasColumnName("PAIS_FABRICANTE");
        }
    }
}
