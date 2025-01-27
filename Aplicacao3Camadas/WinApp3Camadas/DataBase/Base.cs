using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public abstract class Base
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }

        private string CaminhoBase()
        {
            string nameBase = (this.GetType().Name.Equals("Cliente")) ? "clientes" : "usuarios";
            //return "C:\\workspace\\Torneseumprogramador\\Console\\" + nameBase + ".txt";
            return ConfigurationManager.AppSettings["base"] + nameBase + ".txt";
        }
        public void Gravar()
        {
            string linha = $"{this.Nome};{this.Telefone};{this.Cpf};";

            string path = CaminhoBase();

            List<string> linhas = File.ReadAllLines(path).ToList();
            linhas.Add(linha);

            File.WriteAllLines(path, linhas);
        }
        public List<IPessoa> Ler()
        {
            string path = CaminhoBase();
            var baseClientes = new List<IPessoa>();

            if (File.Exists(path))
            {
                using (var arquivo = File.OpenText(path))
                {
                    string linha;
                    int contador = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        //Console.WriteLine(linha);
                        if (contador != 0)
                        {
                            var lerArray = linha.Split(';');
                            var b = (IPessoa)Activator.CreateInstance(this.GetType()); //instancia generica
                            b.SetNome(lerArray[0]);
                            b.SetTelefone(lerArray[1]);
                            b.SetCpf(lerArray[2]);
                            baseClientes.Add(b);
                        }

                        contador++;
                    }
                }
            }
            else
            {
                Console.WriteLine($"Arquivo {path} não foi encontrado");
            }

            return baseClientes;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public void SetTelefone(string telefone)
        {
            this.Telefone = telefone;
        }

        public void SetCpf(string cpf)
        {
            this.Cpf = cpf;
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public string GetTelefone()
        {
            return this.Telefone;
        }

        public string GetCpf()
        {
            return this.Cpf;
        }
    }
}
