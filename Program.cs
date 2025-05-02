using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Conversor de Temperatura ===");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            
            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.Write("Digite a temperatura em Celsius: ");
                if (double.TryParse(Console.ReadLine(), out double celsius))
                {
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine($"Resultado: {fahrenheit} °F");
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }
            }
            else if (opcao == "2")
            {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                if (double.TryParse(Console.ReadLine(), out double fahrenheit))
                {
                    double celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"Resultado: {celsius} °C");
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }
            }
            else if (opcao == "0")
            {
                Console.WriteLine("Saindo...");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }

            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}

