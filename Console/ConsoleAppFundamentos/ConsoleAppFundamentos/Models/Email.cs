using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFundamentos.Models
{
    public class Email
    {
        //atributos
        private static Email _instancia;
        public static Email Instancia 
        {
            get 
            {
                if (_instancia == null)
                    _instancia = new Email();

                return _instancia;
            }
        }
        public string Origin;
        public string Destino;
        public string Titulo;
        public string Corpo;

        private Email() { }

        public  void Send()
        {
            //Envio de email
            Console.WriteLine($"Enviando Email para {Destino} \n com o titulo: {Titulo} \n Corpo: {Corpo}");
        }
    }
}
