using System;

namespace Library2
{
    public class Minus
    {
        private string V1, V2;

        public Minus(string v1, string v2)
        {
            this.V1 = v1;
            this.V2 = v2;
        }

        public string getMinus(string v1, string v2)
        {

            return "" + (double.Parse(V1) - double.Parse(V2));
        }
    }
}
