namespace /*Insira o seu namespace aqui*/.Entities
{
    class Book
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public Book(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
             
        public override string ToString()
        {
            return "Titulo: "
                + Titulo
                + "\n"
                + "Autor: "
                + Autor
                + "\n"
                + "Numero de vezes Emprestado: "
                + "\n";

        }
    }
}
