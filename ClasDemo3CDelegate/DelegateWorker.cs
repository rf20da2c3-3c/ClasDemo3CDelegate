using System;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ClasDemo3CDelegate
{
    internal class DelegateWorker
    {
        // Erklæring af delegate dvs type
        public delegate void MyMethodType(int i, int j);

        /*
         * Forhåndsdefineret typer
         *
         * Action<....> => alle har en returtype void (kan have 0-15 parametre
         * Action<int,int> 
         *
         *
         * Func<....., returType> har alle returtype (kan have 0-15 parametre)
         * Func<int,int,double>  => double XXX(int i , int j)
         *
         *
         * Predicate = en function<....., bool> 
         *
         */


        // oprette metode reference
        //private MyMethodType minMetode;
        private Action<int, int> minMetode;





        public DelegateWorker()
        {
        }

        public void Start()
        {
            minMetode = MinMetode;

            // bruger metode
            minMetode(4, 24);

            // tildeler via lambda
            minMetode = (i, j) => { Console.WriteLine("Hej med dig summe er " + (i + j)); };
            minMetode(4, 24);


            // tilføjer endnu en metode så der nu er to
            minMetode += MinMetode;
            minMetode(4, 24);


            
            



        }

        private void MinMetode(int n1, int n2)
        {
            Console.WriteLine($"Dette er n1={n1} og n2={n2}");
        }
    }
}