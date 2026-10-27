





abstract class Veiculo

{
    public string Marca {get; private set;} = "";
    public int Ano {get; private set;}


    public Veiculo (string marca, int ano)
    {
        Marca = marca;
        Ano = ano;
    }
}

class Carro : Veiculo

{
    public string Modelo {get; private set;} = "";
    public string Motorizacao {get; private set;} = "";


    public Carro (string marca, int ano, string modelo, string motorizacao)
        :base(marca, ano)
    {
        Modelo = modelo;
        Motorizacao = motorizacao;
    }
}






















































































































































