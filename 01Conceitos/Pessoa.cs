using System;

public class Pessoa 
{
    public string nome;
    public int idade;
    public void mensagem()
    {
        Console.WriteLine("Olá "+nome+" você tem "+idade+" anos.");
    }
}