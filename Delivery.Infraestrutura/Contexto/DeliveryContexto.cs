using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Dominio;
using Delivery.Dominio.Financeiro;
using Delivery.Infraestrutura.Mapeamento;
using Delivery.Infraestrutura.Mapeamento.Financeiro;

namespace Delivery.Infraestrutura.Contexto
{
    class DeliveryContexto : DbContext
    {
        public DeliveryContexto() : base("Server=PC-MARCOSJOSÉ\\SQLEXPRESS;Database=Delivery_BD;Trusted_Connection=True;") { }

        public DbSet<TipoProduto> Tipos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DeliveryContexto>(null);

            modelBuilder.Configurations.Add(new TipoProdutoMapeamento());
            modelBuilder.Configurations.Add(new FornecedorMapeamento());
            modelBuilder.Configurations.Add(new FabricanteMapeamento());
            modelBuilder.Configurations.Add(new ClienteMapeamento());
            modelBuilder.Configurations.Add(new FuncionarioMapeamento());
            modelBuilder.Configurations.Add(new ProdutoMapeamento());
            modelBuilder.Configurations.Add(new CompraMapeamento());
            modelBuilder.Configurations.Add(new VendaMapeamento());

            base.OnModelCreating(modelBuilder);
        }
    }
}
