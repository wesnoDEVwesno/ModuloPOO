



// 📚 Módulo POO — Aula 1: Classes e Objetos
// 📚 Aula 1 — O que são Classes e Objetos?



/* class Livro
{
    
} */


// 📚 Aula 1 — Etapa 2: Atributos

/* class Livro
{
    public string Titulo = "";
    public string Autor = "";
    public int Paginas = 0;
}
 */


// 📚 Aula 1 — Etapa 3: Criando um objeto



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


class Funcionario
{
    public string Nome {get; set;} = "";
    public string Cargo {get; set;} = "";
    public double Salario {get; set;}

    public Funcionario (string nome, string cargo, double salario)
    {
        Nome = nome;
        Cargo = cargo;
        Salario = salario;
    }

    public void ExibirInformações ()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Salário: {Salario:C2}");
    }

    public bool RecebeSalarioAlto()
    {
        return Salario > 3000;
    }
}

class Program
{
    static void Main()
    {
        Funcionario funcionario1 = new Funcionario ("Erick", "Desenvolvedor", 5400);
        funcionario1.ExibirInformações();
        
        bool resultado1 = funcionario1.RecebeSalarioAlto();
        Console.WriteLine($"Recebe salário alto > {resultado1}");

        Console.WriteLine();

        Funcionario funcionario2 = new Funcionario ("Letícia", "Secretária", 1200);
        funcionario2.ExibirInformações();
        bool resultado2 = funcionario2.RecebeSalarioAlto();
        Console.WriteLine($"Recebe salário alto > {resultado2}");
        
        Console.WriteLine();

        Funcionario funcionario3 = new Funcionario ("Erika", "Organizadora", 2900);
        funcionario3.ExibirInformações();
        bool resultado3 = funcionario3.RecebeSalarioAlto();
        Console.WriteLine($"Recebe salário alto > {resultado3}");
    }
}


// 📚 Revisão prática — Exercício 2: Sistema de Estoque



class Produto

{
    public string Nome {get; set;} = "";
    public double Preco {get; set;}
    public int Quantidade {get; set;}


    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public void ExibirInformações()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: {Preco:C2}");
        Console.WriteLine($"Quantidade: {Quantidade}");
    }

}













































