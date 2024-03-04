using System;

class Program
{
    static int max_(int[] x)
    {
        int enBuyuk = x[0];

        for (int i = 1; i < x.Length; ++i)
        {
            if (x[i] > enBuyuk)
            {
                enBuyuk = x[i];
            }
        }

        return enBuyuk;
    }

    static void Main()
    {
        int a1, a2, a3;

        Console.Write("1. sayı : ");
        a1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("2. sayı : ");
        a2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("3. sayı : ");
        a3 = Convert.ToInt32(Console.ReadLine());

        int[] dizi = { a1, a2, a3 };

        int sonuc = max_(dizi);

        Console.WriteLine("En büyük sayı: " + sonuc);
    }
}
