namespace HelloWorld;

public class OperacoesMatematicas
{
    public int Adicionar(int valor1, int valor2) => valor1 + valor2;
    

    public (int resultado, string autor) Subtrair(int valor1, int valor2)
    {
        var resultado = valor1 - valor2;

       return (resultado, "felipe");
    }
}
