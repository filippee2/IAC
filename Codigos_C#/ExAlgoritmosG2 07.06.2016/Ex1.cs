using System;

class Ex1
{
    public static void Main()
    {
		int Dia = 0;
		int DiaMenorPeso=0;
		int Cont=1;
		float Peso;
		float MenorPeso=50000;

        do
        {
            do
            {
                Console.WriteLine("Digite um dia da semana: ");
                Dia = int.Parse(Console.ReadLine());
                if ((Dia<1) || (Dia>7))
                {
                    Console.WriteLine("Digite um dia valido!");
                }
            } while ((Dia<1) || (Dia>7));
      
        Console.WriteLine("Digite o peso no dia " + Dia + ": ");
        Peso = float.Parse(Console.ReadLine());
        if (Peso<MenorPeso)
        {
            MenorPeso=Peso;
            DiaMenorPeso=Dia;
        }
		    Cont++;
        }while(Cont<=7);
		Console.WriteLine("O seu menor peso foi de: " + MenorPeso + " no dia " + DiaMenorPeso);
        Console.ReadLine();
    }
}