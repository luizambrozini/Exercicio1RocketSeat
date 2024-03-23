using System;

class Program
{
    static void Main()
    {
        // Exercício 1
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");

        // Exercício 2
        Console.WriteLine("\nDigite seu primeiro nome:");
        string nome2 = Console.ReadLine();
        Console.WriteLine("\nDigite seu sobrenome:");
        string sobrenome = Console.ReadLine();
        Console.WriteLine($"Seu nome completo é: {nome2} {sobrenome}");

        // Exercício 3
        Console.WriteLine("\nDigite o primeiro número:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double soma = num1 + num2;
        double subtracao = num1 - num2;
        double multiplicacao = num1 * num2;
        double divisao = num2 != 0 ? num1 / num2 : double.NaN; // Verificação para divisão por zero
        double media = (num1 + num2) / 2;

        Console.WriteLine($"\nSoma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");
        Console.WriteLine($"Divisão: {(double.IsNaN(divisao) ? "Divisão por zero!" : divisao.ToString())}");
        Console.WriteLine($"Média: {media}");

        // Exercício 4
        Console.WriteLine("\nDigite uma palavra ou frase:");
        string palavra = Console.ReadLine();
        int contador = 0;
        foreach (char c in palavra)
        {
            if (!char.IsWhiteSpace(c)) // Ignora espaços
                contador++;
        }
        Console.WriteLine($"A palavra/frase \"{palavra}\" possui {contador} caracteres.");

        // Exercício 5
        Console.WriteLine("\nDigite a placa do veículo:");
        string placa = Console.ReadLine();
        bool placaValida = false;
        if (placa.Length == 7)
        {
            string letras = placa.Substring(0, 3);
            string numeros = placa.Substring(3);
            if (letras.All(char.IsLetter) && numeros.All(char.IsDigit))
                placaValida = true;
        }
        Console.WriteLine(placaValida ? "Verdadeiro" : "Falso");

        // Exercício 6
        DateTime dataAtual = DateTime.Now;
        Console.WriteLine($"\nFormato completo: {dataAtual}");
        Console.WriteLine($"Apenas a data: {dataAtual.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Apenas a hora: {dataAtual.ToString("HH:mm:ss")}");
        Console.WriteLine($"Data por extenso: {dataAtual.ToString("dd 'de' MMMM 'de' yyyy")}");
    }
}
