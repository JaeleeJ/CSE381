namespace AlgorithmLib;

public static class QuickSort
{
    private static int Partition(List<IComparable> data, int first, int last)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        // set q to first
        var q = first;
        // for u = p to r-1
        for (var u = first; u < last; u++)
        {
            if (data[u].CompareTo(data[last]) <= 0)
            {
                // swap data[q] with data[u]
                (data[q], data[u]) = (data[u], data[q]);
                q++;
            }
        }
        // swap data[q] with data[last]
        (data[q], data[last]) = (data[last], data[q]);
        
        return q;
    }

    public static void Sort(List<IComparable> data)
    {
        // ADD CODE HERE
        // call _Sort since data is the only parameter given
        _Sort(data, 0, data.Count() - 1);
    }

    public static void _Sort(List<IComparable> data, int first, int last)
    {
        // base case
        if (first >= last)
        {
            return;
        }
        else
        {   
            // set q to the results of calling partition
            var q = Partition(data, first, last);
            // recursively call
            _Sort(data, first, q - 1);
            _Sort(data, q + 1, last);
        }
    }

}