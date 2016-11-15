using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Infraestrutura.Contexto;
using Delivery.Dominio;

namespace Delivery.Infraestrutura.Repositorio
{
    class ClienteRepositorio
    {
        public Cliente Buscar(int id)
        {
            using (var ctx = new DeliveryContexto())
            {
                Cliente c = ctx.Clientes.Find(id);
                return c;
            }
        }

        public void Cadastrar(Cliente c)
        {
            using (var ctx = new DeliveryContexto())
            {
                ctx.Clientes.Add(c);
                ctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (var ctx = new DeliveryContexto())
            {
                Cliente c = ctx.Clientes.Find(id);
                ctx.Clientes.Remove(c);
                ctx.SaveChanges();
            }
        }

        public void Modificar(Cliente clienteNovo)
        {
            using (var ctx = new DeliveryContexto())
            {
                Cliente cAntigo = ctx.Clientes.Find(clienteNovo.Id);
                cAntigo = clienteNovo;
                ctx.SaveChanges();
            }
        }
    }
}
