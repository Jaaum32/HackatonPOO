using HackatonPOO.Model;
using HackatonPOO.UI;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Loja de Roupa dos Gurizaum!");
        ClienteUI cui = new ClienteUI();
        CategoriaUI caui = new CategoriaUI();
        VendaUI vui = new VendaUI();
        ProdutoUI pui = new ProdutoUI();

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
                                Produto p = new Produto();
                                Console.WriteLine("Nome: ");
                                p.Nome = Console.ReadLine();
                                Console.WriteLine("Descrição: ");
                                p.Desc = Console.ReadLine();
                                Console.WriteLine("Preço: ");
                                p.Preco = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("ID da Categoria: ");
                                p.Categoria = caui.categoria[caui.getPosCategoria(Convert.ToInt32(Console.ReadLine()))];
                                p.id = idCountProduto;
                                idCountProduto++;
                                
                                pui.createProduto(p);

                                break;
                            case 2:
                                Console.WriteLine("Digite o ID do produto a ser buscado: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(pui.getProduto(id).ToString());
                                
                                Console.WriteLine("Nome: ");
                                pui.produtos[pui.getPosProduto(id)].Nome = Console.ReadLine();
                                Console.WriteLine("Descrição: ");
                                pui.produtos[pui.getPosProduto(id)].Desc = Console.ReadLine();
                                Console.WriteLine("Preço: ");
                                pui.produtos[pui.getPosProduto(id)].Preco = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("ID da Categoria: ");
                                pui.produtos[pui.getPosProduto(id)].Categoria = caui.categoria[caui.getPosCategoria(Convert.ToInt32(Console.ReadLine()))];

                                break;
                            case 3:
                                pui.getAll();
                                break;
                            case 4:
                                Console.WriteLine("Digite o ID do produto a ser buscado: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(pui.getProduto(id).ToString());
                                break;
                            case 5:
                                Console.WriteLine("Digite o ID do produto para remover: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                pui.deleteProduto(id);
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
                                
                                cui.createCliente(c);

                                break;
                            case 2:
                                Console.WriteLine("Digite o ID do cliente a ser buscado: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(cui.getCliente(id).ToString());

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
                                cui.getAll();
                                break;
                            case 4:
                                Console.WriteLine("Digite o ID do cliente a ser buscado: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(cui.getCliente(id).ToString());
                                break;
                            case 5:
                                Console.WriteLine("Digite o ID do cliente para remover: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                cui.deleteCliente(id);
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
                                execCategoria = false;
                                break;
                            case 1:
                                Categoria c = new Categoria();
                                Console.WriteLine("Nome: ");
                                c.Nome = Console.ReadLine();
                                Console.WriteLine("Descricao: ");
                                c.Desc = Console.ReadLine();
                                c.id = idCountCategoria;
                                idCountCategoria++;

                                caui.createCategoria(c);
                                
                                break;
                            case 2:
                                Console.WriteLine("Digite o ID do categoria a ser buscado: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(caui.getCategoria(id).ToString());

                                Console.WriteLine("Nome: ");
                                caui.categoria[caui.getPosCategoria(id)].Nome = Console.ReadLine();
                                Console.WriteLine("Descricao: ");
                                caui.categoria[caui.getPosCategoria(id)].Desc = Console.ReadLine();
                                
                                break;
                            case 3:
                                caui.getAll();
                                break;
                            case 4:
                                Console.WriteLine("Digite o ID do categoria a ser buscado: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(caui.getCategoria(id).ToString());
                                break;
                            case 5:
                                Console.WriteLine("Digite o ID do categoria para remover: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                caui.deleteCategoria(id);
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
                                Venda v = new Venda();
                                Console.WriteLine("ID do Cliente: ");
                                v.Cliente = cui.clientes[cui.getPosCliente(Convert.ToInt32(Console.ReadLine()))];
                                Console.WriteLine("Data: ");
                                v.Data = Console.ReadLine();
                                List<Produto> p = new List<Produto>();
                                double? val = 0;
                                while (true)
                                {
                                    Console.WriteLine("Digite o ID do produto (digite X para parar de adicionar produtos): ");
                                    string? idp = Console.ReadLine();

                                    if (idp == "X")
                                    {
                                        break;
                                    }
                                    
                                    p.Add(pui.produtos[pui.getPosProduto(Convert.ToInt32(idp))]);
                                    val += pui.produtos[pui.getPosProduto(Convert.ToInt32(idp))].Preco;

                                }

                                v.ProdutosComprados = p;
                                v.ValorTotal = val;
                                v.id = idCountVenda;
                                idCountVenda++;
                                
                                vui.createVenda(v);

                                break;
                            case 2:
                                Console.WriteLine("Digite o ID da venda a ser buscado: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(caui.getCategoria(id).ToString());

                                Console.WriteLine("Nome: ");
                                caui.categoria[caui.getPosCategoria(id)].Nome = Console.ReadLine();
                                Console.WriteLine("Descricao: ");
                                caui.categoria[caui.getPosCategoria(id)].Desc = Console.ReadLine();
                                
                                break;
                            case 3:
                                vui.getAll();
                                break;
                            case 4:
                                Console.WriteLine("Digite o ID da venda a ser buscado: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine(vui.getVenda(id).ToString());
                                break;
                            case 5:
                                Console.WriteLine("Digite o ID da venda para remover: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                vui.deleteVenda(id);
                                break;
                            default:
                                Console.WriteLine("Este número não está no MENU!");
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