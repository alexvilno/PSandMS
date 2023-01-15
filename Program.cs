using System;

class Program
{
    public static void Main()
    {
        const double teor_ver = 0.97;
        Random random = new Random();
        double n = Convert.ToDouble(Console.ReadLine());
        double counter = 0;
        for (int j = 0; j < n; j++)
        {
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double alpha1 = random.NextDouble();
                double alpha2 = random.NextDouble();
                if (alpha1 <= 0.1)
                {
                    alpha1 = 18;
                }
                else if (alpha1 > 0.1 && alpha1 <= 0.6)
                {
                    alpha1 = 19;
                }
                else
                {
                    alpha1 = 21;
                }
                alpha2 = 20 * Math.Pow(alpha2, 1.6);
                double d = 0.4 * alpha1 + 0.6 * alpha2;
                if (d > 8.4)
                {
                    k++;
                }
            }
            double veroyatnost = k / n;
            Console.WriteLine(veroyatnost);
            if (Math.Abs(veroyatnost - teor_ver) <= 0.05)
            {
                counter++;
            }
        }
        double veroyat3 = counter / n;

        Console.WriteLine(veroyat3);
    }

}
