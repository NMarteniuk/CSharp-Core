using System.Collections.Generic;
class ListProgram
{
    public static List<int> ListWithPositive(List<int> values) 
        => values.FindAll(x => x == Math.Abs(x) && x <= 10);
}
