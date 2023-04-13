using HackatonPOO.Model;

namespace HackatonPOO.UI;

public class ClienteUI
{
    public List<Cliente> clientes = new List<Cliente>();
    
    public void createClient(Cliente cliente)
    {
        clientes.Add(cliente);
    }
    
    /// <summary>
    /// Busca um usúario pelo seu id.
    /// Caso o id não seja encontrado, o método retornará "null".
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Cliente getClient(int id)
    {
        for (int i = 0; i < clientes.Count; i++)
        {
            if (clientes[i].id == id)
            {
                return clientes[i];
            }
        }

        return null;
    }

    public void getAllClients()
    {
        for (int i = 0; i < clientes.Count; i++)
        {
            Console.WriteLine(clientes[i].ToString());
        }
    }
    

    /// <summary>
    /// Busca um cliente pelo seu id.
    /// caso o id não seja encontrado, o método retornará "-1".
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public int getPosCliente(int id)
    {
        for (int i = 0; i < clientes.Count; i++)
        {
            if (clientes[i].id == id)
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
        int pos = getPosCliente(id);

        if (pos == -1)
        {
            Console.WriteLine("Não foi possivel editar, pois este usuário não foi encontrado");
        }
        else
        {
            clientes[pos] = cliente;
        }
    }
    
    public void deleteClient(int id)
    {
        int pos = getPosCliente(id);

        if (pos == -1)
        {
            Console.WriteLine("Não foi possivel remover, pois este usuário não foi encontrado");
        }
        else
        {
            clientes.RemoveAt(pos);
        }
    }

    public void getAll()
    {
        for (int i = 0; i < clientes.Count; i++)
        {
            clientes.ToString();
        }
    }
    
}