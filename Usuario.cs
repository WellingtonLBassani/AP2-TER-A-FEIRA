using System.Reflection.Metadata.Ecma335;

public class Usuario 
{
    public string Nome { get; set; }
    public int NumeroIdentificacao { get; set; }
    public string Endereco { get; set; }
    public string Contato { get; set; }

    public List<Emprestimo>historicoEmprestimo; 

    public Usuario(string nome, int numeroIdentificacao, string endereco, string contato)
    {
        Nome = nome;
        NumeroIdentificacao = numeroIdentificacao;
        Endereco = endereco;
        Contato = contato;
        historicoEmprestimo = new List<Emprestimo>();
    }
        public void ExibirInformações()
    {
        Console.WriteLine($"Nome: " + Nome);
        Console.WriteLine($"Numero de Identificacao: " + NumeroIdentificacao);
        Console.WriteLine($"Endereço: " + Endereco);
        Console.WriteLine($"Contato: " + Contato);
    }

    public void ExibirHistorico()
    {
        if(historicoEmprestimo.Count == 0)
            {
                Console.WriteLine("Nenhum historico de emprestimo disponivel");
                return;
            }
            Console.WriteLine("Historico de emprestimos:");
            foreach (var emprestimo in historicoEmprestimo)
            {
                Console.WriteLine(emprestimo.ToString());
            }
    }
    public void AdicionarEmprestimo(Emprestimo emprestimo)
    {
        historicoEmprestimo.Add(emprestimo);
    }
}