using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Models
{
    public class Cliente
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public Cliente() { }
        public Cliente(long id, string nome, string cpf, string telefone, string celular)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Celular = celular;
        }
        public static List<Cliente> ListaDeClientes()
        {
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente(1, "João", "23131313", "1499999999","1144443333"));
            clientes.Add(new Cliente(2, "Maria", "23131313", "1499999999", "1144443333"));
            clientes.Add(new Cliente(3, "Ana", "23131313", "1499999999", "1144443333"));
            clientes.Add(new Cliente(4, "Guilherme", "23131313", "1499999999", "1144443333"));
            clientes.Add(new Cliente(5, "Carlos", "23131313", "1499999999", "1144443333"));

            return clientes;
        }
    }
}
