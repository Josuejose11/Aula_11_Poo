using System.Runtime.InteropServices;

class Retangulo
{
    private double altura;
    private double largura;

    public double Altura
    {
        get {return altura;}
        set
        {
            if (value > 0)
            {
                altura = value;
            }
            else
            {
                Console.WriteLine("O valor precisa ser maior que 0");
            }
        }
    }

    public double Largura
    {
        get {return largura;}
        set
        {
            if (value > 0)
            {
                largura = value;
            }
            else
            {
                Console.WriteLine("O valor precisa ser maior que 0");
            }
        }
    }
    
    //Método área
    public void CalcularArea()
    {
        Console.WriteLine("A área do seu retângulo é: " + altura*largura);
    }

    // Construtor
    public Retangulo (double altura, double largura)
    {
        this.altura = altura;
        this.largura = largura;
    }

    // Tostring
    public override string ToString()
    {
        return "\n===Classe Retangulo===\n| Altura: " + altura + " | Largura: " + largura + " | Área: " + altura*largura;
    }
}