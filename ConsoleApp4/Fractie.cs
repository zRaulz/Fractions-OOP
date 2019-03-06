using System;

namespace ConsoleApp4
{ 
    public class Fractie
    {

        private int numarator, numitor;
       

        public Fractie()
        {
            numarator = 0;
            numitor = 1;
        }

        public Fractie(string v)
        {
            string[] tokens = v.Split('/');
            int numarator, numitor;
            if (tokens.Length != 2)
            {
                this.numarator = 0;
                this.numitor = 1;

            }
            else
            {

                bool r1 = int.TryParse(tokens[0], out numarator);
                bool r2 = int.TryParse(tokens[1], out numitor);

                if (r1 && r2)
                {
                    int d;
                    d = Util.gcd(numarator, numitor);
                    this.numarator = numarator/d;
                    this.numitor = numitor/d;
                }
                else {
                    this.numarator = 0;
                    this.numitor = 1;
                }
            }
        }

        public Fractie Add(Fractie right)
        {
            int r_numarator, r_numitor;
            r_numitor = numitor * right.numitor;
            r_numarator = numarator * right.numitor + numitor * right.numarator;
            return new Fractie(r_numarator, r_numitor);
        }
        public Fractie Multiply(Fractie right)
        {

            int final_1, final_2;

            final_1 = numarator * right.numarator;
            final_2 = numitor * right.numitor;
            return new Fractie(final_1, final_2);



        }
        public Fractie Divide( Fractie right)
        {
            int final1, final2;
            final1 = numarator * right.numitor;
            final2 = numitor * right.numarator;
            return new Fractie(final2, final1);

        }
        public Fractie Substract(Fractie right)
        {
            int x, y;
            x = numarator * right.numitor-right.numarator*numitor;
            y = numitor * right.numitor;
            
            return new Fractie(x, y);

        }
        public Fractie(int numarator, int numitor)
        {
            int d = Util.gcd(numarator, numitor);
            this.numarator = numarator / d;
            this.numitor = numitor / d;
           

        }
            public void Print()
            {
                Console.WriteLine(numarator + "/" + numitor);
            }
        

    }

    public class Util
    {
        public Util()
        {
        }
        public static int gcd(int a, int b)
        {
            int r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;

        }
    }
}
    

   
