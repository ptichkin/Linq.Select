using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Study
{
    public static class Select
    {
        public static void RunExample()
        {
            var numbers = new List<int> { 10, 96, 14, 7, 15, 0, 1084, 33, 27, 29, 7, 5, 105 };

            Console.WriteLine("Position\tValue");
            foreach (var item in numbers.Select((o, index) => new { Number = o, Index = index }).Where(o => o.Number % 2 == 0))
            {
                Console.WriteLine(item.Index.ToString() + "\t\t" + item.Number.ToString());
            }

            Console.ReadKey();
        }
    }
}
