using System.Runtime.InteropServices;

class Retangulo
{
    private double altura;
    private double largura;
    private double area;

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
                Console.WriteLine("O valor precisa ser um número");
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
                Console.WriteLine("O valor precisa ser um número");
            }
        }
    }
 
    public double Area
    {
        get {return area;}
        set
        {
            if (value > 0)
            {
                area = value;
            }
            else
            {
                Console.WriteLine("O valor precisa ser um número");
            }
        }
    }

    // Construtor
    public Retangulo (double altura1, double largura1, double area1)
    {
        altura = altura1; 
        largura = largura1; 
        area = area1; 
    }

}