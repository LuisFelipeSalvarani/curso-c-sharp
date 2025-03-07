namespace HelloWorld;

public class Carro
{
    //public required string Modelo { get; set; }
    public string Modelo { get; set; }
    public DateOnly LancadoEm { get; set; }
    public Cor Cor { get; set; }

    public Carro(string modelo)
    {
        Modelo = modelo;
    }

    public void NomeDoModelo() => Console.WriteLine(Modelo);

    //public void Ligar()
    //{
    //    Console.WriteLine("Carro LIGADO");
    //}

    //public void Desligar()
    //{
    //    Console.WriteLine("Carro DESLIGADO");
    //}

    //private void Teste1()
    //{
    //    Console.WriteLine("Teste 1");
    //}

    //internal void Teste2()
    //{
    //    Teste1();

    //    Console.WriteLine("Teste 2");
    //}
}

