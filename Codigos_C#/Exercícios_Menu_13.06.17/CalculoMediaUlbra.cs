using System;

class MediaUlbra
{
    public static void Main()
    {
        float G1=0;
        float G2=0;
        float Media=0;

        Console.WriteLine("Digite a nota da G1: ");
        G1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota da G2: ");
        G2 = float.Parse(Console.ReadLine());

        Media=(G1+(G2*2))/3;

        Console.WriteLine("A sua media foi de: " + Media.ToString("N1"));

        if (Media>=6)
        {
            Console.WriteLine("Parabens, você atingiu a média necessaria!");
        }
        else
        {
            Console.WriteLine("Você precisa estudar mais, não atingiu a média necessaria");
        }
        
        Console.ReadLine();
    }
}
