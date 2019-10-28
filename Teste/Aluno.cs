using System;

namespace Teste{
    class Aluno : Pessoa{
        private string curso;

        public Aluno(string n, int i, string c) : base(n,i){
            this.curso = c;
        }

        override protected string Trabalhar(){
            return "Estudando...";
        }

        public string Curso{
            get{
                return curso;
            }
            set{
                this.curso = value;                
            }
        }

    }
    
}