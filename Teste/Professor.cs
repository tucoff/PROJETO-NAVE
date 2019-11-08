using System;

namespace Teste{
    class Professor : Pessoa{
        private string disciplina;

        public Professor(string n, int i, string d) : base(n,i){
            this.disciplina = d;
        }

        override protected string Trabalhar(){
            return "Ensinando...";
        }

        public string Disciplina{
            get{
                return disciplina;
            }
            set{
                this.disciplina = value;
            }
        }
    }
}
