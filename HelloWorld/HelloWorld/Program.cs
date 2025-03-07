namespace HelloWorld;

class Program
{
    enum Cores{
        Vermelho,
        Azul,
        Amarelo,
        Roxo
    }

    static void Main()
    {
        string texto = "Felipe";        
        int numero = 10;
        Cores cor = Cores.Roxo;

        string resultado = numero switch
        {
            >= 10 => "Felipe",
            1 => "Wesley",
            5 => "Vitor",
            _ => "Nome desconhecido"
        };

        Console.WriteLine(resultado);

        //switch (numero)
        //{
        //    case >= 10:
        //        {
        //            Console.WriteLine("Azul");
        //        }
        //        break;
        //    case 1:
        //        {
        //            Console.WriteLine("Vermelho");
        //        }
        //        break;
        //    case 0:
        //        {
        //            Console.WriteLine("Amarelo");
        //        }
        //        break;
        //    default:
        //        {
        //            Console.WriteLine("Outra cor");
        //        }
        //        break;
        //}

        //switch (texto)
        //{
        //    case "Felipe":
        //        {
        //            Console.WriteLine("Azul");
        //        }
        //        break;
        //    case "Wesley":
        //        {
        //            Console.WriteLine("Vermelho");
        //        }
        //        break;
        //    case "Vitor":
        //        {
        //            Console.WriteLine("Amarelo");
        //        }
        //        break;
        //    default:
        //        {
        //            Console.WriteLine("Outra cor");
        //        }
        //        break;
        //}

        //switch (cor)
        //{
        //    case Cores.Azul:
        //        {
        //            Console.WriteLine("Azul");
        //        }
        //        break;
        //    case Cores.Vermelho:
        //        {
        //            Console.WriteLine("Vermelho");
        //        }
        //        break;
        //    case Cores.Amarelo:
        //        {
        //            Console.WriteLine("Amarelo");
        //        }
        //        break;
        //    default:
        //        {
        //            Console.WriteLine("Outra cor");
        //        }
        //        break;
        //}
    }
}
