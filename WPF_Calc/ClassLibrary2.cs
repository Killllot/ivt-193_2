using System;

namespace ClassLibrary2
{
    public class Plus
    {
        private string a;
        private string b;

        public Plus(string a, string b)
        {
            this.a = a;
            this.b = b;
        }

        public string GetSum()
        {
            /*int tmp1 = Int32.Parse(a);
            int tmp2 = Int32.Parse(b);
            int tmp3 = tmp1 + tmp2;*/
            return "" + (Int32.Parse(a) + Int32.Parse(b));
        }

        public string GetSum(string a)
        {

            return "" + (Int32.Parse(a) + Int32.Parse(a));
        }
        public string GetSum(string a, string msg)
        {

            return "" + (Int32.Parse(a) + msg);
        }


    }
}