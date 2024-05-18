using Desfio_Estacionamento_C_.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal parkingTax = 0;
decimal precoPorHora = 0;

Console.WriteLine("\nWelcome to JS parking !");
Console.Write("Enter the parkingTax: ");
parkingTax = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter the price per hour: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(parkingTax, precoPorHora);

bool exibirMenu = true;


while (exibirMenu)
{
    string opcao = string.Empty;
    Console.Clear();

    Console.WriteLine("<<< Menu JS Park >>>: \n");
    Console.WriteLine("1 - Register vehicle");
    Console.WriteLine("2 - Remove vehicle");
    Console.WriteLine("3 - List vehicles");
    Console.WriteLine("4 - Close");
    Console.Write("\nEnter your option: ");

    switch (Console.ReadLine())
    {
        case "1":

            do 
            { 
            es.AdicionarVeiculo();
            Console.Write("\nDo you want to register a new vehicle [ Y/N ]?: ");
            opcao = Console.ReadLine();
            opcao = opcao.ToUpper();
            }

            while (opcao != "N");
            {
            break;
            }
          


        
        case "2":
            
            do
            { 
            es.RemoverVeiculo();
            Console.Write("\nType [Y] to enter again OR [N] to Return to Main Menu: ");
            opcao = Console.ReadLine();
            opcao = opcao.ToUpper();                
            }

            while (opcao != "N");
            {
            break;
            }


        case "3":
            es.ListarVeiculos();

            Console.WriteLine("\nReturn to Main Menu [ Y/N ]?: ");
            opcao = Console.ReadLine();
            opcao = opcao.ToUpper();                
           
            if (opcao != "Y")
            {            
                exibirMenu = false;
                break;                
            }
            else
            {
                break;
            }


        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Invalid Option !");
            break;
    }

    // Console.WriteLine("Press a key to continue");
    // Console.ReadLine();


}


Console.WriteLine("\nCome Back always Thanks !");