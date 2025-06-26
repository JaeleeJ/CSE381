namespace AlgorithmLib;

public static class MergeSort
{
    private static void Merge(List<IComparable> data, int first, int mid, int last)
    {
        // ADD CODE HERE 
        var n1 = mid - first + 1;
        var n2 = last - mid;

        // create two new lists for copying
        List<IComparable> B = new List<IComparable>(n1);
        List<IComparable> C = new List<IComparable>(n2);

        // copy 0 - mid to B
        for (int i = 0; i <= n1; i++) 
        {
            B.Add(data[first + i]);
        }

        // copy mid + 1 to last to C
        for (int j = 0; j < n2; j++)
        {
            C.Add(data[mid + j + 1]);
        }

        // // set B and C to infinity
        B.Add(double.PositiveInfinity);
        C.Add(double.PositiveInfinity);

        // set indexes
        var index1 = 0;
        var index2 = 0;

        // add elements from B and C to data based on which has lesser value first
        for (var k = first; k <= last; k++)
        {
            if (index1 < n1 && index2 < n2)
            {
                if (B[index1].CompareTo(C[index2]) <= 0)
                {
                    data[k] = B[index1];
                    index1++;
                }
                else
                {
                    data[k] = C[index2];
                    index2++;
                }
            }
            else if (index1 < n1)
            {
                data[k] = B[index1];
                index1++;
            }
            else if (index2 < n2)
            {
                data[k] = C[index2];
                index2++;
            }
        }
        
    }


    public static void Sort(List<IComparable> data) 
    {
        // ADD CODE HERE 
        // call recursively
        _Sort(data, 0, data.Count - 1);
        
    }

    // new function for recursion
    private static void _Sort(List<IComparable> data, int first, int last)
    {
        // return if item is size 1 --> already sorted
        if (first >= last)
        {
            return;
        }

        // initialize midpoint
        var mid = (first + last) / 2;
        
        // call recursively with merge
        _Sort(data, first, mid);
        _Sort(data, mid + 1, last);
        Merge(data, first, mid, last);

    }
    
}