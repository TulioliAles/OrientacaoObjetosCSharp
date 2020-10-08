using System;

class Imposto
{
    public virtual void valeAlimentação(double salario)
    {
        Console.WriteLine("Desconto Padrão de VA R$ " + (salario * 0.1));
    }

    public virtual void valeTransporte(double salario)
    {
        Console.WriteLine("Desconto Padrão de VT R$ " + (salario * 0.06));
    }
}