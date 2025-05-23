using Metodos;
using Metodos.Utils;

internal class Program
{
    // Parâmetros opcionais
    static int Somar(int x, int y = 20, int z = 30, int w = 40)
    {
        return x + y + z + w;
    }

    static void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"{destino} - {titulo} - {assunto}");
    }

    static void Main(string[] args)
    {
        var resultado1 = Somar(100);
        var resultado2 = Somar(100, 200);
        var resultado3 = Somar(100, 200, 300);
        var resultado4 = Somar(100, 200, 300, 400);

        Console.WriteLine(resultado1);
        Console.WriteLine(resultado2);
        Console.WriteLine(resultado3);
        Console.WriteLine(resultado4);
        Console.WriteLine();

        //Argumentos nomeados
        Enviar(destino: "wil@gmail.com", assunto: "teste", titulo: "Urgente");

        Enviar(assunto: "Enviar rascunho do projeto", titulo: "Enviar rascunho",
            destino: "wil@gmail.com");

        Enviar(titulo: "Ligar urgente", destino: "wil@gmail.com", 
            assunto: "Ligar para o diretor");
        
        Console.WriteLine();

        //Métodos estáticos
        /* Podemos acessar membros declarados como static em uma classe
        sem criar uma instância da classe */
        Console.WriteLine($"Soma = {Calculadora.Somar(8, 2)}");
        Console.WriteLine($"Subtração = {Calculadora.Subtrair(8, 2)}");
        Console.WriteLine();

        //Métodos de extensão
        var palavra1 = "curso";
        var palavra2 = "madalena";

        palavra1 = palavra1.CaixaAltaPrimeiraLetra();
        palavra2 = palavra2.CaixaAltaPrimeiraLetra();
        Console.WriteLine(palavra1);
        Console.WriteLine(palavra2);
    }
}