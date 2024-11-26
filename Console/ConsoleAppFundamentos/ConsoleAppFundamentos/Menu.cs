using ConsoleAppFundamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFundamentos
{
    class Menu
    {
        public const int OPCAO_SAIR = 0;
        public const int OPCAO_TABUADA = 1;
        public const int OPCAO_LERARQUIVOS = 2;
        public const int OPCAO_LERBASECLIENTES = 3;
        public const int OPCAO_GRAVARCLIENTE = 4;
        public const int OPCAO_LERBASEUSUARIOS = 5;
        public const int OPCAO_GRAVARUSUARIO = 6;
        public static void MenuDeOpcoes()
        {
            string msgMenu = "=================================" +
                "\nCurso Linguagem de Programação C#" +
                "\n=================================" +
                "\nMenu de Opções:" +
                $"\n {OPCAO_SAIR} - Sair do Programa" +
                $"\n {OPCAO_TABUADA} - Tabuada" +
                $"\n {OPCAO_LERARQUIVOS} - Ler Arquivos" +
                $"\n {OPCAO_LERBASECLIENTES} - Ler Base Clientes" +
                $"\n {OPCAO_GRAVARCLIENTE} - Gravar Cliente" +
                $"\n {OPCAO_LERBASEUSUARIOS} - Ler Base Usuarios" +
                $"\n {OPCAO_GRAVARUSUARIO} - Gravar Usuário";

            while (true)
            {
                Console.WriteLine(msgMenu);

                int valor = int.Parse(Console.ReadLine());

                if (valor == OPCAO_SAIR)
                {
                    Console.WriteLine("Saindo do programa!");
                    break;
                }
                if (valor == OPCAO_TABUADA)
                {
                    Tabuada.TabuadaCompleta(5);
                }
                if (valor == OPCAO_LERARQUIVOS)
                {
                    Arquivos.LerArquivos(1);
                }
                if(valor == OPCAO_LERBASECLIENTES)
                {
                    
                    foreach (var item in new Cliente().Ler())
                    {
                        Console.WriteLine($"{item.GetNome()};{item.GetTelefone()};{item.GetCpf()};");
                    }

                }
                if(valor == OPCAO_GRAVARCLIENTE)
                {
                    Cliente cliente = new Cliente();

                    Console.WriteLine("Digite o nome do cliente: ");
                    cliente.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do cliente: ");
                    cliente.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o cpf do cliente");
                    cliente.Cpf = Console.ReadLine();

                    cliente.Gravar();
                }
                if (valor == OPCAO_LERBASEUSUARIOS)
                {
                    
                    foreach (var item in new Usuario().Ler())
                    {
                        Console.WriteLine($"{item.GetNome()};{item.GetTelefone()};{item.GetCpf()};");
                    }

                }
                if (valor == OPCAO_GRAVARUSUARIO)
                {
                    Usuario usuario = new Usuario();

                    Console.WriteLine("Digite o nome do usuario: ");
                    usuario.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do usuario: ");
                    usuario.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o cpf do usuario");
                    usuario.Cpf = Console.ReadLine();

                    usuario.Gravar();
                }
            }
        }
    }
}
