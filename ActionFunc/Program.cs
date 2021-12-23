using System;
using System.Threading;

namespace ActionFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryCatch();
            //ActionDemo();


            Func<int, int, int> add = Topla;

            Console.WriteLine(add(4,3));


            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            
            Func<int> getRandomNumber1 = () => new Random().Next(1, 100);
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);

            Console.WriteLine(getRandomNumber1());
            Thread.Sleep(1000);
            Console.WriteLine(getRandomNumber2());


            //Console.WriteLine(Topla(2,3));



            Console.ReadKey();
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }






        private static void ActionDemo()
        {
            //Action
            HandleException(() =>
            {
                Find();
            });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {

            }
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public static void Find()
        {

        }
    }
}
