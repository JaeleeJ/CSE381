using Microsoft.VisualBasic.CompilerServices;

namespace AlgorithmLib;

public static class StringMatcher
{
    private static List<Dictionary<char, int>> BuildTable(string pattern, List<char> inputs)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        // make table
        List<Dictionary<char, int>> table = new List<Dictionary<char, int>>();
        
        for (int k = 0; k <= pattern.Length; k++)
        {
            // make map
            Dictionary<char, int> map = new Dictionary<char, int>();
            
            // for letter in inputs
            for (int x = 0; x < inputs.Count(); x++)
            {
                char letter = inputs[x];
                string pka = pattern.Substring(0, Math.Min(k, pattern.Length)) + letter;
                
                // set i to the smaller of k+1
                int i = Math.Min(k + 1, pattern.Length);
                
                // while pi is not a suffix for pka (pattern[:i])
                while (!pka.EndsWith(pattern.Substring(0, i)))
                {
                    i--;
                }
                map[letter] = i;
            }
            table.Add(map);
        }
        
        return table;
    }
    
    public static List<int> Match(string text,  string pattern, List<char> inputs)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        // make table
        List<Dictionary<char, int>> table = BuildTable(pattern, inputs);
        int matchState = table.Count - 1;
        int state = 0;
        
        // make results
        List<int> results = new List<int>();
        
        // for i = 1 to n
        for (int index = 0; index < text.Length; index++)
        {
            // set state to value of next-state[state]
            state = table[state][text[index]];
            
            // pattern occurs with a shift
            if (state == matchState)
            {
                results.Add(index);
            }
        }
        
        return results;
    }
    
}