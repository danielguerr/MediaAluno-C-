using MediaAluno.classes;
using System;
namespace MediaAluno
{
    class Program
    {
        public static void Main(string[] args)
        {
            Aluno aluno = new Aluno("Daniel", "129387192");
            Console.WriteLine(aluno.calcularMedia(7, 8));
            Console.WriteLine(aluno.avaliaMedia(7.5));
        }
    }
}
