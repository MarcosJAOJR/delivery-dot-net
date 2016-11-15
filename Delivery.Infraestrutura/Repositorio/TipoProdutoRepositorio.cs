using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Dominio;
using Delivery.Infraestrutura.Contexto;

namespace Delivery.Infraestrutura.Repositorio
{
    class TipoProdutoRepositorio
    {
        public TipoProduto Buscar(int id)
        {
            using (var ctx = new DeliveryContexto())
            {
                TipoProduto t = ctx.Tipos.Find(id);
                return t;
            }
        }

        public void Cadastrar(TipoProduto tipo)
        {
            using (var ctx = new DeliveryContexto())
            {
                ctx.Tipos.Add(tipo);
                ctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (var ctx = new DeliveryContexto())
            {
                TipoProduto tipo = ctx.Tipos.Find(id);
                ctx.Tipos.Remove(tipo);
                ctx.SaveChanges();
            }
        }

        public void Modificar(TipoProduto tipoNovo)
        {
            using (var ctx = new DeliveryContexto())
            {
                TipoProduto tipoAntigo = ctx.Tipos.Find(tipoNovo.Id);
                tipoAntigo = tipoNovo;
                ctx.SaveChanges();
            }
        }
    }
}
