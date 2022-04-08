using System.Collections;

namespace lab_2;

public class Zadanie1
{
    private static ArrayList liczby = new ArrayList();
    
    public static void Uruchom()
    {
        var znak = "";
        var k = 1;

        Console.WriteLine("Wprowadź znak n by zakończyć");
        do
        {
            Console.Write("Podaj " + k + " liczbę do sortowania: ");
            znak = Console.ReadLine()!;

            if (!znak.Equals("n"))
            {
                liczby.Add(Convert.ToInt32(znak));
            }

            k++;
        } while (!znak.Equals("n"));
        
        SortowanieBabelkowe();
        Console.WriteLine("Posortowane liczby: ");
        foreach (var liczba in liczby)
        {
            Console.Write(liczba + " ");
        }
    }

    private static void SortowanieBabelkowe()
    {
        for (var i = 0; i < liczby.Count; i++)
        {
            for (int j = 0; j < liczby.Count - i - 1; j++)
            {
                if (Convert.ToInt32(liczby[j]) > Convert.ToInt32(liczby[j + 1]))
                {
                    int liczbaTemp = Convert.ToInt32(liczby[j + 1]);
                    liczby[j + 1] = liczby[j];
                    liczby[j] = liczbaTemp;
                }
            }
        }
    }

}