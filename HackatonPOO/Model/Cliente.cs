namespace HackatonPOO.Model;

public class Cliente
{
    public int id;
    private string? _nome;
    private string? _sobrenome;
    private string? _endereco;
    private string? _telefone;

    public Cliente(string? nome, string? sobrenome, string? endereco, string? telefone)
    {
        this._nome = nome;
        this._sobrenome = sobrenome;
        this._endereco = endereco;
        this._telefone = telefone;
    }

    public string? Nome
    {
        get { return _nome; }
        set { this._nome = value; }
    }

    public string Sobrenome
    {
        get { return Sobrenome; }
        set { this.Sobrenome = value; }
    }

    public double Endereco
    {
        get { return Endereco; }
        set { this.Endereco = value; }
    }

    public string Telefone
    {
        get { return Telefone; }
        set { this.Telefone = value; }
    }
}