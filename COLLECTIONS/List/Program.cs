using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace List
{
    class MyProgram
    {
        public static void Position(List<int> numbers)
        {
            numbers.GetIndexes(5).PrintList();
        }
        public static void Remove(List<int> numbers)
        {
            numbers.RemoveAll(x => x > 20);
            numbers.PrintList();
        }
        public static void Insert(List<int> numbers)
        {
            if (8 > numbers.Count)
            {
                throw new ArgumentOutOfRangeException("Count of List is less than 8.");
            }
            numbers.Insert(2, -5);
            numbers.Insert(5, -6);
            numbers.Insert(7, -7);
            numbers.PrintList();
        }
        public static void Sort(List<int> numbers)
        {
            numbers.Sort();
            numbers.PrintList();
        }
    }
}