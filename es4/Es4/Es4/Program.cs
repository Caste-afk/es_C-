namespace Es4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float soldi = 0;
            int monete = 0;

            while (soldi < 5.00)
            {
                float soldidati = 0;
                Console.WriteLine("Quanti soldi dare all'accattone ");
                soldidati = float.Parse(Console.ReadLine());
                soldi = soldidati + soldi;
                monete++;
            }
            Console.WriteLine($"L'accattone e` riuscito a pagarsi la colazione, collezionando {soldi}$, con {monete} monete");
        }
    }
}
