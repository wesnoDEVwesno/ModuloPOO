
// using static System.Console;



// abstract class Veiculo

// {
//     public string Marca {get; private set;} = "";
//     public int Ano {get; private set;}

//     //////////////////////////////////
    
//     public Veiculo (string marca, int ano)
//     {
//         Marca = marca;
//         Ano = ano;
//     }

//     public abstract void Acelerar();
// }

// class Carro : Veiculo

// {
//     public string Modelo {get; private set;} = "";
//     public double Motorização {get; private set;}

//     ///////////////////////////////////////////////
    
//     public Carro (string marca, int ano, string modelo, double motorização)
//         : base(marca, ano)
//     {
//         Modelo = modelo;
//         Motorização = motorização;
//     }

//     public override void Acelerar()
//     {   
//         WriteLine($"O {Marca} {Modelo}, ano {Ano}, está acelerando...");
//     }
// }


// class Moto : Veiculo

// {
//     public string Cilindrada {get; private set;}
//     public string Modelo {get; private set;}

//     public override void Acelerar()
//     {
//         WriteLine($"Essa moto é da marca: {Marca}");
//     }


//     public Moto (string marca, int ano, string modelo, string cilindrada)
//         : base (marca, ano)
//     {   
//         Modelo = modelo;
//         Cilindrada = cilindrada;
//     }

// }


// class Program

// {
//     static void Main()
    
//     {
//         Veiculo carro1 = new Carro ("Fiat", 2015, "Toro", 4.4);
//         WriteLine();
//         ///////////////////////////////////////////
//         Veiculo moto1 = new Moto ("Honda", 2024,"CB 500F", "500cc");
//         ///////////////////////////////////////////
//         List<Veiculo> veiculos = new List<Veiculo>();
//         veiculos.Add(carro1);
//         veiculos.Add(moto1);

//         foreach (Veiculo veiculo in veiculos)
//         {
//             veiculo.Acelerar();
//         }
//         WriteLine();
//     }
// }


// 📘 Próxima: Aula 7 — Interfaces (interface)






















