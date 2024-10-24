using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class Biblioteca
{
    public List<Livro> Livros { get; private set; } = new List<Livro>();
    public List<Usuario> Usuarios { get; private set; } = new List<Usuario>();

    public void CadastrarLivro(Livro livro)
    {
        Livros.Add(livro);
        Console.WriteLine($"Livro '{livro.Titulo}' cadastrado com sucesso.");
    }
        public List<Livro> PesquisarPorGenero(string Genero)
    {
        Console.WriteLine($"Pesquisando por gênero: {Genero}");
        List<Livro> resultados = new List<Livro>();

        foreach (var livro in Livros)
    {
        if (string.Equals(livro.Genero, Genero, StringComparison.OrdinalIgnoreCase))
        {
            resultados.Add(livro);
        }
    }

    if (resultados.Count == 0)
    {
        Console.WriteLine("Nenhum livro encontrado com esse gênero.");
    }
        return resultados;
    }
        public List<Livro> PesquisarPorTitulo(string Titulo)
    {
        Console.WriteLine($"Pesquisando por título: {Titulo}");
        List<Livro> resultados = new List<Livro>();

    foreach (var livro in Livros)
    {
        if (string.Equals(livro.Titulo, Titulo, StringComparison.OrdinalIgnoreCase))
        {
            resultados.Add(livro);
        }
    }

    if (resultados.Count == 0)
    {
        Console.WriteLine("Nenhum livro encontrado com esse título.");
    }
    return resultados;
    }
    public List<Livro> PesquisarPorAutor(string Autor)
    {
        Console.WriteLine($"Pesquisando por autor: {Autor}");
        List<Livro> resultados = new List<Livro>();

    foreach (var livro in Livros)
    {
        if (string.Equals(livro.Autor, Autor, StringComparison.OrdinalIgnoreCase))
        {
            resultados.Add(livro);
        }
    }

    if (resultados.Count == 0)
    {
        Console.WriteLine("Nenhum livro encontrado com esse autor.");
    }
        return resultados;
    }
    public void CadastrarUsuario(Usuario usuario)
    {
        Usuarios.Add(usuario);
        Console.WriteLine($"Usuário '{usuario.Nome}' cadastrado com sucesso.");
    }

    public void EmprestarLivro(string codigoLivro, int numeroUsuario)
    {
        Livro livro = Livros.Find(l => l.ISBN == codigoLivro);
        Usuario usuario = Usuarios.Find(u => u.NumeroIdentificacao == numeroUsuario);

    if (livro != null && usuario != null)
    {
        livro.Emprestar(usuario);
        usuario.AdicionarEmprestimo(new Emprestimo(livro.Titulo, DateTime.Now));
    }
    else
    {
        Console.WriteLine("Livro ou usuário não encontrado.");
    }
    }

    public void DevolverLivro(string codigoLivro, int numeroUsuario)
    {
        Livro livro = Livros.Find(l => l.Codigo == codigoLivro);
        Usuario usuario = Usuarios.Find(u => u.NumeroIdentificacao == numeroUsuario);

        if (livro != null)
        {
            livro.Devolver(usuario);
            Console.WriteLine("Livro devolvido com sucesso!");
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }

    public void ListarLivros()
    {
        Console.WriteLine("Livros cadastrados:");
        foreach (var livro in Livros)
        {
            Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Código: {livro.Codigo}, Quantidade: {livro.QuantidadeEmEstoque}");
        }
    }

    public void ListarUsuarios()
    {
        Console.WriteLine("Usuários cadastrados:");
        foreach (var usuario in Usuarios)
        {
            Console.WriteLine($"Nome: {usuario.Nome}, ID: {usuario.NumeroIdentificacao}");
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }


    
}
