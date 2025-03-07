namespace HelloWorld;

class Program
{
    static void Main()
    {
        //var carro = new Carro("Lamborghini");

        //carro.NomeDoModelo();

        var carro = new Carro("Lamborghini")
        {
            LancadoEm = new DateOnly(2020, 01, 01),
            Cor = Cor.Amarelo
        };

        var carro2 = new Carro("Porsche")
        {
            LancadoEm = new DateOnly(2019, 01, 01),
            Cor = Cor.Azul
        };

        carro.NomeDoModelo();
        carro2.NomeDoModelo();

        //carro.Modelo = "Lamborghini";
        //carro.Cor = Cor.Amarelo;
        //carro.LancadoEm = new DateOnly(2020, 01, 01);

        //carro.NomeDoModelo();
    }
}
