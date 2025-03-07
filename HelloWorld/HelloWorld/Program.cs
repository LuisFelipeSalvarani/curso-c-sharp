namespace HelloWorld;

class Program
{
    static void Main()
    {
        var lista = new List<string> { "Felipe", "Luis", "Vitor" };

        Console.WriteLine(lista[0]);

        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }
    }
}
