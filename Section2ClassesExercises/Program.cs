using System.Runtime.CompilerServices;
using System.Diagnostics;
using System;

namespace Section2ClassesExercises
{
    class Program
    {
        private static StopWatch stopWatch = new StopWatch();

        static void Main(string[] args)
        {

        }

        static void testStopWatch()
        {
            try
            {

                // validOperation();
                // twoStarts();
                // twoStops();
                noStart();

            }
            catch (System.InvalidOperationException e)
            {
                System.Console.WriteLine("The operation is not valid due to the current state of the StopWatch object.\nSee below for the stack trace of the error\n\n");
                System.Console.WriteLine(e.StackTrace);
            }
        }

        static void validOperation()
        {
            stopWatch.start();
            System.Threading.Thread.Sleep(1000);
            stopWatch.stop();
            System.Console.WriteLine(stopWatch.getDuration());
        }

        static void twoStarts()
        {
            stopWatch.start();
            System.Threading.Thread.Sleep(1000);
            stopWatch.start();
            System.Console.WriteLine(stopWatch.getDuration());
        }

        static void twoStops()
        {
            stopWatch.stop();
            System.Threading.Thread.Sleep(1000);
            stopWatch.stop();
            System.Console.WriteLine(stopWatch.getDuration());
        }

        static void noStart()
        {
            System.Console.WriteLine(stopWatch.getDuration());
        }
    }
}
