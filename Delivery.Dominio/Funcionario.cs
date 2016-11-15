using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Dominio
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public long Telefone { get; set; }
        public long Celular { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string TipodeGanho { get; set; }
        public string Cargo { get; set; }
        public string UsuarioLogin { get; set; }
        public string UsuarioSenha { get; set; }
    }
}
