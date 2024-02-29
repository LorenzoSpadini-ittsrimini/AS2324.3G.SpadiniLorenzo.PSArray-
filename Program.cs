namespace AS2324._3G.SpadiniLorenzo.PSArray_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il numero di voti:");
            int nVoti = int.Parse(Console.ReadLine());
            double[] voti = new double[nVoti];
            int[] pesi = new int[nVoti];

            CaricaVettori(ref voti, ref pesi, nVoti);
            StampaVotiPesi(voti, pesi, nVoti);
        }

        static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            for(int i = 0;i < nVoti; i++)
                Console.Write($"Voti   -   pesi \n --------------------- \n {voti[i]}                {pesi[i]}\n");
        }

        static void CaricaVettori(ref double[] voti, ref int[] pesi, int nVoti)
        {
            Random random = new Random();
            for(int i = 0; i < nVoti; i++)
            {
                voti[i] = random.Next(1, 11);
                pesi[i] = random.Next(1, 101);
            }
        }
    }
}
