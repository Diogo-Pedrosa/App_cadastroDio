using System;
namespace App_cadastro.classes
{
    public class Filmes : EntidadeBase
    {
        public Filmes(Genero genero, string titulo, int ano, bool excluido) 
        {
            this.Genero = genero;
                this.Titulo = titulo;
                this.Ano = ano;
                this.Excluido = excluido;
               
        }
                private Genero Genero { get; set; }

        
        private string Titulo { get; set; }
        private int Ano { get; set; }
        private string Descriçao { get; set; }
        private bool Excluido {get;set;}

         public Filmes(string titulo, int ano, int Id2,Genero genero , string descriçao)
        {
            this.Titulo = titulo;
            this.Ano = ano;
            this.Genero = genero;
            this.Descriçao = Descriçao;
            this.Id2 = Id2;
            this.Excluido= false;

        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Ano de incio: " + this.Ano;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descriçao: " + this.Descriçao + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        
        public int retornaId2()
        {
            return this.Id2;
        }
        public void Excluir() {
            this.Excluido = true;
        }
        public bool RetornaExcluido(){
            return this.Excluido;
        }
    }    
}       

    
    