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
            double max = voti[0];
            double min = voti[0];
            int posmax = 0;
            int posmin = 0;

            CaricaVettori(ref voti, ref pesi, nVoti);
            StampaVotiPesi(voti, pesi, nVoti);
            double mediaPonderata = MediaPonderata(voti, pesi, ref max, ref posmax, ref min, ref posmin);
            Console.WriteLine($"il voto massimo è {max} e la sua posizione è {posmax}");
            Console.WriteLine($"il voto minimo è {min} e la sua posizione è {posmin}");
            Console.WriteLine($"la media ponderata è {mediaPonderata}");
        }

        static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            Console.WriteLine("voti        pesi\n --------------------- \n");
            for (int i = 0; i < nVoti; i++)
                Console.Write($"{voti[i]}        {pesi[i]}\n");
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

        static double MediaPonderata(double[] voti, int[] pesi, ref double max, ref int posmax, ref double min, ref int posmin)
        {
            double sommaVoti = 0;
            int sommaPesi = 0;
            double mediaPonderata;
            for(int i = 0; i<voti.Length; i++) 
            {
                sommaVoti += voti[i];
                sommaPesi += pesi[i];

                if (voti[i] > max)
                {
                    max = voti[i];
                    posmax = i;
                }
                if (voti[i] < min)
                {
                    min = voti[i];
                    posmin = i;
                }
            }
            mediaPonderata = sommaVoti / sommaPesi;
            return mediaPonderata;
        }




    }
}
