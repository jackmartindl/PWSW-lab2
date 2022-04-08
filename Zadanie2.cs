namespace lab_2;

public static class Zadanie2
{
    private static double[] dopuszczalneWartosci = new[] {2, 3, 3.5, 4, 4.5, 5};
    private static double[] tablica;
    public static void Uruchom()
    {
        Console.Write("Podaj długość tablicy: ");
        int dlugoscTablicy = Console.Read();
        tablica = new double[dlugoscTablicy];

        for (int i = 0; i < dlugoscTablicy; i++)
        {
            tablica[i] = dopuszczalneWartosci[new Random().Next(0, 6)];
        }

        Console.WriteLine("Średnia wartość randomowych liczb: " + SredniaWartosc());
        Console.WriteLine("Minimalna wartość randomowych liczb: " + tablica.Min());
        Console.WriteLine("Maksymalna wartość randomowych liczb: " + tablica.Max());
        WartosciWiekszeOdSredniej(SredniaWartosc(), dopuszczalneWartosci);
        ZliczCzestoscWystepowania();
        Console.WriteLine("Średnie odchylenie standardowe liczb: " + SrednieOdchylenie());
    }

    private static double SredniaWartosc()
    {
        double suma = 0;
        for (int i = 0; i < tablica.Length; i++)
        {
            suma += tablica[i];
        }

        return suma /= tablica.Length;
    }

    private static void WartosciWiekszeOdSredniej(double sredniaLiczb, double[] liczby)
    {
        Console.WriteLine("Liczby większe od średniej: ");
        for (int i = 0; i < liczby.Length; i++)
        {
            if (liczby[i] > sredniaLiczb)
            {
                Console.Write(liczby[i] + " ");
            }
        }

        Console.WriteLine();
    }

    private static void ZliczCzestoscWystepowania()
    {
        for (var i = 0; i < 6; i++)
        {
            var iloscZliczen = 0;
            for (var j = 0; j < tablica.Length; j++)
            {
                if (tablica[j].Equals(dopuszczalneWartosci[i]))
                {
                    iloscZliczen++;
                }
            }

            Console.WriteLine("Ilość wystąpień liczby " + dopuszczalneWartosci[i] + ": " + iloscZliczen);
        }
    }

    private static double SrednieOdchylenie()
    {
        double wariacja = 0;
        for (var i = 0; i < tablica.Length; i++)
        {
            wariacja += Math.Pow(tablica[i] - SredniaWartosc(), 2);
        }

        wariacja /= SredniaWartosc();
        return Math.Sqrt(wariacja);
    }
}