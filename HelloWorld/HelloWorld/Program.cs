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
        int numero = -10;
        double saldo = 100.50;
        bool ativo = true;
        string autor = "Felipe";
        List<int> lista = new List<int> { 1, 7};
        Cores cor = Cores.Azul;

        if(numero > 0)
        {
            Console.WriteLine("Este numero é POSITIVO");
        } else if (numero == 0)
        {
            Console.WriteLine("Este numero é NEUTRO");
        }
        else
        {
            Console.WriteLine("Este numero é NEGATIVO");
        }

        if(saldo > 100.0)
        {
            Console.WriteLine("Este numero é POSITIVO");
        } else if (saldo == 0.0)
        {
            Console.WriteLine("Este numero é NEUTRO");
        }
        else
        {
            Console.WriteLine("Este numero é NEGATIVO");
        }

        if (ativo)
        {
            Console.WriteLine("VERDADEIRO");
        }
        else
        {
            Console.WriteLine("FALSO");
        }

        if(autor.Equals("Felipe"))
        {
            Console.WriteLine("O nome é igual");
        }

        if(lista.Contains(7))
        {
            Console.WriteLine("Contém");
        }

        if(cor == Cores.Azul)
        {
            Console.WriteLine("Cor é igual");
        }

        if(cor == Cores.Azul || numero >= 0)
        {
            Console.WriteLine("Entrou");
        }
    }
}
