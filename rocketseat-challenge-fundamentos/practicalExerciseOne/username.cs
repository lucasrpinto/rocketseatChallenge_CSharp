namespace rocketseat_challenge_fundamentos.practicalExerciseOne;

public class username
{
    public void userName()
    {
        Console.Write("Insira seu nome: ");

        string name = Console.ReadLine();

        Console.WriteLine($"Olá, {name}! seja muito bem vindo(a)!");    
    }
}
