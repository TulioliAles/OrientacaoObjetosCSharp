using System;

namespace _09Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto objE = new Estagiario();
            objE.valeAlimentação(1000);
            objE.valeTransporte(1000);

            Console.WriteLine("---------------------");

            Imposto objA = new Atendente();
            objA.valeAlimentação(2000);
            objA.valeTransporte(2000);

            Console.WriteLine("---------------------");

            Imposto objG = new Gerente();
            objG.valeAlimentação(5000);
            objG.valeTransporte(5000);
        }
    }
}
