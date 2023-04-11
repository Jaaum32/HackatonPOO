using HackatonPOO.Model;
using HackatonPOO.UI;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Loja de Roupa dos Gurizaum!");
        ClienteUI cui = new ClienteUI();

        while (true)
        {
            Console.WriteLine("--- Sistema ---\n1 - Produto\n2 - Cliente\n3 - Categoria\n4 - Venda");
            int id;
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("--- Produto ---\n1 - Inserir\n2 - Alterar\n3 - Listar\n4 - Pesquisar\n5 - Remover");
                    switch (Convert.ToInt32(Console.ReadLine())) {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        default:
                            break;
                    }

                    break;
                case 2:
                    Console.WriteLine("--- Cliente ---\n1 - Inserir\n2 - Alterar\n3 - Listar\n4 - Pesquisar\n5 - Remover");
                    switch (Convert.ToInt32(Console.ReadLine())) {
                        case 1:
                            Cliente c = new Cliente();
                            Console.WriteLine("Nome: ");
                            c.Nome = Console.ReadLine();
                            Console.WriteLine("Sobrenome: ");
                            c.Sobrenome = Console.ReadLine();
                            Console.WriteLine("Endereço: ");
                            c.Endereco = Console.ReadLine();
                            Console.WriteLine("Telefone: ");
                            c.Telefone = Console.ReadLine();
                            
                            break;
                        case 2:
                            Console.WriteLine("Digite o ID do cliente a ser buscado: ");
                            id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(cui.getClient(id).ToString());
                            
                            Console.WriteLine("Nome: ");
                            cui.clientes[cui.getPosCliente(id)].Nome = Console.ReadLine();
                            Console.WriteLine("Sobrenome: ");
                            cui.clientes[cui.getPosCliente(id)].Sobrenome = Console.ReadLine();
                            Console.WriteLine("Endereço: ");
                            cui.clientes[cui.getPosCliente(id)].Endereco = Console.ReadLine();
                            Console.WriteLine("Telefone: ");
                            cui.clientes[cui.getPosCliente(id)].Telefone = Console.ReadLine();

                            break;
                        case 3:
                            cui.getAllClients();
                            break;
                        case 4:
                            Console.WriteLine("Digite o ID do cliente a ser buscado: ");
                            id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(cui.getClient(id).ToString());
                            break;
                        case 5:
                            Console.WriteLine("Digite o ID do cliente para remover: ");
                            id = Convert.ToInt32(Console.ReadLine());

                            cui.deleteClient(id);
                            break;
                        default:
                            Console.WriteLine("Este número não está no MENU!");
                            break;
                    }

                    break;
                case 3:
                    Console.WriteLine("--- Categoria ---\n1 - Inserir\n2 - Alterar\n3 - Listar\n4 - Pesquisar\n5 - Remover");
                    switch (Convert.ToInt32(Console.ReadLine())) {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        default:
                            break;
                    }

                    break;
                case 4:
                    Console.WriteLine("--- Venda ---\n1 - Inserir\n2 - Alterar\n3 - Listar\n4 - Pesquisar\n5 - Remover");
                    switch (Convert.ToInt32(Console.ReadLine())) {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        default:
                            break;
                    }

                    break;
                default:
                    break;
            }
        }
    }
}