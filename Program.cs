



// 📚 Módulo POO — Aula 1: Classes e Objetos
// 📚 Aula 1 — O que são Classes e Objetos?



// /* class Livro
// {

// } */


// // 📚 Aula 1 — Etapa 2: Atributos

// /* class Livro
// {
//     public string Titulo = "";
//     public string Autor = "";
//     public int Paginas = 0;
// }
//  */


// // 📚 Aula 1 — Etapa 3: Criando um objeto


/* class Livro
{
    public string Titulo = "";
    public string Autor = "";
    public int Paginas = 0;
}


class Program
{
    
    static void Main()
    {
        Livro livro1 = new Livro();
    }

} */



// 📚 Aula 1 — Etapa 4: Preenchendo o objeto


/* 
class Livro
{
    public string Titulo = "";
    public string Autor = "";
    public int Paginas = 0;
}

class Program
{
    static void Main()
    {
        
    Livro livro1 = new Livro();
    livro1.Titulo = "Dom Casmurro";
    livro1.Autor = "Machado de Assis";
    livro1.Paginas = 256;
    }

} */


// 💻 Aula 1 — Etapa 5: Exibindo os dados

/* class Livro
{
    public string Titulo = "";
    public string Autor = "";
    public int Paginas = 0;
}

class Program
{
    static void Main()
    {
        Livro livro1 = new Livro();
        livro1.Titulo = "Dom Casmurro";
        livro1.Autor = "Machado de Assis";
        livro1.Paginas = 256;

        Console.WriteLine($"Título: {livro1.Titulo}");
        Console.WriteLine($"Autor: {livro1.Autor}");
        Console.WriteLine($"Páginas: {livro1.Paginas}");
    }
} */



// 📚 Aula 1 — Etapa 6: Criando um segundo objeto


/* class Livro
{
    public string Titulo = "";
    public string Autor = "";
    public int Paginas = 0 ;
}


class Program
{
    static void Main()
    {
        Livro livro1 = new Livro();
        livro1.Titulo = "Dom Casmurro";
        livro1.Autor = "Machado de Assis";
        livro1.Paginas = 256;
        ///////////////////
        Console.WriteLine($"Título: {livro1.Titulo}");
        Console.WriteLine($"Autor: {livro1.Autor}");
        Console.WriteLine($"Páginas: {livro1.Paginas}");
        ///////////////////
        Console.WriteLine();
        ///////////////////
        Livro livro2 = new Livro();
        livro2.Titulo = "A Metamorfose";
        livro2.Autor = "Franz Kafka";
        livro2.Paginas = 96;
        ///////////////////
        Console.WriteLine($"Título: {livro2.Titulo}");
        Console.WriteLine($"Autor: {livro2.Autor}");
        Console.WriteLine($"Páginas: {livro2.Paginas}");
    }
} */


// Aula 1 — Etapa 7: Sua primeira propriedade


/* class Livro
{
    
    public string Titulo {get; set;}= "";
    public string Autor {get; set;} = "";
    public int Paginas {get; set;} = 0;

}

class Program
{
    static void Main()
    {
        Livro livro1 = new Livro();

        livro1.Titulo = "A Metamorfose";
        livro1.Autor = "Franz Kafka";
        livro1.Paginas = 96;

        Console.WriteLine();

        Console.WriteLine($"Título: {livro1.Titulo}");
        Console.WriteLine($"Autor: {livro1.Autor}");
        Console.WriteLine($"Páginas: {livro1.Paginas}");
    }
} */

///////////////////////////////////////////////////////

// 📚 Aula 2 — Construtores


/* class Livro
{
    
    public string Titulo {get; set;} = "";
    public string Autor {get; set;} = "";
    public int Paginas {get; set;} = 0;
    public Livro (string titulo, string autor, int paginas)
    {
        Titulo = titulo;
        Autor = autor;
        Paginas = paginas;
    }
} */


// 📚 Aula 2 — Etapa 2: Utilizando o construtor


