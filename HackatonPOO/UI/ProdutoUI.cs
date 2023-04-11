using HackatonPOO.Model;

namespace HackatonPOO.UI;

public class ProdutoUI
{
    List<Produto> _produtos = new List<Produto>();

    public void createProduto(Produto produto)
    {
        _produtos.Add(produto);
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
    public int getPosProduto(int id)
    {
        for (int i = 0; i < _produtos.Count; i++)
        {
            if (_produtos[i].id == id)
            {
                return i;
            }

        }
        return -1;
    }

    public void updateProduto(int id, Produto produto)
    {
        int pos = getPosProduto(id);
        if (pos == -1)
        {
            Console.WriteLine("Não foi possivel editar, pois este produto não foi encontrado");
        }
        else
        {
            _produtos[pos] = produto;
        }
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
