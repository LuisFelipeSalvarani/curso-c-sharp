namespace HelloWorld;

class Program
{
    static void Main()
    {
        int numero = 10;

        var meuCarro = new Carro("Porsche")
        {
            Cor = Cor.Vermelho,
            LancadoEm = new DateOnly(2020, 1, 1)
        };

        meuCarro.NomeDoModelo();

        Console.WriteLine("Oi");
    }
}
