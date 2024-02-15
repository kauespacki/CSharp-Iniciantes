int op;
double resultado;

while (true)
{
    Menu();
    Console.Write("Opção: ");
// Int32.Parse - faz o casting de string para int
// Trim - tira os espaços em branco do começo e do final
    op = Int32.Parse(Console.ReadLine().Trim());
    if (op == 0)
    {
        System.Environment.Exit(0);
    }
    Console.Write("Primeiro número: ");
    var num1 = Int32.Parse(Console.ReadLine().Trim());
    Console.Write("Segundo número: ");
    var num2 = int.Parse(Console.ReadLine().Trim());

    switch (op)
    {
        case 1:
            resultado = Soma(num1, num2);
            Console.WriteLine($"A soma é {resultado}!!!");
            Console.ReadKey();
            break;
        case 2:
            resultado = Subtracao(num1, num2);
            Console.WriteLine($"A subtração é {resultado}!!!");
            Console.ReadKey();
            break;
        case 3:
            resultado = Multiplicacao(num1, num2);
            Console.WriteLine($"A multiplicação é {resultado}!!!");
            Console.ReadKey();
            break;
        case 4:
            if (num2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero!");
                Console.ReadKey();
                break;
            }
            resultado = Divisao(num1, num2);
            Console.WriteLine($"A divisão é {resultado}!!!");
            Console.ReadKey();
            break;
    }
}

void Menu()
{
    Console.WriteLine("----------------------------");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("----------------------------");
}

double Soma(int a, int b)
{
    return a + b;
}

double Subtracao(int a, int b)
{
    return a - b;
}

double Multiplicacao(int a, int b)
{
    return a * b;
}

double Divisao(int a, int b)
{
    return a / b;
}
    
