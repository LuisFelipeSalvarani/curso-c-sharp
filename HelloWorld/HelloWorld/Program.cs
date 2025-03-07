namespace HelloWorld;

class Program
{
    static void Main()
    {
        var matematica = new OperacoesMatematicas();

        int soma = matematica.Adicionar(valor1: 1, valor2: 7);

        //Console.WriteLine(soma);

        //var resultado = metematica.Subtrair(valor2: 1, valor1: 7);

        //Console.WriteLine(resultado);
        //Console.WriteLine(resultado.resultado);
        //Console.WriteLine(resultado.autor);

        (int resultado, string nome) = matematica.Subtrair(valor2: 1, valor1: 7);

        //Console.WriteLine(resultado);
        //Console.WriteLine(nome);

        matematica.Teste(valor1: 2, valor2: 1);
    }
}
