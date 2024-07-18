namespace rocketseat_challenge_fundamentos.practicalExerciseOne;

public class nameComplete
{
    public void completeName()
    {
        Console.Write("Digita seu nome: ");
        string firstName = Console.ReadLine();

        Console.Write("Digite seu Sobrenome: ");
        string lastName = Console.ReadLine();

        Console.Write($"{firstName} {lastName}");
    }
}
