using HackatonPOO.Model;

namespace HackatonPOO.UI;

public class ProdutoUI
{
    List<Produto> produtos = new List<Produto>();

    public void createProduto(Produto produto)
    {
        produtos.Add(produto);
    }
    public Produto? getIDProduto(int id)
    {
        for (int i = 0; i < produtos.Count; i++)
        {
            if (produtos[i].id == id)
            {
                return produtos[i];
            }

        }
        return null;
    }
    public int getPosProduto(int id)
    {
        for (int i = 0; i < produtos.Count; i++)
        {
            if (produtos[i].id == id)
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
            produtos[pos] = produto;
        }
    }
    public void removeProduto(int id)
    {
        for (int i = 0; i < produtos.Count; i++)
        {
            if (produtos[i].id == id)
            {
                produtos.RemoveAt(i);
            }
        }
    }
    public void getAll()
    {
        for (int i = 0; i < produtos.Count; i++)
        {
            Console.WriteLine("[" + produtos[i].id + "]");
            Console.WriteLine("Nome: " + produtos[i].Nome);
            Console.WriteLine("Preco: " + produtos[i].Preco);
            Console.WriteLine("Categoria: " + produtos[i].Categoria);
            Console.WriteLine("Desc: " + produtos[i].Desc);
        }
    }
}
