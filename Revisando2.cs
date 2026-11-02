
using static System.Console;







// // List<int> pontuações = new List<int>();


// // Console.WriteLine("Informe cinco pontuações inteiras: ");
// // for (int vezes = 0; vezes < 5; vezes++)
// // {
// //     string info = Console.ReadLine();
// //     int valor;
// //     int.TryParse(info, out valor);

// //     pontuações.Add(valor);
// // }

// // int somar = 0;

// // foreach (int numeros in pontuações)
// // {
// //     somar+=numeros;
// // }
// // double media = somar/5.0;
// // Console.WriteLine($"A média das pontuações: {media}");
// // // Console.WriteLine(somar);


// // 📘 Revisão aleatória — Tarefa 1
// // Tema: Sistema de Jogos 🎮


        
// class Personagem

// {
//     public string Nome {get; private set;} = "";
//     public int Nível {get; private set;}
//     public int Vida {get; private set;}
//     public int Dano {get; private set;}


//     public Personagem (string nome, int nível, int vida, int dano)
//     {
//         Nome = nome;
//         Nível = nível;
//         Vida = vida;
//         Dano = dano;
//     }

//     // 📘 Revisão aleatória — Tarefa 2
//     // Tema: Métodos dentro de classes

//     public void ExibirInformações()
//     {
//         WriteLine($"Nome do personagem: {Nome}");
//         WriteLine($"Nível do {Nome}: {Nível}");
//         WriteLine($"Vida total do {Nome}: {Vida}");
//     }

//     public bool EstaVivo()
//     {
        
//         if (Vida > 0)
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }

//     public void ReceberDano (int dano)
//     {
//         if (dano > 0)
//         {
//             Vida-=dano;
//             if(Vida <0)
//             {
//                 Vida=0;
//             }
//         }
//         else
//         {
//              WriteLine("Dano inválido");
//         }
//     }
// }   

// class Imprimir

// {
//     static void Main()
//     {
//         Personagem personagem = new Personagem ("Arthur",15,100,23);
//         WriteLine();
//         personagem.ReceberDano(150);
//         personagem.ExibirInformações();
//         bool status = personagem.EstaVivo();
//         WriteLine($"Vivo? {status}");
//         WriteLine();
//     }       
// }


// class Portas

// {
//     public string Porta1 {get; set;} = "";
//     public string Porta2 {get; set;} = "";
//     public string Porta3 {get; set;} = "";


//     public Portas(string porta1,string porta2,string porta3)
//     {
//         Porta1 = porta1;
//         Porta2 = porta2;
//         Porta3 = porta3;   
//     }
    
//     public void EscolherPorta ()
//     {
//         for (int rodadas = 0; rodadas <3; rodadas++)
//         {
//             int valor; 
//             Console.WriteLine("Qual porta você escolhe: 1, 2, ou 3?");
//             string escolha = Console.ReadLine()!;
//             int.TryParse(escolha, out  valor);
            
//             if (valor == 1)
//             {
//                 Console.WriteLine(Porta1);
//             }
//             else if (valor == 2)
//             {
//                 Console.WriteLine(Porta2);
//             }
//             else if (valor == 3)
//             {
//                 Console.WriteLine(Porta3);
//             }
            
//             else
//             {
//                 Console.WriteLine("Opção inválida");
//             }
//         }

//     }
// }


// class Imprimir

// {
//     static void Main()
//     {
//         Portas portas1 = new Portas ("Porta aberta", "Porta premiada", "Porta fechada");
//         portas1.EscolherPorta();
//     }
// }




class JogoCasa10

{
    public string Nome {get; private set;} = "";
    public int PosiçãoJogador {get; private set;}


    public JogoCasa10(string nome)
    {
        Nome = nome;
        PosiçãoJogador = 0;
    }

    public void ExibirInformações()
    {
        WriteLine($"Jogador: {Nome}");
        WriteLine($"Posição atual: {PosiçãoJogador}");
    }

    public int Movimentar(int casas)
    {
        int Soma = PosiçãoJogador+casas;
        if (Soma >= 0)
        {
            PosiçãoJogador = Soma;
        }
    return PosiçãoJogador;
    }

    public bool UltrapassouLimite()
    {
        if (PosiçãoJogador > 10)
        {
            return true;
            
        }
        
        else
        {
            return false;
        }
    }


    public void ExibirSituação ()
    {
        if (UltrapassouLimite() == true)
        {
            WriteLine("Você ultrapassou o limite, perdeu!");
        }
        
        else
        {
            WriteLine($"Sua posição atual {PosiçãoJogador}. Continue jogando...");
        }
    }
}

class Program

{
    static void Main()
    {
        JogoCasa10 jogoCasa10 = new JogoCasa10 ("Erick");
        {
            WriteLine();
            jogoCasa10.ExibirInformações();
            jogoCasa10.ExibirSituação();   
            jogoCasa10.Movimentar(3);
            jogoCasa10.ExibirSituação();
            jogoCasa10.Movimentar(25);
            jogoCasa10.ExibirSituação();
            WriteLine();

            ////////////////////////////

            if (jogoCasa10.UltrapassouLimite())
            {
                WriteLine("Você ultrapassou o limimte de casas, não tem mais movimentos!");
            }
            else
            {
                jogoCasa10.Movimentar(2);
            }
        }
    }
}



























































































































































