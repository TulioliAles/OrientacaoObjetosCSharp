using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "Alessandro";
            p1.idade = 43;
            p1.mensagem();
        }
    }
}
