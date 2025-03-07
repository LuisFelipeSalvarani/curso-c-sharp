namespace HelloWorld;

class Program
{
    static void Main()
    {
        int? idade = null;

        bool informouIdade = idade.HasValue;
        int minhaIdade = idade.Value;
    }
}
