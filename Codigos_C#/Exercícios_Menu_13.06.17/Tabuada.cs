using System;

class Tabuada
{
    public static void Main()
    {
        int NumeroTabuada=0;
        int Tabuada=0;

        Console.WriteLine("Informe o número da tabuada: ");
        NumeroTabuada = int.Parse(Console.ReadLine());

        for (int X = 1; X <=10; X++)
        {
            Tabuada=NumeroTabuada*X;
            Console.WriteLine(NumeroTabuada + "X" + X + "=" + Tabuada);
        }
        Console.ReadLine();
    }
}