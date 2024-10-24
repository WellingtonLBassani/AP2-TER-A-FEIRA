public class Livro : ItemBiblioteca, IEmprestavel
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public string Genero { get; set; }
    public int QuantidadeEmEstoque { get; set; }
    private List<Emprestimo>historicoEmprestimos;
    private List<Livro> livros = new List<Livro>();
    public Livro()
    {
        historicoEmprestimos = new List<Emprestimo>();
    }
    public override void Emprestar(Usuario usuario)
    {
    if (QuantidadeEmEstoque > 0)
         {
        QuantidadeEmEstoque --;
    Console.WriteLine($"Livro {Titulo} emprestado para {usuario.Nome}.");
        var emprestimo = new Emprestimo(Titulo, DateTime.Now);
        historicoEmprestimos.Add(emprestimo);
         }
    else {Console.WriteLine("Titulo não disponivel")
    ;}
    }
    public override void Devolver(Usuario usuario)
    {
        Emprestimo emprestimoUsuario = usuario.historicoEmprestimo.LastOrDefault(e => e.Item == this.Titulo && ! e.DataDevolucao.HasValue);
        if (emprestimoUsuario != null)
        {
        emprestimoUsuario.DataDevolucao = DateTime.Now;
        QuantidadeEmEstoque ++;
        Console.WriteLine($"Livro {Titulo} devolvido em {emprestimoUsuario.DataDevolucao.Value.ToShortDateString()}.");
        }
        else
        {
            Console.WriteLine("Nenhum emprestimo ativo para este livro");
        }
    }
    public override void AdicionarInformações()
    {
        Console.WriteLine($"Autor: {Autor}, Titulo: {Titulo}, Genero {Genero}, Quantidade em estoque: {QuantidadeEmEstoque}");
    }
}

     public class Emprestimo
    {
        public string Item { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public string Status => DataDevolucao.HasValue ?
        "Devolvido" : "Em andamento";
        
    public Emprestimo(string item, DateTime dataEmprestimo)
    {
        Item = item;
        DataEmprestimo = dataEmprestimo;
    }
        public override string ToString()
        {
            return $"item: {Item}, Data de empréstimo: {DataEmprestimo.ToShortDateString()}" + $"Data de devolução: {(DataDevolucao.HasValue ? DataDevolucao.Value.ToShortDateString():"Ainda não devolvido")} " + $"Status: {Status}";
        }
    } 

