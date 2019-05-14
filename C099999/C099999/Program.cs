using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C099999
{
     class Orange
    {
        public static void Main()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 }
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);
        }
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
