using System;

class Ex1
{
    public static void Main()
    {
		int Idade = 100;

        do
        {
            Console.WriteLine("Digite a sua idade: ");
            Idade = int.Parse(Console.ReadLine());
            if ((Idade<0) || (Idade>100))
            {
                Console.WriteLine("Digite uma idade valida!");
            }
        }while((Idade<0) || (Idade>100));
        if ((Idade>=0) && (Idade<=60))
        {
            Console.WriteLine("Voto obrigatorio!");
        } 
        if ((Idade<18) || (Idade>60))
        {
            Console.WriteLine("Voto nao obrigatorio!");
        }
        Console.ReadLine();
	}
}