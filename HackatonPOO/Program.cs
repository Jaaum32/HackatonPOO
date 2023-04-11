using HackatonPOO.Model;

Console.WriteLine("Loja de Roupa dos Gurizaum!");
// List<Produto> produtos = new List<Produto>();
// List<Categoria> categorias = new List<Categoria>();
// List<Cliente> clientes = new List<Cliente>();
// List<Venda> vendas = new List<Venda>();

while (true)
{
    Console.WriteLine("--- Sistema ---\n1 - Produto\n2 - Cliente\n3 - Categoria\n4 - Venda");
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