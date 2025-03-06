using HelloWorld.Teste;

namespace HelloWorld;

class Program
{
    static void Main()
    {
        char letra = 'a';
        char numero = '1';
        char caracter = '@';
        char espaco = ' ';

        string texto = "Este curso é muito bom";
        char primeiraLetraDoTexto = texto[0];

        string meuNome = "              Felipe           ";
        string nomeSemEspaco = meuNome.Trim();

        string textoAposReplace = nomeSemEspaco.Replace("e", "3");

        Console.WriteLine(meuNome);
        Console.WriteLine(nomeSemEspaco);
        Console.WriteLine(textoAposReplace);

        bool existe = texto.Equals("Este curso é muito bom.");

        Console.WriteLine(existe);
    }
}
