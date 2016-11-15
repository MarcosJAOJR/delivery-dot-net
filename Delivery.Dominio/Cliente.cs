using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string email { get; set; }
        public long Telefone { get; set; }
        public long Celular { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string UsuarioLogin { get; set; }
        public string UsuarioSenha { get; set; }
    }
}
