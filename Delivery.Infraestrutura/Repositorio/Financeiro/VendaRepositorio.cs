using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Infraestrutura.Contexto;
using Delivery.Dominio.Financeiro;
using Delivery.Dominio;

namespace Delivery.Infraestrutura.Repositorio.Financeiro
{
    class VendaRepositorio
    {
        public Venda Buscar(int id)
        {
            using (var ctx = new DeliveryContexto())
            {
                Venda v = ctx.Vendas.Find(id);
                return v;
            }
        }

        public void Cadastrar(Venda v)
        {
            using (var ctx = new DeliveryContexto())
            {
                ctx.Vendas.Add(v);
                
                Produto p = ctx.Produtos.Find(v.IdProduto);
                p.QuantidadeEstoque = p.QuantidadeEstoque - v.QuantidadeVendida;
                
                ProdutoRepositorio pr = new ProdutoRepositorio();
                pr.Modificar(p);
                
                ctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (var ctx = new DeliveryContexto())
            {
                Venda v = ctx.Vendas.Find(id);
                ctx.Vendas.Remove(v);

                Produto p = ctx.Produtos.Find(v.IdProduto);
                p.QuantidadeEstoque = p.QuantidadeEstoque + v.QuantidadeVendida;

                ProdutoRepositorio pr = new ProdutoRepositorio();
                pr.Modificar(p);

                ctx.SaveChanges();
            }
        }
    }
}
