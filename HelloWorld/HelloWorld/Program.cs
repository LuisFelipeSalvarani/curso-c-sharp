namespace HelloWorld;

class Program
{
    static void Main()
    {
        List<int> inteiros = new List<int>();

        inteiros.Add(1);
        inteiros.Add(2);

        //inteiros.Remove(1);
        //inteiros.RemoveAt(0);
        inteiros.Clear();

        //int primeiroElemento = inteiros.First();
        //int primeiroElemento = inteiros.ElementAt(1);
        //int ultimoElemento = inteiros.Last();

        Console.WriteLine(inteiros.Count);
        //Console.WriteLine(inteiros[0]);
        //Console.WriteLine(primeiroElemento);
        //Console.WriteLine(ultimoElemento);

        List<string> strings = new List<string>();

        strings.Add("Hello");
        strings.Add("World");
        strings.Add("Felipe");
        strings.Add("Salvarani");

        string resultado = string.Join(" ", strings);

        Console.WriteLine(resultado);

        List<int> ints = new List<int>();
        ints.Add(1);

        List<decimal> decimals = new List<decimal>();
        decimals.Add(2.5m);

        List<bool> bools = new List<bool>();
        bools.Add(true);

        List<object> objetos = new List<object>();

        objetos.Add("Hello");
        objetos.Add(7);
        objetos.Add(true);

        Console.WriteLine(objetos.Count);
    }
}
