using System;

class Ex1
{
    public static void Main()
    {
		int DiasDeVida=0;
        int Idade=0;
        int HorasVividas=0;

        Console.WriteLine("Digite a sua idade: ");
        Idade = int.Parse(Console.ReadLine());

        DiasDeVida=Idade*365;
        HorasVividas=DiasDeVida*24;

        Console.WriteLine("Você já viveu " + DiasDeVida + " dias" + " e " + HorasVividas + " horas");
        
        Console.ReadLine();
    }
}