/* class Livro
{
    public string Titulo {get; set;} = "";
    public string Autor {get; set;} = "";
    public int Paginas {get; set;} = 0 ;


    public Livro (string titulo, string autor, int paginas)
    {
        Titulo = titulo;
        Autor = autor;
        Paginas = paginas;
    }
}

class Program
{
    static void Main()
    {
        Livro livro1 = new Livro ("A Metamorfose", "Franz Kafka", 96);
    }
}
 */


// 📚 Aula 2 — Etapa 3: Exibindo os dados


// class Livro
// {
//     public string Titulo {get; set;} = "";
//     public string Autor {get; set;} = "";
//     public int Paginas {get; set;} = 0;


//     public Livro (string titulo, string autor, int paginas)
//     {
//         Titulo = titulo;
//         Autor = autor;
//         Paginas = paginas;
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         Livro livro1 = new Livro ("A Metamorfose", "Franz Kafka", 96);
//         Console.WriteLine($"Título: {livro1.Titulo}");
//         Console.WriteLine($"Autor: {livro1.Autor}");
//         Console.WriteLine($"Páginas: {livro1.Paginas}");
//     }
// }


// 🎯 Revisão prática — Etapa 4



// class Livro
// {
//     public string Titulo {get; set;} = "";
//     public string Autor {get; set;} = "";
//     public int Paginas {get; set;} = 0;

//     public Livro (string titulo, string autor, int paginas)
//     {
//         Titulo = titulo;
//         Autor = autor;
//         Paginas = paginas;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Livro livro1 = new Livro ("A Metamorfose", "Franz Kafka",96);
//         Console.WriteLine($"Título: {livro1.Titulo}");
//         Console.WriteLine($"Autor: {livro1.Autor}");
//         Console.WriteLine($"Páginas: {livro1.Paginas}");
//         /////////////////////
//     {   Console.WriteLine();
//         /////////////////////
//         Livro livro2 = new Livro ("Crime e Castigo", "Fiódor Dostoiévski",592);
//         Console.WriteLine($"Título: {livro2.Titulo}");
//         Console.WriteLine($"Autor: {livro2.Autor}");
//         Console.WriteLine($"Páginas: {livro2.Paginas}");
//     }
//     }
// }


// 💻 Aula 3 — Métodos dentro de classes

// 🎯 Etapa 1 — Criando um método na classe


// class Livro
// {
//     public string Titulo {get; set;} = "";
//     public string Autor {get; set;} = "";
//     public int Paginas {get; set;} = 0;

//     public Livro (string titulo, string autor, int paginas)
//     {
//         Titulo = titulo;
//         Autor = autor;
//         Paginas = paginas;
//     }

//     public void ExibirInformações()
//     {
//         Console.WriteLine($"Título: {Titulo}");   
//         Console.WriteLine($"Autor: {Autor}");   
//         Console.WriteLine($"Páginas: {Paginas}");  

//     }

//         // Aula 3 — Etapa 3: Um pequeno desafio

//     public void VerificarLivroLongo()
//     {
//         if (Paginas > 500)
//         {
//             Console.WriteLine("Livro longo!");
//         }
//         else
//         {
//             Console.WriteLine("Livro curto ou médio!");
//         }
//     }



// }

// class Program
// {
//     static void Main()
//     {
//         Livro livro1 = new Livro ("A Metamorfose", "Franz Kafka", 96);
//         livro1.ExibirInformações();
//         /////////////////////////////////////////////
//         Console.WriteLine();
//         ////////////////////////////////////////////
//         Livro livro2 = new Livro ("Crime e Castigo", "Fiódor Dostoievski", 592);
//         Console.WriteLine($"Título: {livro2.Titulo}");
//         Console.WriteLine($"Autor: {livro2.Autor}");
//         Console.WriteLine($"Páginas: {livro2.Paginas}");
//         livro2.VerificarLivroLongo();
//     }
// }


// // 📚 Aula 3 — Etapa concluída!


// 📚 Aula 3 — Etapa 4: Métodos com retorno


// class Livro
// {
//     public string Titulo {get; set;} = "";
//     public string Autor {get; set;} = "";
//     public int Paginas {get; set;} = 96;

