using System;

class Pessoa
{
    private string nome = "Thiago";

    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}