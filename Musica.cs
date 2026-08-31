class Musica
{
    private string nome;
    private int anoPublicacao;
    private string compositor;

    public string Nome
    {
        get {return nome;}
        set
        {
            if (value is string)
            {
                nome = value;
            }
            else
            {
                Console.WriteLine("Insira corretamente o nome da música");
            }
        }
    }
    public int AnoPublicacao
    {
        get {return anoPublicacao;}
        set
        {
            if (value < 2026 && value > 0)
            {
               anoPublicacao = value; 
            }
            else
            {
                Console.WriteLine("Insira corretamente o ano de publicação");
            }   
        }
    }
    public string Compositor
    {
        get {return compositor;}
        set
        {
            if (value is string)
            {
                compositor = value;
            }
        }
    }

    // Construtor
    public Musica (string nome, int anoPublicacao, string compositor)
    {
        this.nome = nome;
        this.anoPublicacao = anoPublicacao;
        this.compositor = compositor;
    }

    // Tostring
    public override string ToString()
    {
        return "\n===Classe Musica===\n| Nome: " + nome + " | Ano de publicação: " + anoPublicacao + " | Compositor: " + compositor ;
    }

    // Métodos
    public void Tocar()
    {
        Console.WriteLine($"A música {nome} está tocando");
    }
    public void Parar()
    {
        Console.WriteLine($"A música {nome} parou de tocar");
    }
}