using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace W4D5_Training_Ses1
{
    class SampleClass
    {
        public void AsyncDisplay()
        {
            
            Thread t = new Thread(() => { CallThisNext(); });
            Thread tt = new Thread(() => { CallThisNextAgain(); });
            t.Start();
            tt.Start();

            Console.WriteLine("Start Thread");
        }

        public void CallThisNext()
        {
            Console.WriteLine("This has no order");
        }

        public void CallThisNextAgain()
        {
            Console.WriteLine("This ALSO has no order");
        }
    }

    
    
    class Program
    {
        
        static void Main(string[] args)
        {
            SampleClass t = new SampleClass();
            Console.WriteLine("This is called first");
            
            Console.WriteLine("Calling this thread Display next");
            t.AsyncDisplay();
            Console.ReadLine();
        }
    }
}
