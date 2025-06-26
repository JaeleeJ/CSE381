namespace AlgorithmLib;

public static class BetterLinearSearch
{
    public static int Search(List<IComparable> data, IComparable target)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        
        // LINEAR SEARCH
        // var answer = -1;
        // for (var i = 0; i < data.Count; i++)
        // {
        //     if (data[i].Equals(target))
        //     {
        //         answer = i;
        //     }
        // }
        //
        // return answer;
        
        // BETTER-LINEAR-SEARCH
        var NOT_FOUND = -1;
        // for i = 1 to n
        foreach (var i in Enumerable.Range(0,data.Count))
        {
            // if A[i] = x, then return the value of i as the output
            if (data[i].Equals(target))
            {
                return i;
            }
        }
        
        // return NOT-FOUND as the output
        return NOT_FOUND; 
    }
}