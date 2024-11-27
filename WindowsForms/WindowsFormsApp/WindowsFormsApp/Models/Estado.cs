using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Models
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Estado() { }
        public Estado(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public static List<Estado> BuscarEstados()
        {
            List<Estado> estados = new List<Estado>();
            estados.Add(new Estado(1, "São Paulo"));
            estados.Add(new Estado(1,"Rio de Janeiro"));
            estados.Add(new Estado(1, "Minas Gerais"));
            estados.Add(new Estado(1,"Bahia"));

            return estados;
        }
        public override string ToString()
        {
            return this.Nome;
        }
    }
}
