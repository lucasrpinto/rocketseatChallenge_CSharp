namespace rocketseat_challenge_fundamentos.practicalExerciseOne;

public class boardChecker
{
    public void board()
    {
        Console.Write("Digite a placa do veículo: ");
        string placa = Console.ReadLine();

        // Verifica se a placa tem exatamente 7 caracteres
        if (placa.Length == 7)
        {
            // Verifica se os três primeiros caracteres são letras maiúsculas e os quatro últimos são números
            bool isValid = true;

            for (int i = 0; i < 3; i++)
            {
                if (!char.IsLetter(placa[i]) || !char.IsUpper(placa[i]))
                {
                    isValid = false;
                    break;
                }
            }

            for (int i = 3; i < 7; i++)
            {
                if (!char.IsDigit(placa[i]))
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                Console.WriteLine("A placa é válida.");
            }
            else
            {
                Console.WriteLine("A placa é inválida. A placa deve ter 3 letras maiúsculas seguidas por 4 números.");
            }
        }
        else
        {
            Console.WriteLine("A placa é inválida. A placa deve ter exatamente 7 caracteres.");
        }
    }
}
