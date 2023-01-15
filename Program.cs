using System;

class Program
{
    public static void Main()
    {
        Random random = new Random();
        double n = Convert.ToDouble(Console.ReadLine());
        double k = 0; //количество благоприятных исходов
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
            alpha2 = 20 * Math.Pow(alpha2, 0.625);
            double d = 0.4 * alpha1 + 0.6 * alpha2; //выражение d
            if (d > 8.4)  //проверка условия задачи
            {
                k++;
            }
        }
        double st_prob = k / n; //классическая вероятность
        Console.WriteLine(st_prob);
    }

    public static void Main1()
    {
        const double th_prob = 0.97;
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
                alpha2 = 20 * Math.Pow(alpha2, 0.625);
                double d = 0.4 * alpha1 + 0.6 * alpha2;
                if (d > 8.4)
                {
                    k++;
                }
            }
            double prob = k / n;
            //Console.WriteLine(veroyatnost);
            if (Math.Abs(prob - th_prob) <= 0.05)
            {
                counter++;
            }
        }
        double prob_eps = counter / n; //вероятность отклонения

        Console.WriteLine(prob_eps);
    }

}
