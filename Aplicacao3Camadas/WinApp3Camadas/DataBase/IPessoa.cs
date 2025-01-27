using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public interface IPessoa
    {
        string GetNome();
        string GetTelefone();
        string GetCpf();
        void SetNome(string nome);
        void SetTelefone(string telefone);
        void SetCpf(string cpf);
        void Gravar();
    }
}
