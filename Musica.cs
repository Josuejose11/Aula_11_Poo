class Musica
{
    private string nome;
    private int anoPublicacao;
    private string autor;

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
            if (value is int)
            {
               anoPublicacao = value; 
            }
            else
            {
                Console.WriteLine("Insira corretamente o ano de publicação");
            }   
        }
    }

}