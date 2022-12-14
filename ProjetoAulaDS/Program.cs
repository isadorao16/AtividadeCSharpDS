using BibliotecaDejogos.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDejogos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jogo> listaDeJogos = new List<Jogo>();
            Console.ForegroundColor = ConsoleColor.Red;

            while (true)
            {

                Console.WriteLine("======BIBLIOTECA DE JOGOS======");
                Console.WriteLine("1 - Adicionar Jogo");
                Console.WriteLine("2 - Listar Jogos");
                Console.WriteLine("3 - Editar Jogo");
                Console.WriteLine("4 - Remover Jogo");
                Console.Write("Opcao: ");

                bool resultado;
                String opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        resultado = AdicionarJogo(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Sucesso ao cadatrar!");
                        }
                        else
                        {
                            Console.WriteLine("Ops..Ocorreu um erro!");
                        }
                        break;

                    case "2":
                        resultado = ListarJogos(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Sucesso ao listar!");
                        }
                        else
                        {
                            Console.WriteLine("Ops..Ocorreu um erro!");
                        }

                        break;

                    case "3":
                        resultado = EditarJogos(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Sucesso ao editar!");
                        }
                        else
                        {
                            Console.WriteLine("Ops...Ocorreu um erro!");
                        }

                        break;

                    case "4":
                        resultado = DeletarJogos(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Sucesso ao deletar!");
                        }
                        else
                        {
                            Console.WriteLine("Ops..Ocorreu um erro!");
                        }

                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static bool AdicionarJogo(List<Jogo> listaDejogos)
        {
            Console.Clear();
            Console.Write("Titulo: ");
            String titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Máximo de Jogadores: ");
            String maxJogadores = Console.ReadLine();
            Console.Write("Crítica: ");
            String metacritic = Console.ReadLine();

            if (titulo == "") return false;
            if (ano < 1950) return false;
            

            Jogo novoJogo = new Jogo(titulo, ano, maxJogadores, 1);

            listaDejogos.Add(novoJogo);
            Console.Beep();

            return true;
        }

        public static bool ListarJogos(List<Jogo> listaJogos)
        {
            foreach (Jogo jogo in listaJogos)
            {
                Console.Write("Titulo: ");
                Console.WriteLine(jogo.getTitulo());
                Console.Write("Ano: ");
                Console.WriteLine(jogo.getAno());
                Console.Write("Máximo de Jogadores: ");
                Console.WriteLine(jogo.getmaxJogadores());
                Console.WriteLine("==========");
                Console.WriteLine("");
            }

            return true;
        }

        public static bool EditarJogos(List<Jogo> listaJogos)
        {
            Console.Clear();
            Console.Write("Qual jogo deseja editar? Escreva-o: ");
            String titulo_editar = Console.ReadLine();

            foreach (Jogo jogo in listaJogos)
            {

                if (jogo.getTitulo() == titulo_editar)
                {
                    Console.WriteLine("Novo nome: ");
                    String titulo_editado = Console.ReadLine();
                    jogo.setTitulo(titulo_editado);
                    return true;
                }
            }
            return false;
        }
        public static bool DeletarJogos(List<Jogo> listaDejogos)
        {
            Console.WriteLine("Qual jogo deseja editar ? Escreva - o : ");
            String titulo_deletar = Console.ReadLine();

            foreach (Jogo jogo in listaDejogos)
            {
                if (jogo.getTitulo() == titulo_deletar)
                {
                    listaDejogos.Remove(jogo);
                    Console.WriteLine("Jogo Deletado!");
                    return true;

                }
            }

            return false;
        }

    }

}