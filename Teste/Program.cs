using System;

namespace Teste{
    class Program{
        static void Main(string[] args){
            Aluno p1 = new Aluno("Predo Deslocado", 15, "Programação de Jogos");
            Professor p2 = new Professor("Erickilson Simoins", 100, "Técnico em Naves");

            Console.WriteLine("Nome: {0}\nIdade: {1}\nCurso: {2}\n", p1.GetNome(), p1.GetIdade(), p1.Curso);
            Console.WriteLine("Nome: {0}\nIdade: {1}\nDisciplina: {2}\n", p2.GetNome(), p2.GetIdade(), p2.Disciplina);
        }
    }
}
