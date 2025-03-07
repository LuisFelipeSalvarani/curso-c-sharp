namespace HelloWorld;

class Program
{
    static void Main()
    {
        var lista = new List<string> { "Felipe", "Luis", "Vitor" };
        var dicionario = new Dictionary<string, string>();

        dicionario.Add("Nome1", "Felipe");
        dicionario.Add("Nome2", "Luis");
        dicionario.Add("Nome3", "Vitor");

        foreach (var nome in lista)
            Console.WriteLine(nome);
        

        foreach (var item in dicionario)
        {
            Console.WriteLine(item.Key);
            Console.WriteLine(item.Value);
        }
    }
}
