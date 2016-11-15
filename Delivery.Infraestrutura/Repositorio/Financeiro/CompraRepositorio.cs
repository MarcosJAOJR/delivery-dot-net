using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Dominio.Financeiro;
using Delivery.Dominio;
using Delivery.Infraestrutura.Contexto;

namespace Delivery.Infraestrutura.Repositorio.Financeiro
{
    class CompraRepositorio
    {
        public Compra Buscar(int id)
        {
            using (var ctx = new DeliveryContexto())
            {
                Compra c = ctx.Compras.Find(id);
                return c;
            }
        }

        public void Cadastrar(Compra c)
        {
            using (var ctx = new DeliveryContexto())
            {
                ctx.Compras.Add(c);

                Produto p = ctx.Produtos.Find(c.IdProduto);
                p.QuantidadeEstoque = p.QuantidadeEstoque + c.QuantidadeComprada;

                ProdutoRepositorio pr = new ProdutoRepositorio();
                pr.Modificar(p);

                ctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (var ctx = new DeliveryContexto())
            {
                Compra c = ctx.Compras.Find(id);
                ctx.Compras.Remove(c);

                Produto p = ctx.Produtos.Find(c.IdProduto);
                p.QuantidadeEstoque = p.QuantidadeEstoque - c.QuantidadeComprada;

                ProdutoRepositorio pr = new ProdutoRepositorio();
                pr.Modificar(p);

                ctx.SaveChanges();
            }
        }
    }
}
