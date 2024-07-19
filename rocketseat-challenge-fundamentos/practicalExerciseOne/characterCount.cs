namespace rocketseat_challenge_fundamentos.practicalExerciseOne;

public class characterCount
{
    public void countChar()
    {
        Console.Write("Digite algo: ");
        string res = Console.ReadLine();

        string resWithoutSpaces = res.Replace(" ", "");

        Console.WriteLine($"A frase inserida tem {res.Length} caracteres (Contanto os espaços). E tem {resWithoutSpaces.Length} letras (Sem contar os espaços)");
    }
}
