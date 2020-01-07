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

                if (IsAllElementsUnique(AtiduokSkaiciuLista(i)) && SameCharsDifferentPlaces(AtiduokSkaiciuLista(i), AtiduokSkaiciuLista(i * 2)) && SameCharsDifferentPlaces(AtiduokSkaiciuLista(i), AtiduokSkaiciuLista(i * 3)) && SameCharsDifferentPlaces(AtiduokSkaiciuLista(i), AtiduokSkaiciuLista(i * 4)) && SameCharsDifferentPlaces(AtiduokSkaiciuLista(i), AtiduokSkaiciuLista(i * 5)) && SameCharsDifferentPlaces(AtiduokSkaiciuLista(i), AtiduokSkaiciuLista(i * 6)))
                {
                    Console.WriteLine("Magic number: " + i);
                    Console.WriteLine("Magic number multiplied by 2: " + i * 2);
                    Console.WriteLine("Magic number multiplied by 3: " + i * 3);
                    Console.WriteLine("Magic number multiplied by 4: " + i * 4);
                    Console.WriteLine("Magic number multiplied by 5: " + i * 5);
                    Console.WriteLine("Magic number multiplied by 6: " + i * 6);
                    break;
                }
            }
        }

        static List<int> AtiduokSkaiciuLista(int skaicius)
        {
            List<int> intList = new List<int>();
            string strSkaicius = Convert.ToString(skaicius);
            foreach (char item in strSkaicius)
            {
                skaicius = int.Parse(item.ToString());
                //Console.WriteLine(skaicius);
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
                    //Console.WriteLine("Duplicate found!");
                    return false;
                }
                else
                {
                    checkList.Clear();
                }
            }
            //Console.WriteLine("All are unique!");
            return true;
        }

        static bool SameCharsDifferentPlaces(List<int> pirmasListas, List<int> antrasListas)
        {
            List<int> checkList = new List<int>();
            int pirmasListIndex = 0;
            foreach (int item in pirmasListas)
            {
                for (int i = 0; i < antrasListas.Count; i++)
                {
                    if (item == antrasListas[i])
                    {
                        if (pirmasListIndex != antrasListas.IndexOf(antrasListas[i]))
                        {
                            checkList.Add(1);
                        }
                    }
                }
                pirmasListIndex++;
            }
            if (checkList.Count == 6)
            {
                //Console.WriteLine("Visi elementai skirtingi ir yra skirtingose vietose!");
                return true;
            }
            //Console.WriteLine("Listai neatitinka salygu!");
            return false;
        }
    }
}
