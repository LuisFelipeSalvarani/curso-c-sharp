using System.Text;

namespace HelloWorld;

class Program
{
    static void Main()
    {
        //string texto1 = "A primeira frase.";
        //string texto2 = "Segunda frase";

        //string paragrafo = texto1 + " " + 7 + " " + true + " " + texto2;
        //string paragrafo2 = $"{texto1} {7} {true} {texto2}";

        ////string caminho = "C:\\teste";
        //string caminho = @"C:\teste";

        //StringBuilder stringBuilder = new StringBuilder();

        //stringBuilder.Append(paragrafo);
        //stringBuilder.Append(paragrafo2);

        //string resultado = stringBuilder.ToString();

        //Console.WriteLine(resultado);

        string texto = "O usuário {0} gosta do numero {1}";

        string resultado = string.Format(texto, "Felipe", 13);

        Console.WriteLine(resultado);
    }
}
