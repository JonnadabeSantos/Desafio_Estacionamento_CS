using Desfio_Estacionamento_C_.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Welcome to JS parking !\n Enter the initial value: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Enter the price per hour: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;


while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Enter your option: ");
    Console.WriteLine("1 - Register vehicle");
    Console.WriteLine("2 - Remove vehicle");
    Console.WriteLine("3 - List vehicles");
    Console.WriteLine("4 - Close");

    switch (Console.ReadLine())
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
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Invalid Option !");
            break;
    }

    Console.WriteLine("Press a key to continue");
    Console.ReadLine();


}


Console.WriteLine("Come Back always Thanks !");