using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgLinieCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            int poz, length;
            string[][] alfabet = new string[26][];
            string copie;
            for (int i = 0; i < 26; i++)
                alfabet[i] = new string[0];

            foreach(var cuvant in args)
            {
                copie = cuvant.ToUpper();
                poz = (int)copie[0] - 65;
                Array.Resize(ref alfabet[poz], alfabet[poz].Length + 1);
                length = alfabet[poz].Length;
                alfabet[poz][length - 1] = cuvant;
            }
            for (int i=0;i<26;i++)
                for (int j = 0; j < alfabet[i].Length;j++)
                    Console.WriteLine("alfabet[{0}][{1}] ={2}", i, j, alfabet[i][j]);

    
            Console.ReadKey();
                
        }
    }
}