//     public Livro (string titulo, string autor, int paginas)
//     {
//         Titulo = titulo;
//         Autor = autor;
//         Paginas = paginas;
//     }    

//     public void ExibirInformações()
//     {
//         Console.WriteLine($"Titulo: {Titulo}");
//         Console.WriteLine($"Autor: {Autor}");
//         Console.WriteLine($"Páginas: {Paginas}");
//     }

//     public void VerificarLivroLongo()
//     {
//         if (Paginas > 500)
//         {
//             Console.WriteLine("Livro longo!");
//         }
//         else
//         {
//             Console.WriteLine("Livro curto ou médio!");
//         }
//     }

//     public bool EhLivroLongo()
//     {
//         return Paginas > 500;
//     }
// }

// class Program
// {
//     static void Main()
//     {   
//         Livro livro1 = new Livro ("A Metamorfose", "Franz Kafka", 96);
//         livro1.ExibirInformações();
//         bool resultado1 = livro1.EhLivroLongo();
//         Console.WriteLine($"A Metamorfose: {resultado1}");
//         //////////////////////////
//         Console.WriteLine();
//         /////////////////////////;
//         Livro livro2 = new Livro ("Crime e Castigo", "Fiódor Dostoievski", 592);
//         Console.WriteLine($"Título: {livro2.Titulo}");
//         Console.WriteLine($"Autor: {livro2.Autor}");
//         Console.WriteLine($"Páginas: {livro2.Paginas}");
//         livro2.VerificarLivroLongo();
//         bool resultado2 = livro2.EhLivroLongo();
//         Console.WriteLine($"Crime e Castigo: {resultado2}");
//         //////////////////////////

//     }
// }


// class Funcionario
// {
//     public string Nome {get; set;} = "";
//     public string Cargo {get; set;} = "";
//     public double Salario {get; set;}

//     public Funcionario (string nome, string cargo, double salario)
//     {
//         Nome = nome;
//         Cargo = cargo;
//         Salario = salario;
//     }

//     public void ExibirInformações ()
//     {
//         Console.WriteLine($"Nome: {Nome}");
//         Console.WriteLine($"Cargo: {Cargo}");
//         Console.WriteLine($"Salário: {Salario:C2}");
//     }

//     public bool RecebeSalarioAlto()
//     {
//         return Salario > 3000;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Funcionario funcionario1 = new Funcionario ("Erick", "Desenvolvedor", 5400);
//         funcionario1.ExibirInformações();

//         bool resultado1 = funcionario1.RecebeSalarioAlto();
//         Console.WriteLine($"Recebe salário alto > {resultado1}");

//         Console.WriteLine();

//         Funcionario funcionario2 = new Funcionario ("Letícia", "Secretária", 1200);
//         funcionario2.ExibirInformações();
//         bool resultado2 = funcionario2.RecebeSalarioAlto();
//         Console.WriteLine($"Recebe salário alto > {resultado2}");

//         Console.WriteLine();

//         Funcionario funcionario3 = new Funcionario ("Erika", "Organizadora", 2900);
//         funcionario3.ExibirInformações();
//         bool resultado3 = funcionario3.RecebeSalarioAlto();
//         Console.WriteLine($"Recebe salário alto > {resultado3}");
//     }
// }


// 📚 Revisão prática — Exercício 2: Sistema de Estoque



// class Produto

// {
//     public string Nome {get; set;} = "";
//     public double Preco {get; set;}
//     public int Quantidade {get; set;}


//     public Produto(string nome, double preco, int quantidade)
//     {
//         Nome = nome;
//         Preco = preco;
//         Quantidade = quantidade;
//     }

//     public void ExibirInformações()
//     {
//         Console.WriteLine($"Nome: {Nome}");
//         Console.WriteLine($"Preço: {Preco:C2}");
//         Console.WriteLine($"Quantidade: {Quantidade}");
//     }

//     public double CalcularValorEstoque()
//     {
//         return Preco * Quantidade;
//     }
// }


// class Program

