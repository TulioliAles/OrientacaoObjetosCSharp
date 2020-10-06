using System;

class Pessoa
{
    public double peso, altura;

    public double calcularImc()
    {
        return peso / (altura * altura);
    }

    public string situação(double imc)
    {
        string msg;
        if(imc <= 18.5)
        {
            msg ="Abaixo do peso";
        }
        else if(imc > 18.5 && imc <= 25)
        {
            msg = "Peso normal";
        }
        else if(imc > 25 && imc <= 30)
        {
            msg = "Acima do peso";
        }
        else if(imc > 30 && imc <= 35)
        {
            msg = "Obesidade I";
        }
        else if(imc > 35 && imc <= 40)
        {
            msg = "Obesidade II";
        }
        else
        {
            msg = "Obesidade III";
        }

        return msg;

    }

    public void mensagem()
    {
        double obterImc = calcularImc();

        string obterSituacao = situação(obterImc);

        Console.WriteLine("IMC: "+obterImc);
        Console.WriteLine("Situação: "+obterSituacao);
    }
}