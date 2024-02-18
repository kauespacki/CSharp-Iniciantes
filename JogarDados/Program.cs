Console.Write("Entre com o nome do primeiro jogador: ");
var nomeJogadorUm = Console.ReadLine();
Console.Write("Entre com o nome do segundo jogador: ");
var nomeJogadorDois = Console.ReadLine();

var pontosJogadorUm = 0;
var pontosJogadorDois = 0;

var dado = new Random();
int rodada = 0;

if (nomeJogadorDois == nomeJogadorUm)
{
    Console.WriteLine("O nome do segundo jogador não pode ser igual ao nome do primeiro jogador.");
    System.Environment.Exit(0);
}

for (int i = 0; i < 3; i++)
{
    IniciarRodada();
}

Console.WriteLine("----------------------------------------");
Console.WriteLine($"Pontos {nomeJogadorUm}: {pontosJogadorUm}");
Console.WriteLine($"Pontos {nomeJogadorDois}: {pontosJogadorDois}");
Console.WriteLine("----------------------------------------");
var vencedor = pontosJogadorUm > pontosJogadorDois ? nomeJogadorUm : nomeJogadorDois;
Console.WriteLine($"Vencedor foi o {vencedor}!!!!!!!");


void IniciarRodada()
{
    rodada++;
    Console.WriteLine("----------------------------------------");
    var valorDadoJogadorUm = dado.Next(1, 6);
    var valorDadoJogadorDois = dado.Next(1, 6);
    Console.Write($"{nomeJogadorUm} tirou o número {valorDadoJogadorUm} e {nomeJogadorDois} tirou o número {valorDadoJogadorDois}.");
    if (valorDadoJogadorUm > valorDadoJogadorDois && valorDadoJogadorUm != valorDadoJogadorDois)
    {
        Console.WriteLine($"{nomeJogadorUm} venceu a rodada {rodada}.");
    } else if (valorDadoJogadorDois > valorDadoJogadorUm && valorDadoJogadorUm != valorDadoJogadorDois)
    {
        Console.WriteLine($"{nomeJogadorDois} venceu a rodada {rodada}.");
    }

    Console.WriteLine();
    if (valorDadoJogadorUm != valorDadoJogadorDois)
    {
        pontosJogadorUm += valorDadoJogadorUm;
        pontosJogadorDois += valorDadoJogadorDois; 
    }
    else
    {
        Console.WriteLine("Nenhum jogador pontuou! Empate.");
    }
}
