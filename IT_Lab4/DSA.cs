using System.Numerics;

namespace IT_Lab4;

public class DSA
{

    public static bool IsPrime(BigInteger n)
    {
        if (n <= 1) return false; 
        if (n == 2) return true; 
        if (n % 2 == 0) return false;

        int k = 20;
        while (k > 0)
        {
            Random rand = new Random();
            int a = 2 + (int)(rand.Next() % (n - 4));
            
            if (FastPow(a, n - 1, n) != 1)
                return false;

            k--;
        }
        return true;
    }

    public static BigInteger FastPow(BigInteger a, BigInteger z, BigInteger n)
    {
        BigInteger x = 1;
        while (z != 0)
        {
            while (z % 2 == 0)
            {
                z = z / 2;
                a = (a * a) % n;
            }
            z = z - 1;
            x = (x * a) % n;
        }
        return x;
    }
    
    
    public static BigInteger GetHash(byte[] data, BigInteger n)
    {
        BigInteger h = 100;
        foreach (byte m in data)
        {
            h = FastPow((h+m), 2, n);
        }

        return h;
    }

    public static (BigInteger, BigInteger, BigInteger) GetSignature(byte[] data, BigInteger q, BigInteger p,
        BigInteger x, BigInteger k, BigInteger g)
    {
        BigInteger h = GetHash(data, q);
        BigInteger r = FastPow(g, k, p) % q;
        BigInteger s = ((h + x * r) / k) % q;

        return (h, r, s);
    }
}