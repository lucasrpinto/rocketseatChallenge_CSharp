namespace rocketseat_challenge_fundamentos.practicalExerciseOne;

public class currenteDate
{
    public void dataCurrente()
    {
        DateTime now = DateTime.Now;

        Console.WriteLine("Escolhar o formato e exibição da data:");
        Console.WriteLine("1 - Formato Completo");
        Console.WriteLine("2 - Apenas a data no formato \"01/03/2024\"");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
        Console.WriteLine("4 - A data com o mês por extenso");

        int opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                Console.WriteLine("Formato completo: " + now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
                break;
            case 2:
                Console.WriteLine("Apenas a data: " + now.ToString("dd/MM/yyyy"));
                break;
            case 3:
                Console.WriteLine("Apenas a hora: " + now.ToString("HH:mm"));
                break;
            case 4:
                Console.WriteLine("Data com o mês por extenso: " + now.ToString("dd 'de' MMMM 'de' yyyy"));
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}
