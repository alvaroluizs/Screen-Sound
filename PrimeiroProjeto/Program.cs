// SCREEN SOUND
string mensagemBoasVindas = "Boas Vindas ao Screen Sound";
Console.WriteLine(mensagemBoasVindas);
List<string> listaDasBandas = new List<string> {"U2", "The Beatles", "Calipson" };
void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -6 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}

string screenSound = @"
 
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░       
";

void ExibirLogo()
{
    Console.WriteLine(screenSound);
    Console.WriteLine(mensagemBoasVindas);
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("*********************");
    Console.WriteLine("Registro de Bandas");
    Console.WriteLine("*********************\n");
    Console.Write("Digite o nome da Banda que deseja registrar: ");
    string NomeDaBanda = Console.ReadLine();
    listaDasBandas.Add(NomeDaBanda);
    Console.WriteLine($"A Banda {NomeDaBanda} foi registrada com sucesso! ");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("*************************************");
    Console.WriteLine("Exibindo todas as bandas registradas! ");
    Console.WriteLine("*************************************\n");
    Console.WriteLine("Digite o nome da Banda que deseja registrar: ");

   // for (int i = 0; i < listaDasBandas.Count; i++)
   // {
      //  Console.WriteLine($"Banda: {listaDasBandas[i]}");
  //  }

    foreach (string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda:{banda} ");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}
ExibirOpcoesDoMenu();


