using System;

class Gerente : Imposto
{
    public override void valeAlimentação(double salario)
    {
        Console.WriteLine("Desconto Gerente de VA R$ " + (salario * 0.15));
    }
}