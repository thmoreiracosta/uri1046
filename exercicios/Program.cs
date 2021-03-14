using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInit, horaFinal, duracao;
            duracao = 0;           

            string[] vet = Console.ReadLine().Split(' ');
            horaInit = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);

            if (horaFinal > horaInit)
            {
                for (int f = horaInit + 1; f <= horaFinal; f++)
                {
                    duracao += 1;
                }
            } 
            else
            {
                for (int i = horaInit + 1; i <= horaFinal + 24; i++)
                {
                    duracao += 1;
                }
            }            
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}