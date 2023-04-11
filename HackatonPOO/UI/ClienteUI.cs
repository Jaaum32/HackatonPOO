using HackatonPOO.Model;

namespace HackatonPOO.UI;

public class ClienteUI
{
    private List<Cliente> _clientes = new List<Cliente>();
    
    public void createClient(Cliente cliente)
    {
        _clientes.Add(cliente);
    }
    
    /// <summary>
    /// Busca um usúario pelo seu id.
    /// Caso o id não seja encontrado, o método retornará "null".
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Cliente readClient(int id)
    {
        for (int i = 0; i < _clientes.Count; i++)
        {
            if (_clientes[i].id == id)
            {
                return _clientes[i];
            }
        }

        return null;
    }
    
    /// <summary>
    /// Busca um cliente pelo seu id.
    /// caso o id não seja encontrado, o método retornará "-1".
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public int GetPosCliente(int id)
    {
        for (int i = 0; i < _clientes.Count; i++)
        {
            if (_clientes[i].id == id)
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
    public void updateClient(int id, Cliente cliente)
    {
        int pos = GetPosCliente(id);

        if (pos == -1)
        {
            Console.WriteLine("Não foi possivel editar, pois este usuário não foi encontrado");
        }
        else
        {
            _clientes[pos] = cliente;
        }
    }
    
    public void deleteClient(int id)
    {
        int pos = GetPosCliente(id);

        if (pos == -1)
        {
            Console.WriteLine("Não foi possivel remover, pois este usuário não foi encontrado");
        }
        else
        {
            _clientes.RemoveAt(pos);
        }
    }
    
}