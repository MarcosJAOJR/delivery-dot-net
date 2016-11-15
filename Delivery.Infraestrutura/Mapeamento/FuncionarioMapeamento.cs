using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Delivery.Dominio;

namespace Delivery.Infraestrutura.Mapeamento
{
    class FuncionarioMapeamento : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioMapeamento()
        {
            this.ToTable("FIN_compras");
            this.HasKey(f => f.Id);
            this.Property(f => f.Id).HasColumnName("ID_FUNCIONARIO").IsRequired();
            this.Property(f => f.Nome).HasColumnName("NOME_FUNCIONARIO");
            this.Property(f => f.Email).HasColumnName("EMAIL_FUNCIONARIO");
            this.Property(f => f.Telefone).HasColumnName("TELEFONE_CLIENTE");
            this.Property(f => f.Celular).HasColumnName("CELULAR_CLIENTE");
            this.Property(f => f.CPF).HasColumnName("CPF_FUNCIONARIO");
            this.Property(f => f.DataNascimento).HasColumnName("NASCIMENTO_CLIENTE");
            this.Property(f => f.Cargo).HasColumnName("CARGO");
            this.Property(f => f.UsuarioLogin).HasColumnName("USUARIO_LOGIN");
            this.Property(f => f.UsuarioSenha).HasColumnName("USUARIO_SENHA");
            this.Property(f => f.TipodeGanho).HasColumnName("TIPO_DE_GANHO");
        }
    }
}
