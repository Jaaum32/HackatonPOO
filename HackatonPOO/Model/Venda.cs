namespace HackatonPOO.Model;

public class Venda
{
    private Cliente cliente;
    private String data;
    private double valorTotal;
    private List<Produto> produtosComprados;

    public Venda(Cliente cliente, String data, double valorTotal, List<Produto> produtosComprados)
    {
        this.cliente = cliente;
        this.data = data;
        this.valorTotal = valorTotal;
        this.produtosComprados = produtosComprados;
    }

    public Cliente Cliente
    {
        get { return cliente; }
        set { this.cliente = value; }
    }

    public string Data
    {
        get { return Data; }
        set { this.Data = value; }
    }

    public double ValorTotal
    {
        get { return ValorTotal; }
        set { this.ValorTotal = value; }
    }

    public List<Produto> ProdutosComprados
    {
        get { return ProdutosComprados; }
        set { this.ProdutosComprados = value; }
    }
}