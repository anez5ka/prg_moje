using System;
namespace HWConsoleGame__Mac_
{
    public class Character
    {
        int a, b, c, d;
        string A, B, C, D, AA, BB,CC,DD;

        public Character(int a, int b, int c, int d, string A, string B, string C, string D, string AA, string BB, string CC, string DD)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.AA = AA;
            this.BB = BB;
            this.CC = CC;
            this.DD = DD;
        }
        public void Ask()
        {
            if (a == 0)
            {
                Write.Long($"a) {A}");
            }
            else if (b == 0)
            {
                Write.Long($"b) {B}");
            }
            else if (c == 0)
            {
                Write.Long($"c) {C}");
            }
            else if (d == 0)
            {
                Write.Long($"d) {D}");
            }
        }
        public void Answer(int answer)
        {
            while (0 == 0)
            {
                if (a == answer)
                {
                    Write.Long($"a) {A}");
                    a++;
                }
                else if (b == answer)
                {
                    Write.Long($"b) {B}");
                    b++;
                }
                else if (c == answer)
                {
                    Write.Long($"c) {C}");
                    c++;
                }
                else if (d == answer)
                {
                    Write.Long($"d) {D}");
                    d++;
                }
                else
                {
                    Write.Long("spatna klavesa");
                }
            }
            
        }
        static string ReadOneKey()
        {
            string OneKey = Convert.ToString(Console.ReadLine()).Substring(0, 1);
            return OneKey;
        }
    }
}

