using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC4_1_
{
    public  class RC4
    {
        public  string mahoaRC4(string text,string key)
        {
            int i;
            string CipherText="";

            List<int> K = new List<int>();
            for(i=0;i<key.Length;i++)
            {
                K.Add(Convert.ToInt32(key[i]));
            }
            List<int> S = new List<int>();

            List<int> Keystream = new List<int>();

            List<int> Plaintext = new List<int>();
            foreach(char c in text) { Plaintext.Add(Convert.ToInt32(c)); }

            List<int> T= new List<int>();

            for (i=0; i < 256; i++)
            {
                S.Add(i);
                T.Add(K[i % key.Length]);
            }
            int j=0;       
            for (i = 0; i < 256; i++)
            {
                j = (j + S[i] + T[i]) % 256;
                int temp;
                temp=S[i];
                S[i] = S[j];
                S[j] = temp;


            }



            i = 0;
            j = 0;
            int a = 0;
            int lengt = text.Length;

            while (lengt > 0)
            {
                i=(i+1) % 256;
                j = (j + S[i]) % 256;
                int temp;
                temp = S[i];
                S[i] = S[j];
                S[j] = temp; int t = (S[i] + S[j]) % 256;
                Keystream.Add(S[t]);
                lengt = lengt - 1;
                a++;

            }
            for (i = 0; i < Keystream.Count(); i++)
            {
                Console.WriteLine(Keystream[i]+" : " + S[i]);
            }
            for (int o = 0; o < Plaintext.Count(); o++)
            {
                Plaintext[o] = Plaintext[o] ^ Keystream[o];
                

                CipherText += Plaintext[o].ToString("X");
            }
            return CipherText;
        }
        public string giaimaRC4(string text, string key)
        {
            int i;
            string CipherText = "";

            List<int> K = new List<int>();
            for (i = 0; i < key.Length; i++)
            {
                K.Add(Convert.ToInt32(key[i]));
            }
            List<int> S = new List<int>();

            List<int> Keystream = new List<int>();

            List<int> Plaintext = new List<int>();
            for ( i = 0; i < text.Length; i += 2)
            {
                Plaintext.Add(Convert.ToInt32(text.Substring(i, 2), 16));
            }

            List<int> T = new List<int>();

            for (i = 0; i < 256; i++)
            {
                S.Add(i);
                T.Add(K[i % key.Length]);
            }
            int j = 0;
            for (i = 0; i < 256; i++)
            {
                j = (j + S[i] + T[i]) % 256;
                int temp;
                temp = S[i];
                S[i] = S[j];
                S[j] = temp;


            }



            i = 0;
            j = 0;
            int a = 0;
            int lengt = text.Length;

            while (lengt > 0)
            {
                i = (i + 1) % 256;
                j = (j + S[i]) % 256;
                int temp;
                temp = S[i];
                S[i] = S[j];
                S[j] = temp; int t = (S[i] + S[j]) % 256;
                Keystream.Add(S[t]);
                lengt = lengt - 1;
                a++;

            }
            for (i = 0; i < Keystream.Count(); i++)
            {
                Console.WriteLine(Keystream[i] + " : " + S[i]);
            }
            for (int o = 0; o < Plaintext.Count(); o++)
            {
                Plaintext[o] = Plaintext[o] ^ Keystream[o];


                CipherText += Plaintext[o].ToString("X");
            }
            return CipherText;
        }

        public static void Swap( int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }


    }
}
