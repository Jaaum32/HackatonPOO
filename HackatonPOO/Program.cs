using HackatonPOO.Model;
using HackatonPOO.UI;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Loja de Roupa dos Gurizaum!");
        ClienteUI cui = new ClienteUI();
        CategoriaUI caui = new CategoriaUI();

        int idCountClient = 1;
        int idCountProduto = 1;
        int idCountCategoria = 1;
        int idCountVenda = 1;

        bool execMenu = true;
        bool execProd = true;
        bool execClient = true;
        bool execCategoria = true;
        bool execVenda = true;

        while (execMenu)
        {
            Console.WriteLine("--- Sistema ---\n1 - Produto\n2 - Cliente\n3 - Categoria\n4 - Venda\n0 - Sair");
            int id;
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 0:
                    execMenu = false;
                    break;
                case 1:
                    while (execProd)
                    {
                        Console.WriteLine(
                            "--- Produto ---\n1 - Inserir\n2 - Alterar\n3 - Listar\n4 - Pesquisar\n5 - Remover\n0 - Sair");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 0:
                                execProd = false;
                                break;
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
                                Console.WriteLine("Este número não está no MENU!");
                                break;
                        }
                    }

                    execProd = true;

                    break;
                case 2:
                    while (execClient)
                    {
                        Console.WriteLine(
                            "--- Cliente ---\n1 - Inserir\n2 - Alterar\n3 - Listar\n4 - Pesquisar\n5 - Remover\n0 - Sair");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 0:
                                execClient = false;
                                break;
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
                                c.id = idCountClient;
                                idCountClient++;

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
                    }

                    execClient = true;

                    break;
                case 3:
                    while (execCategoria)
                    {
                        Console.WriteLine(
                            "--- Categoria ---\n1 - Inserir\n2 - Alterar\n3 - Listar\n4 - Pesquisar\n5 - Remover\n0 - Sair");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 0:
                                execClient = false;
                                break;
                            case 1:
                                Categoria c = new Categoria();
                                Console.WriteLine("Nome: ");
                                c.Nome = Console.ReadLine();
                                Console.WriteLine("Descricao: ");
                                c.Desc = Console.ReadLine();
                                c.id = idCountClient;
                                idCountClient++;

                                break;
                            case 2:
                                Console.WriteLine("Digite o ID do categoria a ser buscado: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(caui.readCategory(id).ToString());

                                Console.WriteLine("Nome: ");
                                caui.categoria[cui.getPosCliente(id)].Nome = Console.ReadLine();
                                Console.WriteLine("Descricao: ");
                                caui.categoria[cui.getPosCliente(id)].Desc = Console.ReadLine();
                                
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
                    }

                    execCategoria = true;

                    break;
                case 4:
                    while (execVenda)
                    {
                        Console.WriteLine(
                            "--- Venda ---\n1 - Inserir\n2 - Alterar\n3 - Listar\n4 - Pesquisar\n5 - Remover\n0 - Sair");

                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 0:
                                execVenda = false;
                                break;
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
                    }

                    execVenda = true;

                    break;
                default:
                    Console.WriteLine("Essa não é uma opção do MENU!");
                    break;
            }
        }
    }
}