using HackatonPOO.Model;

namespace HackatonPOO.UI;

public class VendaUI
{
    private List<Venda> _sails = new List<Venda>();
    
    public void createCategory(Venda venda)
    {
        _sails.Add(venda);
    }
    
    /// <summary>
    /// Busca uma categoria pelo seu id.
    /// Caso o id não seja encontrado, o método retornará "null".
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Venda readSail(int id)
    {
        for (int i = 0; i < _sails.Count; i++)
        {
            if (_sails[i].id == id)
            {
                return _sails[i];
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
        for (int i = 0; i < _sails.Count; i++)
        {
            if (_sails[i].id == id)
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
            _sails[pos] = venda;
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
            _sails.RemoveAt(pos);
        }
    }
}