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
        Console.WriteLine("Encerrando...");
        System.Environment.Exit(0);
    } else if (op != 1 && op != 2 && op != 3 && op != 4 && op != 5 && op != 6)
    {
        Console.WriteLine("Opção não existe!");
        Console.ReadKey();
        continue;
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
        case 5:
            if (num2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero!");
                Console.ReadKey();
                break;
            }
            var resto = RestoDaDivisao(num1, num2);
            Console.WriteLine($"O resto da divisão é {resto}!!!");
            Console.ReadKey();
            break;
        case 6:
            resultado = Potenciacao(num1, num2);
            Console.WriteLine($"A potenciação é {resultado}!!!");
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
    Console.WriteLine("5 - Resto da divisão");
    Console.WriteLine("6 - Potenciação: base pelo expoente");
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

double RestoDaDivisao(int a, int b)
{
    return a % b;
}

double Potenciacao(int a, int b)
{
    return double.Pow(a, b);
}
    
