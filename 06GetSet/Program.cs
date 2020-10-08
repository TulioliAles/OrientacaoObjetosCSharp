using System;

namespace _06GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Alessandro";

            Console.WriteLine(p.Nome);
        }
    }
}
