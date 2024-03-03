namespace Sem
{
    public static class StringExtensions
    {
        public static int WordCount(this string s)
        {
            char[] chars = { ' ', '.', '?', '!', '-', ';', ':', ',' };
            return s.Split(chars, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
