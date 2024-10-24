public abstract class ItemBiblioteca
{
    public string Titulo { get; set; }
    public string Codigo { get; set; }
    
    public abstract void 
    Emprestar(Usuario usuario);
    public abstract void Devolver(Usuario usuario);
    
    public virtual void AdicionarInformações()
    {
        Console.WriteLine($"Código: {Codigo}");
    }
}
