using System;

class Atendente : Imposto
{
    public override void valeAlimentação(double salario)
    {
        Console.WriteLine("Desconto Atendente de VA R$ " + (salario * 0.12));
    }
}