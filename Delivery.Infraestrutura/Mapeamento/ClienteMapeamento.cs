using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Delivery.Dominio;

namespace Delivery.Infraestrutura.Mapeamento
{
    class ClienteMapeamento : EntityTypeConfiguration<Cliente>
    {
        public ClienteMapeamento()
        {
            this.ToTable("Clientes");
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasColumnName("ID_CLIENTE").IsRequired();
            this.Property(c => c.Nome).HasColumnName("NOME_CLIENTE");
            this.Property(c => c.Telefone).HasColumnName("TELEFONE_CLIENTE");
            this.Property(c => c.Celular).HasColumnName("CELULAR_CLIENTE");
            this.Property(c => c.CEP).HasColumnName("CEP_CLIENTE");
            this.Property(c => c.Endereco).HasColumnName("ENDERECO_CLIENTE");
            this.Property(c => c.Complemento).HasColumnName("COMPLEMENTO_CLIENTE");
            this.Property(c => c.email).HasColumnName("EMAIL_CLIENTE");
            this.Property(c => c.DataNascimento).HasColumnName("NASCIMENTO_CLIENTE");
            this.Property(c => c.UsuarioLogin).HasColumnName("USUARIO_LOGIN");
            this.Property(c => c.UsuarioSenha).HasColumnName("USUARIO_SENHA");
        }
    }
}
