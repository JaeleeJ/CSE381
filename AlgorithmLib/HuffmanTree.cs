
namespace AlgorithmLib;

public static class HuffmanTree
{
    public class Node
    {
        public char Letter { get; set; }
        public float Count { get; set; }
        
        public Node? Left;
        public Node? Right;
    }

    public static Dictionary<char,int> Profile(String text)
    {
        // create profile
        Dictionary<char, int> profile = new Dictionary<char, int>();
        
        // see if character exists and count the frequency
        foreach (char letter in text)
        {
            if (profile.ContainsKey(letter))
                profile[letter]++;
            else
                profile[letter] = 1;
        }
        
        return profile;
    }
    public static Node BuildTree(Dictionary<char, int> profile)
    {
        // {
        //     Count = 0,
        //     Letter = '\0',
        //     Left = null,
        //     Right = null
        // };
        // create priority queue
        PriorityQueue<Node> q = new PriorityQueue<Node>();
        
        // create new nodes
        foreach (char letter in profile.Keys)
        {
            Node node = new Node();
            node.Letter = letter;
            node.Count = profile[letter];
            q.Insert(node, node.Count);
        }
        
        // dequeue lowest counts
        while (q.Size() > 1)
        {
            Node x = q.Dequeue();
            Node y = q.Dequeue();
            Node z = new Node();
            z.Count = x.Count + y.Count;
            z.Left = x;
            z.Right = y;
            // reinsert to find the root node
            q.Insert(z, z.Count);
        }

        return q.Dequeue();
        
    }

    public static Dictionary<char, string> CreateEncodingMap(Node root)
    {
        // create map
        Dictionary<char, string> map = new Dictionary<char, string>();
        // call recursive function
        _CreateEncodingMap(root, "", map);
        
        return map;
    }
    
    // create function to create encoding map
    private static void _CreateEncodingMap(Node node, string code, Dictionary<char, string> map)
    {
        // return empty tree
        if (node == null)
            return; 
        if (node.Left == null && node.Right == null)
        {
            // check if there is only one node or if it is a leaf
            if (code.Length == 0)
                map[node.Letter] = "1"; 
            else
                map[node.Letter] = code; 
        }
        else
        {
            // assign binary codes
            _CreateEncodingMap(node.Left, code + "0", map);
            _CreateEncodingMap(node.Right, code + "1", map);
        }
    }

    public static string Encode(string text, Dictionary<char, string> map)
    {
        var result = "";
        // add encoded text to string
        foreach (char letter in text)
        {
            result += map[letter];
        }
        
        return result;
    }

    public static string Decode(string text, Node tree)
    {
        Node currNode = tree;
        var result = "";
        
        // loop letter in encoded
        foreach (char value in text)
        {
            // traverse tree until we get to leaf
            if (value == '0')
                currNode = currNode.Left;
            else
                currNode = currNode.Right;

            if (currNode.Left == null && currNode.Right == null)
            {
                // if current is leaf
                result += currNode.Letter;
                // start over again with tree
                currNode = tree;
            }
        }
        
        return result;
    }
}
