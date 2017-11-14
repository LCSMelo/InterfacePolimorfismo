using System;
using ClasseInterface;

namespace exemplo_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco endereco = new Endereco();
            endereco.Logradouro = "Rua Nova Esperança";
            endereco.Numero = "56";
            endereco.Bairro = "Jardim Alegria";

            PF pf = new PF(10, "Helena", "123456", "helena.santa@uol.com.br", "456123", endereco);

            Console.WriteLine(pf.Cadastro());            
        }
    }
}
