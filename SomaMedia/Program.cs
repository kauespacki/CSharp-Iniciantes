var listaNumeros = new List<double>(10);

Console.Write("De 3 a 10, quantos números você quer informar? ");
var quantidadeString = Console.ReadLine();
var quantidadeInt = int.TryParse(quantidadeString, out var quantidadeValor);

if (quantidadeValor < 3 || quantidadeValor > 10)
{
    Console.WriteLine("Quantidade inválida.");
    System.Environment.Exit(0);
}

// quantidadeValor + 1 - porque o "i" começa no 1, ao invés de zero.
for (int i = 1; i < quantidadeValor + 1; i++)
{
    Console.Write($"{i}o. Valor: ");
    var numeroString = Console.ReadLine();
    var numeroDouble = double.TryParse(numeroString, out var numeroValor);
    listaNumeros.Add(numeroValor);
}

Soma(listaNumeros);
MediaValores(listaNumeros);

void Soma(List<double> lista)
{
    double contador = 0;
    foreach (var i in lista)
    {
        contador += i;
    }
    Console.WriteLine($"A soma dos valores é {contador}");
}

void MediaValores(List<double> lista)
{
    double contador = 0;
    foreach (var i in lista)
    {
        contador += i;
    }
    var media = contador / lista.Count;
    Console.WriteLine($"A média dos valores é {media}");
}