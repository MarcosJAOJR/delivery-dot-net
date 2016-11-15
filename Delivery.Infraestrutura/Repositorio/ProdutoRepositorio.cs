using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Infraestrutura.Contexto;
using Delivery.Dominio;

namespace Delivery.Infraestrutura.Repositorio
{
    class ProdutoRepositorio
    {
        public Produto Buscar(int id)
        {
            using (var ctx = new DeliveryContexto())
            {
                Produto p = ctx.Produtos.Find(id);
                return p;
            }
        }

        public void Cadastrar(Produto p)
        {
            using (var ctx = new DeliveryContexto())
            {
                ctx.Produtos.Add(p);
                ctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (var ctx = new DeliveryContexto())
            {
                Produto p = ctx.Produtos.Find(id);
                ctx.Produtos.Remove(p);
                ctx.SaveChanges();
            }
        }

        public void Modificar(Produto pNovo)
        {
            using(var ctx = new DeliveryContexto())
            {
                Produto pAntigo = ctx.Produtos.Find(pNovo.Id);
                pAntigo = pNovo;
                ctx.SaveChanges();
            }
        }
    }
}
