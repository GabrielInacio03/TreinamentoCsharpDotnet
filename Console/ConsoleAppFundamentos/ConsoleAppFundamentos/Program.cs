using ConsoleAppFundamentos.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppFundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu.MenuDeOpcoes();
            Email.Instancia.Corpo = "blalbalala";
            Email.Instancia.Titulo = "TESTEE";
            Email.Instancia.Origin = "tornseseumprogramador";
            Email.Instancia.Destino = "teste";
            Email.Instancia.Send();
        }
    }
}
