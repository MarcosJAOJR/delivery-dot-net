using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Dominio;
using Delivery.Infraestrutura.Contexto;

namespace Delivery.Infraestrutura.Repositorio
{
    class FabricanteRepositorio
    {
        public Fabricante Buscar(int id)
        {
            using (var ctx = new DeliveryContexto())
            {
                Fabricante f = ctx.Fabricantes.Find(id);
                return f;
            }
        }

        public List<Fabricante> BuscarPorPais(string Pais)
        {
            using (var ctx = new DeliveryContexto())
            {
                List<Fabricante> query = ctx.Fabricantes.Where(f => f.Pais.Contains(Pais)).ToList();
                return query;
            }
        }

        public void Cadastrar(Fabricante f)
        {
            using (var ctx = new DeliveryContexto())
            {
                ctx.Fabricantes.Add(f);
                ctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (var ctx = new DeliveryContexto())
            {
                Fabricante f = ctx.Fabricantes.Find(id);
                ctx.Fabricantes.Remove(f);
                ctx.SaveChanges();
            }
        }

        public void Modificar(Fabricante fabricanteNovo)
        {
            using (var ctx = new DeliveryContexto())
            {
                Fabricante fabricanteAntigo = ctx.Fabricantes.Find(fabricanteNovo.Id);
                fabricanteAntigo = fabricanteNovo;
                ctx.SaveChanges();
            }
        }
    }
}
