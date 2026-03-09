String Escolha = "";
do
{

    Console.WriteLine("""
        Bem vindo á Calculadora
        Escolha uma das opções de ações:
        1 - Soma
        2 - Subtração
        3 - Multiplicação
        4 - Divisão
        5 - Sair

        Digite o número escolhido
        """);

    Escolha = Console.ReadLine();

    if (Escolha == "5") break;
    if (Escolha != "1" && Escolha != "2" && Escolha != "3" && Escolha != "4")
    {
        Console.WriteLine("\nOpção inválida! Pressione ENTER para tentar novamente.");
        Console.ReadLine();
        continue;
    }

    Console.Write("Digite o primeiro número: ");
    double Numero1 = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    double Numero2 = double.Parse(Console.ReadLine());

    double Resultado = 0;

    switch (Escolha) {
        case "1":
            Resultado = Numero1 + Numero2;
            Console.WriteLine($"\nResultado: {Numero1} + {Numero2} = {Resultado}");
            break;
        case "2":
            Resultado = Numero1 - Numero2;
            Console.WriteLine($"\nResultado: {Numero1} - {Numero2} = {Resultado}");
            break;
        case "3":
            Resultado = Numero1 * Numero2;
            Console.WriteLine($"\nResultado: {Numero1} * {Numero2} = {Resultado}");
            break;
        case "4":
            if (Numero2 == 0)
                Console.WriteLine("\nErro: Divisão por zero não é permitida.");
            else
            {
                Resultado = Numero1 / Numero2;
                Console.WriteLine($"\nResultado: {Numero1} / {Numero2} = {Resultado}");
            }
            break;
    }
} while (Escolha != "5");