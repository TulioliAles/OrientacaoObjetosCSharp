using System;

namespace _10Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pessoaF = new PessoaFisica();
            pessoaF.taxaEmprestimo(1000);
            pessoaF.calculoPoupanca(1000, 0.1);

            Console.WriteLine("---------------------------");

            PessoaJuridica pessoaJ = new PessoaJuridica();
            pessoaJ.taxaEmprestimo(1000);
        }
    }
}
