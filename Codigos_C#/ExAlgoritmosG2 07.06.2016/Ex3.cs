using System;

class Ex1
{
    public static void Main()
    {
		int ContOutros=0;
		int ContInter=0;
		int ContGremio=0;
		int ContTorce=-1;
		int Resposta;

        do
        {
            Console.WriteLine("Digite para qual time voce torce:\n[1] Gremio\n[2] Internacional\n[3] Outros\n[0] Finalizar");
            Resposta = int.Parse(Console.ReadLine());
            ContTorce++;
            if (Resposta==1)
            {
                ContGremio++;
            }
            if (Resposta==2)
            {
                ContInter++;
            }
            if (Resposta==3)
            {
                ContOutros++;
            }
        }while(Resposta!=0);
		Console.WriteLine("Torcedores do inter: " + ContInter + "\nTorcedores do Gremio: " + ContGremio + "\nTorcedores de outros times: " + ContOutros + "\nTotal de torcedores entrevistados: " + ContTorce);
        Console.ReadLine();
    }
}