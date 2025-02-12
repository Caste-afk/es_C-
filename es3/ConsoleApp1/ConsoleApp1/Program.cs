using System;

class Program
{
    static int MCD(int n1, int n2)
    {
        while (n2 != 0)
        {
            int temp = n2;
            n2 = n1 % n2;
            n1 = temp;
        }
        return n1;
    }

    static void Main()
    {
        Console.Write("Inserisci il primo numero: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Inserisci il secondo numero: ");
        int num2 = int.Parse(Console.ReadLine());

        int risultato = MCD(num1, num2);
        Console.WriteLine("Il massimo comune divisore è: " + risultato);
    }
}
