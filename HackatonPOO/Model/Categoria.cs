namespace HackatonPOO.Model;

public class Categoria
{
    public int id;
    String? nome;
    String? desc;

    public Categoria(String nome, String desc)
    {
        this.nome = nome;
        this.desc = nome;
    }
    public Categoria() { }

    public string? Nome
    {
        get { return nome; }
        set { this.nome = value; }
    }

    public string? Desc
    {
        get { return Desc; }
        set { this.Desc = value; }
    }
    public override string ToString()
    {
        return "[" + id + "]\nNome: " + nome + "\nDesc: " + desc;
    }
}