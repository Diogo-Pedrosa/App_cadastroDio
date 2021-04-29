using System;
using System.Collections.Generic;
using App_cadastro.interfaces;
namespace App_cadastro.classes
{
    public class SerieRepositorio : Irepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        private List<Filmes> listaFilmes = new List<Filmes>();

        
        public void Atualiza(int id, Serie entidade)
        {
            listaSerie[id]= entidade;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade);
        }

        public void InsereFilme(Filmes entidade)
        {
            listaFilmes.Add(entidade);
        }

        public List<Serie> Lista()
        {
           return  listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }

        Serie Irepositorio<Serie>.RetornaPorId2(int id)
        {
            throw new NotImplementedException();
        }

        public class FilmesRepositorio : Irepositorio<Filmes>
    {
        private List<Filmes> listaFilmes = new List<Filmes>();
        public void Atualiza(int Id2, Filmes entidade)
        {
            listaFilmes[Id2]= entidade;
        }

        public void Exclui(int id2)
        {
            listaFilmes[id2].Excluir();
        }

            public void Insere(Filmes entidade)
            {
                listaFilmes.Add(entidade);
            }

            public void InsereFilme(Filmes entidade)
            {
                listaFilmes.Add(entidade);
            }

            public List<Filmes> Lista()
        {
           return  listaFilmes;
        }

        public int ProximoId()
        {
            return listaFilmes.Count;
        }

            public Filmes RetornaPorId(int id)
            {
                throw new NotImplementedException();
            }

            public Filmes RetornaPorId2(int Id2)
            {
               return listaFilmes[Id2];
            }
        }
}
}