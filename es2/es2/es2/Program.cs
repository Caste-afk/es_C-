namespace es2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tentativi = 10;
            int max = 0;
            int min = 1;
            Random rnd = new Random(); 
            Console.WriteLine("Inserire un livello di difficolta` (1-3)");
            int difficolta  = int.Parse(Console.ReadLine());
            switch (difficolta) {
                case 1:
                    max = 5;
                    break;
                case 2:
                    max = 10;
                    break;
                case 3:
                    max = 20;
                    break;
                default:
                    Console.WriteLine("livello non disponibile");
                    break;
            }

            int numero = rnd.Next(min, max + 1);
            int prova = 0;

            do
            {
                Console.WriteLine($"inserire un numero, tentativi rimanenti: {tentativi}");
                prova = int.Parse(Console.ReadLine());
                if (prova > numero)
                {
                    Console.WriteLine("numero troppo grande");
                }else if(prova < numero)
                {
                    Console.WriteLine("numero troppo piccolo");
                }else if(prova == numero)
                {
                    Console.WriteLine("Numero indovinato");  
                }
                tentativi --;
            }while(tentativi  > 0 && prova != numero);

            if (numero != prova)
            {
                Console.WriteLine("Game over!");
            }
        }
    }
}
