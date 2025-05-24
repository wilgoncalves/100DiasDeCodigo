namespace Metodos;

public class Calculadora
{
    // Sobrecarga de métodos Somar
    public static string Somar()
    {
        return "Nenhum parâmetro foi fornecido";
    }

    public static int Somar(int numero1, int numero2)
    {
        return numero1 + numero2;
    }

    // parâmetros opcionais
    public static int Somar(int numero, int x = 3, int y = 8, int z = 10)
    {
        return numero + x + y + z;
    }

    public static double Somar(double numero1, double numero2)
    {
        return numero1 + numero2;
    }

    public static int Subtrair(int numero1, int numero2)
    {
        return numero1 - numero2;
    }
}
