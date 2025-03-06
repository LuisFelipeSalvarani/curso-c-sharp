using System.Globalization;

namespace HelloWorld;

class Program
{
    static void Main()
    {
        DateOnly dia = new DateOnly(2023, 12, 1);

        //string diaEmTexto = dia.ToShortDateString();
        //string diaEmTexto = dia.ToLongDateString();
        string diaEmTexto = dia.ToString("dd/MMMMM/yyyy", new CultureInfo("pt-BR"));

        DateTime diaHora = new DateTime(2023, 12, 1, 20, 07, 1);

        //DateTime hojeComHora = DateTime.Now;
        DateTime hojeComHora = DateTime.UtcNow;
        DateTime hoje = DateTime.Today;

        DateTime novaData = hoje.AddDays(1);

        Console.WriteLine(hojeComHora);
        Console.WriteLine(novaData);
    }
}
