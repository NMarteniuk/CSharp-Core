using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    static class ExtensionMethodsForListProgram
    {
        public static List<int> GetIndexes(this List<int> numbers, int number)
        {
            if (!numbers.Contains(number) || numbers.Count() == 0)
            {
                throw new Exception($"List doesn't contain element {number}.");
            }
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == number)
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public static void PrintList(this List<int> numbers)
        {
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
