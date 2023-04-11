using HackatonPOO.Model;

namespace HackatonPOO.UI;

public class VendaUI
{
    private List<Venda> sails = new List<Venda>();
    
    public void createCategory(Venda venda)
    {
        sails.Add(venda);
    }
    
    /// <summary>
    /// Busca uma categoria pelo seu id.
    /// Caso o id não seja encontrado, o método retornará "null".
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Venda readSail(int id)
    {
        for (int i = 0; i < sails.Count; i++)
        {
            if (sails[i].id == id)
            {
                return sails[i];
            }
        }

        return null;
    }
    
    /// <summary>
    /// Busca uma venda pelo seu id.
    /// caso o id não seja encontrado, o método retornará "-1".
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public int GetPosSail(int id)
    {
        for (int i = 0; i < sails.Count; i++)
        {
            if (sails[i].id == id)
            {
                return i;
            }
        }

        return -1;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cliente"></param>
    public void updateCategory(int id, Venda venda)
    {
        int pos = GetPosSail(id);

        if (pos == -1)
        {
            Console.WriteLine("Não foi possivel editar, pois esta venda não foi encontrado");
        }
        else
        {
            sails[pos] = venda;
        }
    }
    
    public void deleteSail(int id)
    {
        int pos = GetPosSail(id);

        if (pos == -1)
        {
            Console.WriteLine("Não foi possivel remover, pois esta venda não foi encontrado");
        }
        else
        {
            sails.RemoveAt(pos);
        }
    }

    public void getAll()
    {
        for (int i = 0; i < sails.Count; i++)
        {
            Console.WriteLine("[" + sails[i].id + "]");
            Console.WriteLine("Data: " + sails[i].Data);
            Console.WriteLine("Cliente: " + sails[i].Cliente);
            Console.WriteLine("Produtos Comprados: " + sails[i].ProdutosComprados);
            Console.WriteLine("Valor Total: " + sails[i].ValorTotal);
        }
    }
}