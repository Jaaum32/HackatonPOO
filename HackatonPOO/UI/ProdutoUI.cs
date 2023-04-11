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
    public Produto? getIDProduto(int id)
    {
        for (int i = 0; i < _produtos.Count; i++)
        {
            if (_produtos[i].id == id)
            {
                return _produtos[i];
            }

        }
        return null;
    }
    public void removeProduto(int id)
    {
        for (int i = 0; i < _produtos.Count; i++)
        {
            if (_produtos[i].id == id)
            {
                _produtos.RemoveAt(i);
            }
        }
    }
    public void getAll()
    {
        for (int i = 0; i < _produtos.Count; i++)
        {
            Console.WriteLine("[" + _produtos[i].id + "]");
            Console.WriteLine("Nome: " + _produtos[i].Nome);
            Console.WriteLine("Preco: " + _produtos[i].Preco);
            Console.WriteLine("Categoria: " + _produtos[i].Categoria);
            Console.WriteLine("Desc: " + _produtos[i].Desc);

        }
    }
}
