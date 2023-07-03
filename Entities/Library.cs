namespace /*Insira o seu namespace aqui*/.Entities
{
    class Library
    {
        List<Book> booksDisponiveis = new List<Book>();
        List<Book> booksIndisponiveis = new List<Book>();

        public void AdicionarBooks(Book book)
        {
            booksDisponiveis.Add(book);
        }

        public void Disponibilidade(string book)
        {
            Book books = booksDisponiveis.Find(c => c.Titulo.Equals(book, StringComparison.OrdinalIgnoreCase));
            if (books !=null)
            {
                Console.WriteLine("Esse livro está dísponivel para emprestimo !!! ");
            }
            else
            {
                Console.WriteLine("Esse livro não está indísponivel no momento !");
            }
        }

        public void Emprestimo(string book)
        {
            Book books = booksDisponiveis.Find(x => x.Titulo.Equals(book, StringComparison.OrdinalIgnoreCase));
            if (books != null)
            {
                booksDisponiveis.Remove(books);
                booksIndisponiveis.Add(books);
                Console.WriteLine("Empréstimo Realizado com Sucesso !!! ");
            }
            else
            {
                Console.WriteLine("Esse livro não está indísponivel no momento !");
            }
        }
        public void Devolucao(string book)
        {
            Book books = booksIndisponiveis.Find(c => c.Titulo.Equals(book, StringComparison.OrdinalIgnoreCase));
            if (books != null)
            {
                booksIndisponiveis.Remove(books);
                booksDisponiveis.Add(books);

                Console.WriteLine("Devoulução Realizada com Sucesso !!! ");
                                
            }
            else
            {
                Console.WriteLine("Esse livro ja foi devolvido !");
            }
        }

        public List<Book> GetLista()
        {
            return booksDisponiveis;
        }

        public void ImprimirLista(List<Book> booksDisponiveis)
        {
            foreach (var item in booksDisponiveis)
            {
                Console.WriteLine(item);
            }
        }



    }
}
