using System;
using App_cadastro;
using App_cadastro.classes;
using App_cadastro.interfaces;
using static App_cadastro.classes.SerieRepositorio;
using static App_cadastro.classes.Filmes;



namespace App_cadastro
{
    public static class metodosfilmes
    {


        static SerieRepositorio repositorio = new SerieRepositorio();        
        static FilmesRepositorio repositorio2 = new FilmesRepositorio();
          public static void VisualizarFilme()
        {
            Console.Write("Digite o id do Filme: ");
            int indiceFilmes = int.Parse(Console.ReadLine());

            var serie = repositorio2.RetornaPorId2(indiceFilmes);

            Console.WriteLine(serie);
        }

        public static void ExcluirFilme()
        {
           Console.Write("Digite o id do filme: ");
            int indiceFilmes = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceFilmes);
        }

        public static void AtualizarFilmes()
        {
            Console.Write("Digite o id da série: ");
            int indiceFilmes = int.Parse(Console.ReadLine());

            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição ddo Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filmes atualizaFilmes = new Filmes(Id2: indiceFilmes,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descriçao: entradaDescricao);

            repositorio2.Atualiza(indiceFilmes, atualizaFilmes);
        }

        public static void InserirFilmes()
        {
           Console.WriteLine("Inserir novo Filme");

            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Filmes novoFilme = new Filmes(Id2:repositorio2.ProximoId(),
                                          genero: (Genero)entradaGenero,
                                          titulo: entradaTitulo,
                                          ano: entradaAno,
                                          descriçao: entradaDescricao);

           repositorio2.InsereFilme(novoFilme);
        }

        public static void ListarFilmes()
        {
             Console.WriteLine("Listar filmes");

            var lista = repositorio2.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.RetornaExcluido();

                Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId2(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
        }
    }
}
}