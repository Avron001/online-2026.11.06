using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace online_2026._11._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //példák tesztelése

            //int[] pontok = { 12, 17, 15, 20, 14 };
            //Console.WriteLine(pontok[0]);
            //Console.WriteLine(pontok[4]);

            //példaváltás

            //int[] adatok;
            //adatok = new int[4];

            //int[] szamok = { 3, 5, 8 };
            //int[] masik = new int[3] { 3, 5, 8 };
            //string[] nevek = { "Anna", "Béla", "Csilla" };
            //double[] atlagok = new double[3];

            //példaváltás

            //int[] korok = { 15, 16, 17, 18 };
            //Console.WriteLine(korok.Length);
            //Console.WriteLine(korok[1]);
            //korok[1] = 20;
            //Console.WriteLine(korok[1]);
            //Console.WriteLine(korok[korok.Length-1]);

            //példaváltás

            //int[] a = { 1, 2, 3 };
            //// Console.WriteLine(a[3]); // HIBA: IndexOutOfRangeException
            //if (a.Length > 0)
            //{
            //    Console.WriteLine(a[a.Length - 1]);
            //}

            //példaváltás

            //int[] szamok = { 4, 8, 2, 6 };
            //for(int i = 0; i < szamok.Length; i++)
            //{
            //    Console.WriteLine($"{i} index: {szamok[i]}");
            //}

            //foreach (int szam in szamok)
            //{
            //    Console.WriteLine(szam);
            //}

            //int j = 0;
            //while (j < szamok.Length)
            //{
            //    Console.WriteLine(szamok[j]);
            //    j++;
            //}

            //példaváltás

            //int[] szamok = { 10, 20, 30 };
            //Console.WriteLine(string.Join(", ", szamok)); //10, 20, 30
            ////Console.WriteLine(szamok);

            //for (int i = 0; i < szamok.Length; i++)
            //{
            //    Console.Write($"{szamok[i]} ");
            //}

            //példaváltás

            //Console.Write("Hány számot adsz meg?");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            //{
            //    Console.Write("Adj meg egy nemnegatív egész számot: ");
            //}

            //int[] adatok = new int[n];
            //for (int i = 0; i < adatok.Length; i++)
            //{
            //    Console.Write($"{i + 1}. szám: ");
            //    while (!int.TryParse(Console.ReadLine(), out adatok[i]))
            //    {
            //        Console.Write("Hibás adat, próbáld újra: ");
            //    }
            //}
            //Console.WriteLine(string.Join(", ", adatok));

            //példaváltás

            //bool[] sikeres = new bool[3]; //false, false, false
            //string[] cimkek = new string[6];
            //char[] betuk = { 'C', '#' };
            //int[] ures = Array.Empty<int>();

            //Console.WriteLine(ures.Length);
            //Console.WriteLine(ures.Length == 0 ? "Üres" : "Nem üres");

            //B rész
            //példaváltás










            //feladatok:
            //01
            //int[] tomb = { 3, 12, 32, 1, 765 };
            //Console.WriteLine(tomb[0]);
            //Console.WriteLine(tomb[2]);
            //Console.WriteLine(tomb[tomb.Length-1]);

            //02

            //int[] tomb = new int[5];

            //for (int i = 0; i < tomb.Length; i++)
            //{
            //    Console.Write($"Adj meg egy számot ({i + 1}.): ");
            //    while (!int.TryParse(Console.ReadLine(), out tomb[i]))
            //    {
            //        Console.Write("Hibás adat, próbáld újra: ");
            //    }
            //}

            //Console.WriteLine(string.Join(", ", tomb));

            //03

            //int[] tomb = { 1, 4, 6 };

            //for (int i =0; i< tomb.Length; i++)
            //{
            //    Console.Write($"{tomb[tomb.Length - i - 1]} ");
            //}

            //04

            //int[] szamok = { 2,3,4,5,6,7,8,9};

            //foreach (int szam in szamok)
            //{
            //    if (szam % 2 == 0)
            //    {
            //        Console.WriteLine($"{szam} páros");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{szam} páratlan");
            //    }
            //}

            //05

            //int[] tomb = { 2,5,-23,7,4 };

            //for (int i = 0; i < tomb.Length; i++)
            //{
            //    tomb[i] *= 10;
            //}

            //Console.WriteLine(string.Join(", ", tomb));

            //06

            //int[] tomb = { 2, 5, -23, 7, 4, 0 };
            //int pozitivak = 0;
            //foreach (int szam in tomb)
            //{
            //    if (szam > 0 && szam != 0)
            //    {
            //        pozitivak++;
            //    }
            //}
            //Console.WriteLine(pozitivak);

            //07

            //int[] szamok = { 1, 2, 6 };

            //if (szamok.Length == 0)
            //{
            //    Console.WriteLine("A tömb üres.");
            //}
            //else
            //{
            //    int osszeg = 0;
            //    foreach (int szam in szamok)
            //    {
            //        osszeg += szam;
            //    }
            //    double atlag = (double)osszeg / szamok.Length;

            //    Console.WriteLine($"összeg {osszeg}, átlag {atlag}.");
            //}

            //08

            //int[] tomb = { 2, 5, -23, 7, 4, 0 };

            //int max;
            //int min;

            //max = tomb[0];
            //foreach (int szam in tomb)
            //{
            //    if (szam > max)
            //    {
            //        max = szam;
            //    }
            //}

            //min = tomb[0];
            //foreach (int szam in tomb)
            //{
            //    if (szam < min)
            //    {
            //        min = szam;
            //    }
            //}

            //Console.WriteLine($"Max: {max}, Min: {min}");

            //09

            //int[] tomb = { 2, 5, -23, 7, 4, 0 };

            //for (int i = 0; i < tomb.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write($"{tomb[i]} ");
            //    }
            //}

            //10

            //int[] tomb = { 2, 5, -23, 7, 4, 0 };

            //Console.Write("Kérem adjon meg egy számot!\n>");
            //int szam = Convert.ToInt32(Console.ReadLine());
            //int index = -1;

            //for (int i = 0; i < tomb.Length; i++)
            //{
            //    if (tomb[i] == szam)
            //    {
            //        index = i;
            //        break;
            //    }
            //}

            //Console.WriteLine($"A szám a tömb {index}. indexén található.");

            //11

            //int[] tomb = { 4, 2, 5, -23, 7, 7, 7, 4, 0 };

            //Console.Write("Kérem adjon meg egy számot!\n>");
            //int szam = Convert.ToInt32(Console.ReadLine());
            //int index = -1;

            //for (int i = 0; i < tomb.Length; i++)
            //{
            //    if (tomb[i] == szam)
            //    {
            //        index = i;

            //    }
            //}

            //Console.WriteLine($"A szám a tömb {index}. indexén található.");

            //12

            //int[] szamok = { 4, 2, 512, -23, 7, 12, 234234, 4, 0, 50 };
            //int db = 0;

            //foreach (int szam in szamok)
            //{
            //    if (szam > 50)
            //    {
            //        Console.WriteLine(szam);
            //        db++;
            //    }
            //}
            //Console.WriteLine($"Az 50-nél nagyobb számok száma: {db}");

            //13

            //int[] tomb = { 4, 2, 512, -23, 7, 12, 234, 4, 0, 50 };

            //int sum = 0;
            //foreach (int szam in tomb)
            //{
            //    sum += szam;
            //}

            //double atlag = (double)sum / tomb.Length;

            //int db = 0;
            //foreach (int szam in tomb)
            //{
            //    if (szam > atlag)
            //    {
            //        db++;
            //    }
            //}

            //Console.WriteLine($"Az átlag: {atlag}, az átlag feletti számok száma: {db}");

            //14

            //int[] tomb = { 0, 1, 5 };
            //Console.WriteLine(string.Join(", ", tomb));
            //(tomb[0], tomb[tomb.Length-1]) = (tomb[tomb.Length - 1], tomb[0]);
            //Console.WriteLine(string.Join(", ", tomb));

            //15

            //int[] szamok = { 4, 2, 512, -23, 7, 12, 234, 4, 0, 50 };
            //int max = szamok[0];
            //foreach (int szam in szamok)
            //{
            //    if (szam > max)
            //    {
            //        max = szam;
            //    }
            //}

            //int secondmax = szamok[0];
            //foreach (int szam in szamok)
            //{
            //    secondmax = szam;
            //    if (secondmax != max)
            //    {
            //        break;
            //    }
            //}
            //if (secondmax == max)
            //{
            //    Console.WriteLine("Nincs két különböző elem");
            //}
            //else
            //{
            //    foreach (int szam in szamok)
            //    {
            //        if (szam > secondmax && szam != max)
            //        {
            //            secondmax = szam;
            //        }
            //    }
            //    Console.WriteLine($"A második legnagyobb elem: {secondmax}");
            //}

            //16

            //int[] szamok = {4, 5, 12, 3, 3, 2, 6};
            //Boolean duplikacio = false;

            //for (int index1 = 0; index1 < szamok.Length; index1++)
            //{
            //    for (int index2 = 0; index2 < szamok.Length; index2++)
            //    {
            //        if (index1 != index2)
            //        {
            //            if (szamok[index1] == szamok[index2])
            //            {
            //                duplikacio = true;
            //            }
            //        }
            //    }
            //}


            //if (duplikacio)
            //{
            //    Console.WriteLine("Van duplikáció a tömbben.");
            //}
            //else
            //{
            //    Console.WriteLine("Nincs duplikáció a tömbben.");
            //}

            //17

            //int[] szamok = { 4, 5, 12, 3, 3, 2, 6 };

            //int[] harommalOszthatok = {};

            //foreach (int szam in szamok)
            //{
            //    if (szam % 3 == 0)
            //    {
            //        Array.Resize(ref harommalOszthatok, harommalOszthatok.Length + 1);
            //        harommalOszthatok[harommalOszthatok.Length-1] = szam;
            //    }
            //}

            //Console.WriteLine($"A 3-mal osztható számok: {string.Join(", ", harommalOszthatok)}");

            //18

            int[] a = { 23,4,1,4,6,7,8,4,2,12};
            for (int vege = a.Length - 1; vege > 0; vege--)
            {
                for (int i = 0; i < vege; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        (a[i], a[i + 1]) = (a[i + 1], a[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", a));








        }
    }
}
