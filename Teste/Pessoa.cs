using System;

namespace Teste{
    abstract class Pessoa{
        protected string nome;
        protected int idade;

        public Pessoa(string n, int i){
            this.nome = n;
            this.idade = i;
        }

        abstract protected string Trabalhar();

        public string GetNome(){
            return nome;
        }
        public void SetNome(string n){
            this.nome = n;            
        }
        public int GetIdade (){
            return idade;
        
        }public void SetIdade(int n1){
            this.idade=n1;
        }

        
    }
}