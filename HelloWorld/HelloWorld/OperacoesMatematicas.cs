namespace HelloWorld;

public class OperacoesMatematicas
{
    public static int Adicionar(int valor1, int valor2) => valor1 + valor2;
    

    public (int resultado, string autor) Subtrair(int valor1, int valor2)
    {
        var resultado = valor1 - valor2;

       return (resultado, "felipe");
    }

    public void Teste(int valor1, int valor2 = 7)
    {
        Console.WriteLine(valor1 + valor2);
    }
}
