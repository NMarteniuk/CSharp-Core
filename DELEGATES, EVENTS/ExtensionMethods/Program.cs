using System.Collections.Generic;
public static class IListExtensions
{
    public static void IncreaseWith(this IList<int> values, int count)
    {
        for (int i = 0; i < values.Count; i++)
        {
            values[i] += count;
        }
    }
}
public static class IEnumerableExtensions
{
    public static string ToString<T>(this IList<T> values)
    {
        string retVal = string.Empty;
        foreach (T i in values)
        {
            if (string.IsNullOrEmpty(retVal)) retVal += i.ToString();
            else retVal += string.Format(", {0}", i);
        }
        return "[" + retVal + "]";
    }
}
