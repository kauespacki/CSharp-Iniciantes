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

var soma = Soma(listaNumeros);
var media = MediaValores(listaNumeros);
Console.WriteLine($"A soma é {soma}");
Console.WriteLine($"A media é {media}");

double Soma(List<double> lista)
{
    return lista.Sum();
}

double MediaValores(List<double> lista)
{
    return lista.Average();
}