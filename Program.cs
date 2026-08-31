////////////////////////
/// Classe Retangulo ///
////////////////////////

Retangulo ret = new Retangulo(10,5);
Console.WriteLine (ret);
ret.Altura = 20;
Console.WriteLine("Altura: " + ret.Altura);
ret.Largura = -5;
Console.WriteLine("Largura: " + ret.Largura);

Retangulo ret2 = new Retangulo(90,2);
Console.WriteLine (ret2);
Console.WriteLine("Altura: " + ret.Altura);
Console.WriteLine("Largura: " + ret.Largura);
ret2.CalcularArea();

////////////////////////
//// Classe Musica ////
////////////////////////

Musica song1 = new Musica("Thriller", 1982, "Michael Jackson");
Console.WriteLine (song1);
song1.Nome = "Beat it";
Console.WriteLine ("Nome: " + song1.Nome);
Console.WriteLine ("Ano de publicação: " + song1.AnoPublicacao);

Musica song2 = new Musica("Smooth criminal", 1988, "Michael Jackson");
Console.WriteLine (song2);
Console.WriteLine ("Nome: " + song2.Nome);
Console.WriteLine ("Ano de publicação: " + song2.AnoPublicacao);
song2.Tocar();

////////////////////////
//// Classe Celular ////
////////////////////////

Celular cell1 = new Celular("Iphone", "13 pro max");
Console.WriteLine (cell1);
cell1.Modelo = "17 pro max";
Console.WriteLine ("Marca: " + cell1.Marca);
Console.WriteLine ("Modelo: " + cell1.Modelo);
cell1.ReceberLigacao();

Celular cell2 = new Celular("Sansung", "S24");
Console.WriteLine (cell2);
cell2.Modelo = "S25 FE";
Console.WriteLine ("Marca: " + cell2.Marca);
Console.WriteLine ("Modelo: " + cell2.Modelo);
cell2.ReceberLigacao();








