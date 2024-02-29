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

        }

        void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            for(int i = 0;i < nVoti; i++)
                Console.Write($"Voti   -   pesi \n --------------------- \n {voti[i]}                {pesi[i]}\n");
        }
    }
}
