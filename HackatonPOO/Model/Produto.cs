namespace HackatonPOO.Model;

public class Produto
{
    private string nome;
    private string desc;
    private double preco;
    private string categoria;

    public Produto(String nome, String desc, double preco, String categoria)
    {
        this.nome = nome;
        this.desc = nome;
        this.preco = preco;
        this.categoria = categoria;
    }

    public string Nome
    {
        get { return nome; }
        set { this.nome = value; }
    }

    public string Desc
    {
        get { return Desc; }
        set { this.Desc = value; }
    }

    public double Preco
    {
        get { return Preco; }
        set { this.Preco = value; }
    }

    public string Categoria
    {
        get { return Categoria; }
        set { this.Categoria = value; }
    }
}