// {
//     static void Main()
//     {
//         Produto produto1 = new Produto("Notebook", 3500, 8);
//         Console.WriteLine();
//         produto1.ExibirInformações();
//         Console.WriteLine();
//         double valorTotal = produto1.CalcularValorEstoque();
//         Console.WriteLine($"Valor total de {produto1.Nome} em estoque: {valorTotal:C2}");

//         ////////////////////////////////////////////////////

//         Produto produto2 = new Produto("Mouse Gamer", 150, 12);
//         Console.WriteLine();
//         produto2.ExibirInformações();
//         Console.WriteLine();
//         double valorTota2 = produto2.CalcularValorEstoque();
//         Console.WriteLine($"Valor total de {produto2.Nome} em estoque: {valorTota2:C2}");

//         ////////////////////////////////////////////////////

//         Produto produto3 = new Produto("Teclado Mecânico", 1400, 15);
//         Console.WriteLine();
//         produto3.ExibirInformações();
//         Console.WriteLine();
//         double valorTota3 = produto3.CalcularValorEstoque();
//         Console.WriteLine($"Valor total de {produto3.Nome} em estoque: {valorTota3:C2}");
//     }
// }


// 📚 Módulo POO — Aula 3
// 🏦 Sistema Bancário

// class ContaBancaria

// {
//     public string Titular {get; set;} = "";
//     public int NumeroConta {get; set;}
//     public double Saldo {get; set;}

//     public ContaBancaria (string titular, int numeroconta, double saldo)
//     {
//         Titular = titular;
//         NumeroConta = numeroconta;
//         Saldo = saldo;
//     }


//     public void ExibirInformações ()
//     {
//         Console.WriteLine($"Titular da conta: {Titular}");
//         Console.WriteLine($"Número da conta: {NumeroConta}");
//         Console.WriteLine($"Saldo em conta: {Saldo:C2}");
//     }

//     public void Depositar(double valor)
//     {
//         if (valor > 0)
//         {
//             Saldo+=valor;
//         }
//         else
//         {
//             Console.WriteLine("Valor de depósito inválido!");
//         }

//     }
//     public void Sacar(double valores)
//     {
//         if (valores > 0 && valores <= Saldo)
//         {
//             Saldo-=valores;
//         }
//         else
//         {
//             Console.WriteLine("Valor de saque inválido!");
//         }
//     }
// }


// class Program

// {
//     static void Main()
//     {
//         ContaBancaria contaBancaria1 = new ContaBancaria("Erick", 45263359, 4561);
//         Console.WriteLine();
//         contaBancaria1.ExibirInformações();
//         Console.WriteLine();
//         /////////////////////////////
//         contaBancaria1.Depositar(500);
//         Console.WriteLine();
//         contaBancaria1.ExibirInformações();
//         /////////////////////////////
//         contaBancaria1.Sacar(1000);
//         Console.WriteLine();
//         contaBancaria1.ExibirInformações();
//         ////////////////////////////
//         contaBancaria1.Sacar(10000);
//         Console.WriteLine();
//         contaBancaria1.ExibirInformações();
//         ////////////////////////////
//         contaBancaria1.Sacar(-500);
//         Console.WriteLine();
//         contaBancaria1.ExibirInformações();

//     }
// }



// 📚 Módulo POO — Aula 4: Encapsulamento 🔐



// class ContaBancaria
// {
//     public string Titular = "";
//     public int NumeroConta {get; private set;}
//     public double Saldo {get; private set;}


//     public ContaBancaria (string nome, int numeroconta, double saldo)
//     {
//         Titular = nome;
//         NumeroConta = numeroconta;
//         Saldo = saldo;
//     }

//     public void ExibirInformações()
//     {
//         Console.WriteLine($"Titular: {Titular}");
//         Console.WriteLine($"Numero da conta: {NumeroConta}");
//         Console.WriteLine($"Saldo em disponível: {Saldo:C2}");
//     }

//     public void Depositar(double valor)
//     {
//         if (valor > 0)
//         {
//             Saldo+=valor;
//         }
//         else
//         {
//             Console.WriteLine("Entrada inválida...");
//         }
//     }

