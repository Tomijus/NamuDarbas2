using System;
using System.Collections.Generic;

namespace NamuDarbas2
{
    class Program
    {
        static void Main()
        {
            AtiduokSkaiciuLista(123456);
        }

        static List<int> AtiduokSkaiciuLista(int skaicius)
        {
            List<int> intList = new List<int>();
            string strSkaicius = Convert.ToString(skaicius);
            foreach (char item in strSkaicius)
            {
                skaicius = Convert.ToInt32(item);
                intList.Add(skaicius);
            }
            return intList;
        }
    }
}
