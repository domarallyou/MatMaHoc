using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RC4_1_
{
    public class RSA
    {
        public List<long> MaHoaRSA(string s,long a,long b)
        {
            long input=Convert.ToInt64(s);
            List<long> B = new List<long>();
            long N = a * b;
            long PhiN=(a-1)*(b-1);
            long e = FindE(PhiN);
            B.Add(e);
            long d= FindD(e,PhiN);
            B.Add(d);
            long Ciphertext=exp_by_squaring_with_loop(input,e,N);
            B.Add(Ciphertext);
            return B;

        }

        public List<long> GiaiMa(string s, long d, long n)
        {
            long input = Convert.ToInt64(s);
            List<long> B = new List<long>();
            long Ciphertext = exp_by_squaring_with_loop(input, d, n);
            B.Add(Ciphertext);
            return B;

        }


        public long exp_by_squaring_with_loop(long a, long k, long n)
        {
            long result = 1;
            while (k > 0)
            {
                if (k % 2 == 1)
                {
                    result = (result * a) % n;
                }
                a = (a * a) % n;
                k = k / 2;
            }
            return result;
        }
        public long FindD(long n,long m)
        {
            long count = m;
            long r, q;
            long x=0,x0=0,x1=1;
            while (n > 0)
            {
                r = m % n;
                if(r == 0)
                {
                    break;
                }
                else
                {
                    q = m / n;
                    x=x0 - x1*q;
                    m = n;
                    n = r;
                    x0=x1;
                    x1 = x;
                }
            }

            if (n > 1)
                Console.WriteLine("SAIIIIIIIIIIII");
            else
            {
                if (x < 0)
                {
                    x += count;
                }
            }
            return x;
        }

        public long FindE(long a)
        {
            Console.WriteLine(a);
            List<long> A = new List<long>();

            for (int i = 2; i < a; i++)
            {
                if (FindGCD(i, a) == 1)
                {
                    A.Add(i);
                }
            }
            long B;
            if (A.Count > 0)
            {
                Random random = new Random();
                B = A[random.Next(A.Count)];
            }
            else
            {
                B = 0;
            }
            foreach (long x in A)
            {
                Console.WriteLine(x);
            }

            return B;

        }

        public  bool SoNT(int num)
        {

            {
                int  i, ctr = 0;
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }
                if (ctr == 0 && num != 1)
                    return true;
                else
                    return false;
            }
        }

        public  int FindLCM(int num1, int num2)
        {
            int max, lcm = 0;
            max = (num1 > num2) ? num1 : num2;
            while (true)
            {
                if (max % num1 == 0 && max % num2 == 0)
                {
                    lcm = max;
                    break;
                }
                max++;
            }
            return lcm;
        }
        public long FindGCD(long num1, long num2)
        {
            while (num2 != 0)
            {
                long temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }

    }
}
