using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Dominio;
using Delivery.Infraestrutura.Contexto;

namespace Delivery.Infraestrutura.Repositorio
{
    class FornecedorRepositorio
    {
        public Fornecedor Buscar(int id)
        {
            using (var ctx = new DeliveryContexto())
            {
                Fornecedor f = ctx.Fornecedores.Find(id);
                return f;
            }
        }

        public void Cadastrar(Fornecedor f)
        {
            using (var ctx = new DeliveryContexto())
            {
                ctx.Fornecedores.Add(f);
                ctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (var ctx = new DeliveryContexto())
            {
                Fornecedor f = ctx.Fornecedores.Find(id);
                ctx.Fornecedores.Remove(f);
                ctx.SaveChanges();
            }
        }

        public void Modificar(Fornecedor fornecedorNovo)
        {
            using (var ctx = new DeliveryContexto())
            {
                Fornecedor fornecedorAntigo = ctx.Fornecedores.Find(fornecedorNovo.Id);
                fornecedorAntigo = fornecedorNovo;
                ctx.SaveChanges();
            }
        }
    }
}
