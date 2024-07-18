public class sumDouble
{
    public void doubleNumber()
    {
        double number1 = 14.5;
        double number2 = 2.7;


        double sum = number1 + number2;
        Console.WriteLine($"A soma dos dois núneros é {sum}");

        double sub = number1 - number2;

        Console.WriteLine($"A subtração dos dois números é {sub}");

        double mult = number1 * number2;

        string formatado = mult.ToString("F2");

        Console.WriteLine($"A multiplicação dos dois números é {mult}, o resultado formatado fica {formatado}");

        // Verifica na divisão se o denominador não é 0
        if (number2 == 0)
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
        }
        else
        {
            // Realiza a divisão
            double resultado = number1 / number2;
            string resFormat = resultado.ToString("F2");
            Console.WriteLine($"A divisão dos dois números é  {resFormat}");
        }

        double calcMedia = (number1 + number2) / number2;
        string media = calcMedia.ToString("F2");

        Console.WriteLine($"A média dos dois número é {media}");
    }
}