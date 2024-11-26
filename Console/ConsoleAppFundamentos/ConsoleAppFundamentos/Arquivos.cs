using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;

namespace ConsoleAppFundamentos
{
    class Arquivos
    {
        private static string CaminhoArquivo()
        {
            return ConfigurationManager.AppSettings["caminho_arquivos"];
        }
        
        public static void LerArquivos(int numeroArquivo)
        {
            string path = CaminhoArquivo() + "arq";
            Console.WriteLine("Lendo arquivo " + path + numeroArquivo + ".txt");
            if (File.Exists(path + numeroArquivo + ".txt"))
            {
                using (var arquivo = File.OpenText(path + numeroArquivo + ".txt"))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Arquivo {path + +numeroArquivo + ".txt"} não foi encontrado");
            }


            //verificando se o caminho existe
            numeroArquivo += 1;
            if (File.Exists(path + numeroArquivo + ".txt"))
            {
                LerArquivos(numeroArquivo);
            }
            else
            {
                Console.WriteLine($"Arquivo {path + numeroArquivo + ".txt"} não foi encontrado");
            }
        }
    }
}
