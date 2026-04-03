
using System.Collections.Generic;

double n1, n2 = 0, resultado;
string operador;
string continuar = "sim";
List<string> historico = new List<string>();

while (continuar == "sim")
{

    Console.WriteLine("Digite o primeiro número: ");
    n1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o operador: (+, -, *, /, potencia, raiz )");
    operador = Console.ReadLine();

    if (operador != "raiz")
    {
        Console.WriteLine("Digite o segundo número: ");
        n2 = double.Parse(Console.ReadLine());

    }

    if (operador == "+")
    {
        resultado = (n1 + n2);
        Console.WriteLine("A soma é {0}", resultado);
        historico.Add($"{n1} + {n2} = {resultado}");
    }
    else if (operador == "-")
    {
        resultado = (n1 - n2);
        Console.WriteLine("A subtração é: {0}", resultado);
        historico.Add($"{n1} - {n2} = {resultado}");
    }

    else if (operador == "*")
    {
        resultado = (n1 * n2);
        Console.WriteLine("A multiplicação é: {0} ", resultado);
        historico.Add($"{n1} * {n2} = {resultado}");
    }

    else if (operador == "/")
    {
        if (n2 == 0)
        {
            Console.WriteLine("Não é possível dividir por 0 ");
        }
        else
        {
            resultado = (n1 / n2);
            Console.WriteLine("A divisão é: {0}", resultado);
            historico.Add($"{n1} / {n2} = {resultado}");

        }
    }

    else if (operador == "potencia")
    {
        resultado = Math.Pow(n1, n2);
        Console.WriteLine($"A potência é: {resultado:F2}");
        historico.Add($"{n1} ^ {n2} = {resultado:F2}");
    }
       
    else if (operador == "raiz")
    {
        if (n1 < 0)
        {
            Console.WriteLine("Não existe numero negativo na raiz!");
        }
        else
        {
            resultado = Math.Sqrt(n1);
            Console.WriteLine("A raiz é: {0:F2}", resultado);
            historico.Add($"Raiz de {n1} = {resultado:F2}");
        }
    }
    else
    {
        Console.WriteLine("Operador inválido! ");
    }

    Console.WriteLine("Deseja continuar? (sim/ não)");
    continuar = Console.ReadLine().ToLower();

    if (continuar != "sim")
    {
        Console.WriteLine("========== Encerrando programa ==========");
    }

}

Console.WriteLine("\n========= HISTÓRICO  ==========");

    foreach (var item in historico)
{
    Console.WriteLine(item);

}

