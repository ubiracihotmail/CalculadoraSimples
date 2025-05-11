Console.WriteLine("Qual operação deseja fazer?");
Console.WriteLine("Digite 1 para adição +");
Console.WriteLine("Digite 2 para Subtração -");
Console.WriteLine("Digite 3 para Multiplicação *");
Console.WriteLine("Digite 4 para Divisão /");
Console.WriteLine("Digite 5 para o resto da divisão %");
int operacao = int.Parse(Console.ReadLine()!);

Console.Write("Digite o primeiro número ");
int numero1 = int.Parse(Console.ReadLine()!);

Console.Write("Digite o segundo número ");
int numero2 = int.Parse(Console.ReadLine()!);

int resultado = 0;

switch (operacao)
{
    case 1: { resultado = numero1 + numero2; break; }
    case 2: { resultado = numero1 - numero2; break; }
    case 3: { resultado = numero1 * numero2; break; }
    case 4: { resultado = numero1 / numero2; break; }
    case 5: { resultado = numero1 % numero2; break; }
    default: Console.WriteLine("Opeção invalida!"); break;
};

Console.WriteLine($"Resultado {resultado}");
        


