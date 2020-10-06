using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            aluno.nome = "Alessandro";
            aluno.nota1 = 9.5;
            aluno.nota2= 10;
            aluno.mensagem();
        }
    }
}
