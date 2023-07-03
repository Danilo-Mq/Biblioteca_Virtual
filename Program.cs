using RASCUNHO.Entities;

namespace /*Insira o seu namespace aqui*/
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a Biblioteca, o que deseja fazer ?");

            bool loop = false;
            Library library = new Library();

            while (!loop)
            {
                Console.WriteLine("Adicionar - Disponibilidade - Emprestimo - Devolução - Lista de Livros - ou Sair");
                string resposta = Console.ReadLine();
                Console.WriteLine();
                switch (resposta)
                {
                    case "Adicionar":
                        Console.WriteLine("Insira as informações do Livro abaixo para adicionar: ");
                        Console.WriteLine("Titulo: ");
                        string titulo = Console.ReadLine();
                        Console.WriteLine("Autor: ");
                        string autor = Console.ReadLine();
                        Book book = new Book(titulo, autor);
                        library.AdicionarBooks(book);
                        Console.WriteLine();
                        break;

                    case "Disponibilidade":
                        Console.WriteLine("Insira o titulo do Livro: ");
                        Console.Write("Titulo: ");
                        titulo = Console.ReadLine();
                        library.Disponibilidade(titulo);
                        Console.WriteLine();
                        break;

                    case "Emprestimo":
                        Console.WriteLine("Insira o titulo do Livro para realizar o Empréstimo: ");
                        Console.Write("Titulo: ");
                        titulo = Console.ReadLine();
                        book.NumeroDeEmprestimos;
                        library.Emprestimo(titulo);

                        Console.WriteLine();
                        break;

                    case "Devolução":
                        Console.WriteLine("Insira o titulo do Livro para realizar a Devolução: ");
                        Console.Write("Titulo: ");
                        titulo = Console.ReadLine();
                        library.Devolucao(titulo);
                        Console.WriteLine();
                        break;

                    case "Lista de Livros":
                        Console.WriteLine("Sua lista de Livros Disponíveis: ");

                        List<Book> booksDisponiveis = library.GetLista();
                        library.ImprimirLista(booksDisponiveis);
                        break;


                    case "Sair":
                        loop = true;
                        break;
                }
            }
        }
    }
}

