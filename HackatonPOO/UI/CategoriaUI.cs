using HackatonPOO.Model;

namespace HackatonPOO.UI;

public class CategoriaUI
{
    private List<Categoria> categoria = new List<Categoria>();
    
    public void createCategory(Categoria categ)
    {
        categoria.Add(categ);
    }
    
    /// <summary>
    /// Busca uma categoria pelo seu id.
    /// Caso o id não seja encontrado, o método retornará "null".
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Categoria readCategory(int id)
    {
        for (int i = 0; i < categoria.Count; i++)
        {
            if (categoria[i].id == id)
            {
                return categoria[i];
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
    public int GetPosCategory(int id)
    {
        for (int i = 0; i < categoria.Count; i++)
        {
            if (categoria[i].id == id)
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
    public void updateCategory(int id, Categoria categ)
    {
        int pos = GetPosCategory(id);

        if (pos == -1)
        {
            Console.WriteLine("Não foi possivel editar, pois esta categoria não foi encontrado");
        }
        else
        {
            categoria[pos] = categ;
        }
    }
    
    public void deleteCategory(int id)
    {
        int pos = GetPosCategory(id);

        if (pos == -1)
        {
            Console.WriteLine("Não foi possivel remover, pois este usuário não foi encontrado");
        }
        else
        {
            categoria.RemoveAt(pos);
        }
    }
    public void getAll()
    {
        for (int i = 0; i < categoria.Count; i++)
        {
            Console.WriteLine("[" + categoria[i].id + "]");
            Console.WriteLine("Nome: " + categoria[i].Nome);
            Console.WriteLine("Desc: " + categoria[i].Desc);
        }
    }
}