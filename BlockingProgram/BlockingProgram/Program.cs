using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockingProgram
{
    class Program : abstClass, iAbstClass2, iAbstClass3
    {
        public void add1(int n)
        {
            //n = 10;
            n = n + 1;
            Console.WriteLine("Add1 : " + n);
        }
        public void add2(ref int n)
        {
            n = n + 1;
            Console.WriteLine("Add2 : " + n);
        }
        public void add3(out int n)
        {
            n = 10;
            n = n + 1;
            Console.WriteLine("Add3 : " + n);
        }
        protected override void add4(int p)
        {
            p = p + 1;
            Console.WriteLine("Abstact : " + p);
        }

        void iAbstClass2.add4(int p)
        {
            p = p + 1;
            Console.WriteLine("Inteface 1 : " + p);
        }
        void iAbstClass3.add4(int p)
        {
            p = p + 1;
            Console.WriteLine("Interface 2 :" + p);
        }
        static void Main(string[] args)
        {
            int n = 10;
            int p;
            Program objProgram = new Program();
            objProgram.add1(n);
            Console.WriteLine("After Add1 : " + n);
            objProgram.add2(ref n);
            Console.WriteLine("After Add2 : " + n);
            //p = n;
            objProgram.add3(out n);
            Console.WriteLine("After Add3 : " + n);
            objProgram.add4(n);
            iAbstClass2 obj = objProgram;
            obj.add4(n);
            iAbstClass3 obj1 = objProgram;
            obj1.add4(n);
            Console.ReadKey();

        }
    }

    public abstract class abstClass
    {
        //int n = 25;
        protected abstract void add4(int p);
        //{
        //    Console.WriteLine("Abstact : " + p);
        //}
    }

    interface iAbstClass2
    {
        void add4(int p);
    }
    interface iAbstClass3
    {
        void add4(int p);
    }
}
