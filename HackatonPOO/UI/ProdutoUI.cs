using HackatonPOO.Model;

namespace HackatonPOO.UI;

public class ProdutoUI
{
    List<Produto> _produtos = new List<Produto>();
    public void createProduto(String nome, String desc, double preco, Categoria categoria)
    {
        Produto prod = new Produto(nome, desc, preco, categoria);
        _produtos.Add(prod);
    }
}