//     public void Sacar(double valores)
//     {
//         if (valores > 0 && valores <= Saldo)
//         {
//             Saldo-=valores; 
//         }
//         else
//         {
//             Console.WriteLine("Entrada inválida!");
//         }
//     }
// }


// class Program

// {
//     static void Main()
//     {
//         ContaBancaria contaBancaria1 = new ContaBancaria ("Erick",22326, 0);
//         Console.WriteLine();
//         contaBancaria1.ExibirInformações();
//         Console.WriteLine();
//         contaBancaria1.Depositar(50);
//         contaBancaria1.Sacar(34);
//         contaBancaria1.ExibirInformações();        
//     }

// }


// 💻 Implementa sistema de biblioteca com encapsulamento e validação de livros


// class Livro

// {
//     public string Nome {get; set;} = "";
//     public string Autor {get; set;} = "";
//     public int Paginas {get; private set;}


//     public Livro (string nome, string autor, int paginas)
//     {
//         Nome = nome;
//         Autor = autor;
//         Paginas = paginas;
//     }

//     public void ExibirInformações()
//     {
//         Console.WriteLine($"Nome do livro escolhido: {Nome}");
//         Console.WriteLine($"Autor do livro escolhido: {Autor}");
//         Console.WriteLine($"Número de páginas: {Paginas}");
//     }

//     public bool LivroLongo()
//     {
//         return Paginas > 300;
//     }
// }

// class Program

// {
//     static void Main()
//     {
//         Livro livro1 = new Livro ("Crime e Castigo", "Fiódor Dostoievski", 592);

//         Console.WriteLine();
//         livro1.ExibirInformações();
//         Console.WriteLine(livro1.LivroLongo());
//         Console.WriteLine();
        
//         /////////////////////////
        
//         Livro livro2 = new Livro ("A Metamorfose", "Franz Kafka", 96);

//         livro2.ExibirInformações();
//         Console.WriteLine(livro2.LivroLongo());
//         Console.WriteLine();
//     }
// }


// 📚 Módulo POO — Aula 5: Herança



// class Livro

// {
//     public string  Nome {get; private set;} = "";
//     public string  Autor {get; private set;} = "";
//     public int  Paginas {get; private set;}



//     public Livro (string nome, string autor, int paginas)
//     {
//         Nome = nome;
//         Autor = autor;
//         Paginas = paginas;
//     }


//     public virtual void Informações ()
//     {
//         Console.WriteLine($"Livro escolhido: {Nome}");
//         Console.WriteLine($"Autor do livro escolhido: {Autor}");
//         Console.WriteLine($"Quantas páginas tem: {Paginas}");
//     }


//     public bool NumeroDePaginas ()
//     {   
//         return Paginas > 300;
//     }
// }

// class Program

// {
//     static void Main()
//     {
//         Livro livro1 = new Livro ("1984", "George Orwell", 328);
//         ////////////////////
//         Console.WriteLine();
//         livro1.Informações();
//         Console.WriteLine("Livro tem mais de 300 páginas: " + livro1.NumeroDePaginas());
        
//     }
// }

// class LivroDigital : Livro

// {
//     public double TamanhoArquivoMB {get; private set;}
//     public void ExibirTamanhoArquivo()
//     {
//         Console.WriteLine($"Tamanho do arquivo: {TamanhoArquivoMB} MB");
//     }

// /*     public override void Informações()
//     {
//         base.Informações();
//         ExibirTamanhoArquivo();
//     } */

//         public LivroDigital (string nome, string autor, int paginas, double tamanhoArquivoMB)
//         : base(nome, autor, paginas)
//     {
//         TamanhoArquivoMB = tamanhoArquivoMB;   
//     }
// }

/* class Program

{

    static void Main()
    {
        LivroDigital livroDigital = new LivroDigital("O Hobbit", "J.R.R. Tolkien", 310, 2.5);
        Console.WriteLine();
        livroDigital.Informações();
    }
} */



// class LivroFisico : Livro

