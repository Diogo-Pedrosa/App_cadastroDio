using System;

namespace App_cadastro
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }

        
        private string Titulo { get; set; }
        private int Ano { get; set; }
        private string Descriçao { get; set; }
        private bool Excluido {get;set;}

         public Serie(string titulo, int ano, int id,Genero genero , string descriçao)
        {
            this.Titulo = titulo;
            this.Ano = ano;
            this.Genero = genero;
            this.Descriçao = Descriçao;
            this.Id = Id;
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
        public int retornaId()
        {
            return this.Id;
        }
        public void Excluir() {
            this.Excluido = true;
        }
        public bool RetornaExcluido(){
            return this.Excluido;
        }

    

    

}
}