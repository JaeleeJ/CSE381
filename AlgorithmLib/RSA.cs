using System.Numerics;
using System.Runtime;

namespace AlgorithmLib;

public class RSA
{
    private static (BigInteger, BigInteger, BigInteger) Euclid(BigInteger a, BigInteger b)
    {
        // base case
        // if b = 0, return the triple
        if (b == 0)
        {
            return (a, 1, 0);
        }

        // call function recursively
        var (gcd, i, j) = Euclid(b, a % b);
       
        return (gcd, j, i - (a / b) * j);
        
    }

    private static BigInteger ModularExponentiation(BigInteger x, BigInteger y, BigInteger n)
    {
        // base case
        if (y == 0)
        {
            return 1;
        }
        
        // if y is even, call function recursively
        if (y % 2 == 0)
        {
            var z = ModularExponentiation(x, y / 2, n);
            return ((z * z) % n);
        }
        else
        // y is odd
        {
            var z = ModularExponentiation(x, (y - 1) / 2, n);
            return ((z * z * x) % n);
        }
        
    }

    public static BigInteger GeneratePrivateKey(BigInteger p, BigInteger q, BigInteger e) 
    {
        var r = (p - 1) * (q - 1);
        
        // modular multiplicative inverse of e mod r with Euclid
        var (gcd, i, _) = Euclid(e, r);

        // if i is negative, add r to make it positive
        if (i < 0)
        {
            i += r;
        }

        return i % r;
    }

    public static BigInteger Encrypt(BigInteger value, BigInteger e, BigInteger n)
    {
        // modular exponentiation to encrypt
        return ModularExponentiation(value, e, n);
    }

    public static BigInteger Decrypt(BigInteger value, BigInteger d, BigInteger n)
    {
        // modular exponentiation to decrypt
        return ModularExponentiation(value, d, n);
    }


}
