using System;

class Menu
{
    public static void Imc()
    {
	    float Altura=0;
        float Peso=0;
        float Imc=0;

	    int Menu;

        Console.WriteLine("Digite seu sexo: 1 - Masculino ou 2 - Feminino ");
        Menu = int.Parse(Console.ReadLine());
        if (Menu == 1) 
        {
            Console.WriteLine("Digite sua altura: ");
            Altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu peso: ");
            Peso = float.Parse(Console.ReadLine());	
            Imc = Peso / (Altura * Altura);
            Console.WriteLine("\nSeu IMC foi de: " + Imc);
            if (Imc < 20.7) 
            {
                Console.WriteLine("Abaixo do peso\n");
            }
            else if ((Imc >= 20.7) && (Imc < 26.4))
            {
                Console.WriteLine("Peso ideal\n");
            }
            else if ((Imc >= 26.4) && (Imc < 27.8))
            {
                Console.WriteLine("Ligeiramente acima do peso\n");
            }
            else if ((Imc >= 27.8) && (Imc < 31.1))
            {
                Console.WriteLine("Acima do peso\n");
            }
            else if (Imc > 31.1)
            {
                Console.WriteLine("Obeso\n");
            }
        } 
        else if (Menu == 2) 
        {
            Console.WriteLine("Digite sua altura: ");
            Altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu peso: ");
            Peso = float.Parse(Console.ReadLine());
            Imc = Peso / (Altura * Altura);
            Console.WriteLine("\nSeu IMC foi de: " + Imc);
            if (Imc < 19.1) 
            {
                Console.WriteLine("Abaixo do peso\n");
            }
            else if ((Imc >= 19.1) && (Imc < 25.8))
            {
                Console.WriteLine("Peso ideal\n");
            }
            else if ((Imc >= 25.8) && (Imc < 27.3))
            {
                Console.WriteLine("Ligeiramente acima do peso\n");
            }
            else if ((Imc >= 27.3) && (Imc < 32.3))
            {
                Console.WriteLine("Acima do peso\n");
            }
            else if (Imc > 32.3)
            {
                Console.WriteLine("Obesidade\n");
            }			
        }
    }

    public static void DiasVividos()
    {
        int DiasDeVida=0;
        int Idade=0;
        int HorasVividas=0;

        Console.WriteLine("Digite a sua idade: ");
        Idade = int.Parse(Console.ReadLine());

        DiasDeVida=Idade*365;
        HorasVividas=DiasDeVida*24;

        Console.WriteLine("Você já viveu " + DiasDeVida + " dias" + " e " + HorasVividas + " horas" + "\n");
    }

    public static void Tabuada()
    {
        int NumeroTabuada=0;
        int Tabuada=0;

        Console.WriteLine("Informe o número da tabuada: ");
        NumeroTabuada = int.Parse(Console.ReadLine());

        for (int X = 1; X <=10; X++)
        {
            Tabuada=NumeroTabuada*X;
            if(X == 10)
                Console.WriteLine(NumeroTabuada + "X" + X + "=" + Tabuada + "\n");
            else
                Console.WriteLine(NumeroTabuada + "X" + X + "=" + Tabuada);
        }
    }

    public static float MediaUlbra()
    {
        float Media=0;
        float G1=0;
        float G2=0;

        Console.WriteLine("Digite a nota da G1: ");
        G1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota da G2: ");
        G2 = float.Parse(Console.ReadLine());

        Media = (G1+(G2*2))/3;

        return Media;
    }

    public static void Main()
    {
		int Opcao = 0;

        do
        {
             Console.WriteLine("Escolha uma opção para calcular: \n[1] Tabuada\n[2] Média da Ulbra\n[3] Dias e horas já vividas\n[4] IMC\n[0] Finalizar");
             Opcao = int.Parse(Console.ReadLine());

             if ((Opcao<1) || (Opcao>4))
             {
                 Console.WriteLine("Digite uma opção válida!");
             }

             if (Opcao == 2)
            {
                Console.Clear();
                float m;
                m = MediaUlbra();
                Console.WriteLine("\nSua média foi de: " + m); 
                if (m < 6)
                    Console.WriteLine("Você está abaixo da média, estude mais!\n");
                if (m == 6)
                    Console.WriteLine("Eita, raspando! Está na média, parabéns.\n");
                if (m > 6)
                    Console.WriteLine("Parabéns! Você está acima da média!\n");
            }

            if (Opcao == 1)
            {
                Console.Clear();
                Tabuada();
            }

            if (Opcao == 3)
            {
                Console.Clear();
                DiasVividos();
            }

            if(Opcao == 4)
            {
                    Console.Clear();
                Imc();
            }

        }while (Opcao != 0);

    }
}