namespace HelloWorld;

class Program
{
    static void Main()
    {
        var metematica = new OperacoesMatematicas();

        int soma = metematica.Adicionar(valor1: 1, valor2: 7);

        Console.WriteLine(soma);

        //var resultado = metematica.Subtrair(valor2: 1, valor1: 7);

        //Console.WriteLine(resultado);
        //Console.WriteLine(resultado.resultado);
        //Console.WriteLine(resultado.autor);

        (int resultado, string nome) = metematica.Subtrair(valor2: 1, valor1: 7);

        Console.WriteLine(resultado);
        Console.WriteLine(nome);
    }
}
