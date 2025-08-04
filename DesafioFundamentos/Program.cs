using DesafioFundamentos.Models;

// Define a codificação para UTF-8 (acentuação correta no console)
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Variáveis para os preços
decimal precoInicial;
decimal precoPorHora;

// Boas-vindas e entrada de dados
Console.WriteLine("=== Bem-vindo ao Sistema de Estacionamento ===\n");

// Entrada do preço inicial
Console.Write("Digite o preço inicial: ");
while (!decimal.TryParse(Console.ReadLine(), out precoInicial))
{
    Console.Write("Valor inválido. Digite um número válido para o preço inicial: ");
}

// Entrada do preço por hora
Console.Write("Digite o preço por hora: ");
while (!decimal.TryParse(Console.ReadLine(), out precoPorHora))
{
    Console.Write("Valor inválido. Digite um número válido para o preço por hora: ");
}

// Cria o objeto estacionamento
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

// Variáveis de controle do menu
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("=== Menu Principal ===");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    Console.Write("Escolha uma opção: ");
    
    string opcao = Console.ReadLine();

    Console.Clear();

    switch (opcao)
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            Console.WriteLine("Encerrando o programa...");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção de 1 a 4.");
            break;
    }

    if (exibirMenu)
    {
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
}

Console.WriteLine("\nPrograma finalizado. Obrigado por usar o sistema!");
