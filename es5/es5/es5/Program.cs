using System;

namespace es5
{
    internal class Program
    {

        static bool gioco()
        {
            Console.WriteLine("---------lancio 1---------");
            bool vittoria = false;
            Random random = new Random();
            int dado1 = random.Next(1, 7);
            int dado2 = random.Next(1, 7);
            Console.WriteLine($"Dado1: {dado1}");
            Console.WriteLine($"Dado2: {dado2}");

            int somma = dado1 + dado2;
            Console.WriteLine($"Somma: {somma}");

            if (somma == 7 || somma==11){
                vittoria = true;
            }else if(somma ==2 || somma ==3 || somma == 12)
            {
                vittoria = false;
            }else
            {
                int somma2 = 0;
                int n = 2;
                while (somma2 != somma || somma2 != 7)
                {
                    Console.WriteLine($"---------lancio {n}---------");
                    int d1 = random.Next(1, 7);
                    int d2 = random.Next(1, 7);
                    Console.WriteLine($"Punteggio da eguagliare: {somma}");
                    Console.WriteLine($"Dado1: {d1}");
                    Console.WriteLine($"Dado2: {d2}");

                    somma2 = d1 + d2;
                    Console.WriteLine($"Somma: {somma2}");
                    if (somma2 == somma)
                    {
                        vittoria = true;
                        break;
                    }
                    else if (somma2 == 7)
                    {
                        vittoria = false;
                        break;
                    }
                    
                    n++;
                }
            }
            return vittoria;
        }

        static void Main(string[] args)
        {
            float saldo = 1000;

            while (saldo > 0)
            {
                Console.WriteLine("inserire una puntata");
                float puntata = float.Parse(Console.ReadLine());
                if (puntata > 0 && puntata <= saldo)
                {
                    if (gioco())
                    {
                        saldo =saldo + puntata;
                        Console.WriteLine($"Hai vinto! Nuovo saldo {saldo}$");
                    }
                    else
                    {
                        saldo = saldo-puntata;
                        Console.WriteLine($"Hai perso! Nuovo saldo {saldo}$");
                    }
                }
                else
                {
                    Console.WriteLine($"fondi insufficenti, il saldo ammonta a: {saldo}");
                }
            }
        }
    }
}
