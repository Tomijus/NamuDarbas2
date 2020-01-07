using System;
using System.Collections.Generic;

namespace NamuDarbas2
{
    class Program
    {
        static void Main()
        {
            for (int i = 100000; i <= 999999; i++)
            {

                if (IsAllElementsUnique(GiveBackIntList(i)) && 
                    SameCharsDifferentPlaces(GiveBackIntList(i), GiveBackIntList(i * 2)) &&
                    SameCharsDifferentPlaces(GiveBackIntList(i), GiveBackIntList(i * 3)) &&
                    SameCharsDifferentPlaces(GiveBackIntList(i), GiveBackIntList(i * 4)) &&
                    SameCharsDifferentPlaces(GiveBackIntList(i), GiveBackIntList(i * 5)) &&
                    SameCharsDifferentPlaces(GiveBackIntList(i), GiveBackIntList(i * 6)) &&
                    GiveBackIntList(i * 6).Count == 6)
                {
                    Console.WriteLine($"Magic number: {i}");
                    /*
                    Console.WriteLine("Magic number multiplied by 2: " + i * 2);
                    Console.WriteLine("Magic number multiplied by 3: " + i * 3);
                    Console.WriteLine("Magic number multiplied by 4: " + i * 4);
                    Console.WriteLine("Magic number multiplied by 5: " + i * 5);
                    Console.WriteLine("Magic number multiplied by 6: " + i * 6);
                    */
                }
            }
        }
        static List<int> GiveBackIntList(int skaicius)
        {
            List<int> intList = new List<int>();
            string strSkaicius = Convert.ToString(skaicius);
            foreach (char item in strSkaicius)
            {
                skaicius = int.Parse(item.ToString());
                intList.Add(skaicius);
            }
            return intList;
        }
        static bool IsAllElementsUnique(List<int> listas)
        {
            List<int> checkList = new List<int>();
            foreach (int item in listas)
            {
                for (int i = 0; i < listas.Count; i++)
                {
                    if (item == listas[i])
                    {
                        checkList.Add(1);
                    }
                }
                if (checkList.Count > 1)
                {
                    return false;
                }
                else
                {
                    checkList.Clear();
                }
            }
            return true;
        }
        static bool SameCharsDifferentPlaces(List<int> pirmasListas, List<int> antrasListas)
        {
            List<int> checkList = new List<int>();
            for (int j = 0; j < pirmasListas.Count; j++)
            {
                for (int i = 0; i < antrasListas.Count; i++)
                {
                    if (pirmasListas[j] == antrasListas[i])
                    {
                        if (pirmasListas.IndexOf(pirmasListas[j]) != antrasListas.IndexOf(antrasListas[i]))
                        {
                            checkList.Add(1);
                        }
                    }
                }
            }
            if (checkList.Count == 6)
            {
                return true;
            }
            return false;
        }
    }
}
