





abstract class Veiculo

{
    public string Marca {get; private set;} = "";
    public int Ano {get; private set;}


    public Veiculo (string marca, int ano)
    {
        Marca = marca;
        Ano = ano;
    }
    public abstract void Acelerar (); 
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


    // public void Informações()

    // {   
    //     Console.WriteLine($"Marca: {Marca}");
    //     Console.WriteLine($"Ano: {Ano}");
    //     Console.WriteLine($"Modelo: {Modelo}");
    //     Console.WriteLine($"Motorização: {Motorizacao}");
    // }

    public override void Acelerar()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Motorização: {Motorizacao}");
        Console.WriteLine($"Carro está acelerando {Modelo}");
    }
}




class Program

{
    static void Main()
    {
        Veiculo carro1 = new Carro ("Marca: Volkswagen", 2024, "Golf GTI", "2.0 Turbo");
        carro1.Acelerar();
    }
}

















































































































