// {
//     public double PesoGramas {get; private set;}
//     public void ExibirPeso()
//     {
//         Console.WriteLine($"Peso do livro: {PesoGramas}");
//     }

//     public override void Informações()
//     {
//         base.Informações();
//         ExibirPeso();
//     }

//     public LivroFisico(string nome, string autor, int paginas, double pesoGramas)
//         : base(nome, autor, paginas)
//     {
//         PesoGramas = pesoGramas;
//     }
// }


// class Program

// {   
//     static void Main()
//     {
//         LivroFisico livroFisico1 = new LivroFisico("O Senhor dos Anéis: A Sociedade do Anel","J.R.R.Tolkien", 576, 650);
//         livroFisico1.Informações();
//     }
// }


// 🧬 Aula 5 — Polimorfismo em C#

// class Funcionario
// {
//     public string Pessoa {get; private set;}
//     public int Idade {get; private set;}
//     public decimal Salario {get; private set;}

//     public Funcionario (string nome, int idade, decimal salario)
//     {
//         Pessoa = nome;
//         Idade = idade;
//         Salario = salario;
//     }

//     public virtual void Fichário ()
//     {
//         Console.WriteLine($"Funcionário selecionado: {Pessoa}");
//         Console.WriteLine($"Idade: {Idade} anos");
//         Console.WriteLine($"Salário: {Salario:C2}");
//     }
// }

// // class Imprimir

// // {
// //     static void Main()
// //     {
// //         Funcionario funcionarios = new Funcionario("Letícia", 28, 4340);
// //         funcionarios.Fichário();
// //     }
// // }


// class Desenvolvedor : Funcionario

// {
//     public string LinguagemPrincipal {get; private set;}
//     public void MostrarLinguagem()
//     {
//         Console.WriteLine($"Linguagem utilizada: {LinguagemPrincipal}");
//     }
//     public override void Fichário()
//     {
//         base.Fichário();
//         MostrarLinguagem();
//     }

//     public Desenvolvedor (string nome, int idade, decimal salario, string liguagemAtual)
//         : base(nome, idade, salario)
//     {   
//         LinguagemPrincipal = liguagemAtual;
//     }

// }

// // class Imprimir

// // {
// //     static void Main()
// //     {
// //         Funcionario desenvolvedor1 = new Desenvolvedor ("Letícia", 28, 4340, "C#");
// //         desenvolvedor1.Fichário();
// //     }
// // }


// class Designer : Funcionario

// {
//     // PROPRIEDADES:

//     public string FerramentaPrincipal {get; private set;}
//     public string LinguagemPrincipal {get; private set;}
    
//     ////////////////////////
    
//     public void MostrarLinguagem()
//     {
//         Console.WriteLine($"Linguagem utilizada: {LinguagemPrincipal}");
//     }
//     public void MostrarFerramenta()
//     {
//         Console.WriteLine($"Ferramenta usada: {FerramentaPrincipal}");
//     }

//     public override void Fichário()
//     {
//         base.Fichário();
//         MostrarFerramenta();
//         MostrarLinguagem();
//     }
    
//     // CONSTRUTORES:

//     public Designer (string nome,  int idade, decimal salario, string linguagemAtual, string ferramentaUsada)
//         :base(nome, idade, salario)
//     {
//         FerramentaPrincipal = ferramentaUsada;
//         LinguagemPrincipal = linguagemAtual;
//     }

// }

// class Imprir

// {
//     static void Main()
//     {
//         Funcionario designer1 = new Designer ("Letícia", 28, 2420, "C#", "Photoshop");
//         Funcionario desenvolvedor1 = new Desenvolvedor ("Letícia",28,2340,"C#");
    
//         List<Funcionario> funcionarios = new List<Funcionario>();
//         funcionarios.Add(desenvolvedor1);
//         funcionarios.Add(designer1);


//         foreach(Funcionario funcionario1 in funcionarios)
//         {
//             funcionario1.Fichário();
//             Console.WriteLine();
//         }
//     }
// }



// 📘 Módulo POO — Aula 6: Classes Abstratas (abstract)














