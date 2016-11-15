using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Dominio;
using Delivery.Infraestrutura.Contexto;

namespace Delivery.Infraestrutura.Repositorio
{
    class FuncionarioRepositorio
    {
        public Funcionario Buscar(int id)
        {
            using (var ctx = new DeliveryContexto())
            {
                Funcionario f = ctx.Funcionarios.Find(id);
                return f;
            }
        }

        public void Cadastrar(Funcionario f)
        {
            using (var ctx = new DeliveryContexto())
            {
                ctx.Funcionarios.Add(f);
                ctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (var ctx = new DeliveryContexto())
            {
                Funcionario f = ctx.Funcionarios.Find(id);
                ctx.Funcionarios.Remove(f);
                ctx.SaveChanges();
            }
        }

        public void Modificar(Funcionario funcionarioNovo)
        {
            using (var ctx = new DeliveryContexto())
            {
                Funcionario funcionarioAntigo = ctx.Funcionarios.Find(funcionarioNovo.Id);
                funcionarioAntigo = funcionarioNovo;
                ctx.SaveChanges();
            }
        }
    }
}
