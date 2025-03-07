namespace HelloWorld;

class Program
{
    static void Main()
    {
        //Dictionary<int, string> dicionario = new Dictionary<int, string>();

        //dicionario.Add(1, "Felipe");
        //dicionario.Add(2, "Marcio");
        //dicionario.Add(7, "Willian");

        //int value = dicionario[7];

        //Console.WriteLine(value);
        
        Dictionary<string, int> dicionario = new Dictionary<string, int>();

        dicionario.Add("Felipe", 1);
        dicionario.Add("Marcio", 2);
        dicionario.Add("Willian", 7);

        int value = dicionario["Willian"];

        bool existe = dicionario.ContainsKey("Maria");

        Console.WriteLine(value);
        Console.WriteLine(existe);
    }
}
