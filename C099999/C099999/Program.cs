using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C099999
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Orange
    {
        public static List<int> GetSmallests(List<int> list, int count)
        {
            var smallests = new List<int>();

            while ()
            {
                var min = GetSmallest(list);
                smallests.Add(min);
                list.Remove(min);
            }
            return smallests;
        }

    }
}
