public interface IPesquisavel
{
    List<Livro> PesquisarPorTitulo(string Titulo);
    List<Livro> PesquisarPorAutor(string Autor);
    List<Livro> PesquisarPorGenero(string Genero);
}