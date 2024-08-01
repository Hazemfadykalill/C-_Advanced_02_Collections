using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_02_Collections
{
    public  class Helper
    {
        public static ArrayList ReverseArrayList(ArrayList arrayList)
        {
            if (arrayList is not null)
            {
                for (int i = arrayList.Count - 1; i >= 0; i--)
                {
                    Console.Write(" " + " " + arrayList[i]);
                }
                return arrayList;
            }

            return arrayList!;
        }
    }
}
