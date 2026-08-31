using System.Globalization;
using System.Runtime.InteropServices.Java;

class Celular
{
    private string marca;
    private string modelo;

    public string Marca
    {
        get {return marca;}
        set
        {
            if (value is "Samsung" or "Iphone" or "Xiaomi" or "Motorola")
            {
                marca = value;
            } 
            else
            {
                Console.WriteLine("Digite uma marca existente");
            }
        }
    }
    public string Modelo
    {
        get {return modelo;}
        set
        {
            if (value is string)
            {
                modelo = value;
            } 
            else
            {
                Console.WriteLine("Preencha o campo");
            }
        }
    }

    // Construtor
    public Celular (string marca, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
    }

    // Tostring
    public override string ToString()
    {
        return "\n===Classe Celular===\n| Marca: " + marca + " | Modelo: " + modelo ;
    }

    //Métodos
    public void ReceberLigacao()
    {
        Console.WriteLine($"A tim está ligando para o celular {modelo}, mas a rede caiu");
    }

}