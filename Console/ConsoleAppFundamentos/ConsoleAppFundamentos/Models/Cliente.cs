using ConsoleAppFundamentos.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFundamentos.Models
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public bool IsAtivo
        {
            get
            {
                return this.IsAtivo;
            }
            set
            {
                value = true;
            }
        }
        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Cliente() { }
        
        /// <summary>
        /// Construtor principal
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="cpf"></param>
        public Cliente(string nome, string telefone, string cpf)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Telefone = telefone ?? throw new ArgumentNullException(nameof(telefone));
            Cpf = cpf ?? throw new ArgumentNullException(nameof(cpf));
        }

    }
}
