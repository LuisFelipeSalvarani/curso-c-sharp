namespace HelloWorld;

class Program
{
    static void Main()
    {
        var metematica = new OperacoesMatematicas();

        metematica.Adicionar(valor1: 1, valor2: 7);

        metematica.Subtrair(valor2: 1, valor1: 7);
    }
}
