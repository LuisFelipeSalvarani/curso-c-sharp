namespace HelloWorld;

class Program
{
    enum Cores{
        Vermelho,
        Azul,
        Amarelo
    }

    static void Main()
    {
        int numero = 10;

        string autor = numero == 10 ? "felipe" : "josé";        

        Console.WriteLine(autor);
    }
}
