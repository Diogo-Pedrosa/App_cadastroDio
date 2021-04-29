using System;
using App_cadastro.classes;
using static App_cadastro.classes.SerieRepositorio;
using static App_cadastro.Metodos;
using static  App_cadastro.metodosfilmes;
namespace App_cadastro
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static FilmesRepositorio repositorio2 = new FilmesRepositorio();
        
        static void Main(string[] args)
    

        {
             {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "C":
						Console.Clear();
                        break;
				    
                    case "S":
                        ConfiguraçaoSerie();
                         break;
                    case "F":
                        ConfiguraçaoFIlme();
                        break;     


					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }
    }

        private static void ConfiguraçaoFIlme()
        {
            string opcaoUsuario3 = OpçoesFilmes();
            while (opcaoUsuario3.ToUpper() != "X")
			{
				switch (opcaoUsuario3)
				{
					case "1":
						ListarFilmes();
						break;
					case "2":
						InserirFilmes();
						break;
					case "3":
						AtualizarFilmes();
						break;
					case "4":
						ExcluirFilme();
						break;
					case "5":
						VisualizarFilme();
						break;
					case "C":
						Console.Clear();
						break;



					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario3 = OpçoesFilmes();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }

       

        private static string OpçoesFilmes()
        {
            Console.WriteLine();
            Console.WriteLine("Voce escolheU filmes");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar Filmes");
			Console.WriteLine("2- Inserir novo filme");
			Console.WriteLine("3- Atualizar filme");
			Console.WriteLine("4- Excluir filme");
			Console.WriteLine("5- Visualizar filme");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

            string opcaoUsuario3 = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario3;
            
        }

        
        private static void ConfiguraçaoSerie()
        {
            string opcaoUsuario2 = OpçoesSeries();
            while (opcaoUsuario2.ToUpper() != "X")
			{
				switch (opcaoUsuario2)
				{
					case "1":
						ListarSeries();
						break;
					case "2":
						InserirSerie();
                        
						break;
					case "3":
						AtualizarSerie();
						break;
					case "4":
						ExcluirSerie();
						break;
					case "5":
						VisualizarSerie();
						break;
					case "C":
						Console.Clear();
						break;



					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario2 = OpçoesSeries();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }

        private static string OpçoesSeries()
        {
            Console.WriteLine();
            Console.WriteLine("Voce escolher series");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar séries");
			Console.WriteLine("2- Inserir nova série");
			Console.WriteLine("3- Atualizar série");
			Console.WriteLine("4- Excluir série");
			Console.WriteLine("5- Visualizar série");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

            string opcaoUsuario2 = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario2;

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Maisa Series e Filmes a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("F- Filmes");
            Console.WriteLine("S- Series");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
         
        
    }
}