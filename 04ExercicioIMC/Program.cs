using System;

namespace _04ExercicioIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.peso = 87;
            pessoa.altura = 1.77;
            pessoa.mensagem();
        }
    }
}
