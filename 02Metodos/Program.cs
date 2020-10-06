using System;

namespace _02Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.apresentar();
            pessoa.apresentar("Alessandro");
            pessoa.apresentar("Alessandro", 43);
        }
    }
}
