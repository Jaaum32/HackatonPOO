namespace HackatonPOO.Model;

public class Cliente
{
    private string nome;
    private string sobrenome;
    private string endereco;
    private string telefone;

    public Cliente(String nome, String sobrenome, String endereco, String telefone)
    {
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.endereco = endereco;
        this.telefone = telefone;
    }

    public string Nome
    {
        get { return nome; }
        set { this.nome = value; }
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