using System;
using System.CodeDom;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    public class StackableOddNumbers : Stack
    {
        private readonly Sum _sum;

        public StackableOddNumbers(Sum sum)
        {
            _sum = sum;
            Console.WriteLine("Start Odd stack program using inheritance & composition...");
        }

        public void AddToStack(int num)
        {
            if (num % 2 != 0)
                _sum.AddToList(num);
        }

        public int getTotal()
        {
            return _sum.Total;
        }

    }

    public class StackableEvenNumbers : Stack
    {
        private readonly Sum _sum;

        public StackableEvenNumbers(Sum sum)
        {
            _sum = sum;
        }

        public void AddToStack(int num)
        {
            if (num % 2 == 0)
                _sum.AddToList(num);
        }

        public int getTotal()
        {
            return _sum.Total;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            var stackableOddNumbers = new StackableOddNumbers(new Sum());

            for (int i = 1; i <= 5; i++)
            {
                stackableOddNumbers.Push(i);
            }

            foreach (var s in stackableOddNumbers.StackList)
            {
                stackableOddNumbers.AddToStack(Convert.ToInt32(s));
                Console.WriteLine(s);

            }

            Console.WriteLine("\nTotal Odd Numbers {0}" ,stackableOddNumbers.getTotal());

            Console.WriteLine("\nStart pop from Stack..");

            while (stackableOddNumbers.StackList.Count != 0)
            {
                Console.WriteLine(stackableOddNumbers.Pop());
            }


            var stackableEvenNumbers = new StackableEvenNumbers(new Sum());

            for (int i = 1; i <= 5; i++)
            {
                stackableEvenNumbers.Push(i);
            }

            foreach (var s in stackableEvenNumbers.StackList)
            {
                stackableEvenNumbers.AddToStack(Convert.ToInt32(s));
                Console.WriteLine(s);

            }

            Console.WriteLine("\nTotal Even Numbers {0}", stackableEvenNumbers.getTotal());

            Console.WriteLine("\nStart pop from Stack..");

            while (stackableEvenNumbers.StackList.Count != 0)
            {
                Console.WriteLine(stackableEvenNumbers.Pop());
            }

            stackableEvenNumbers.Clear();
        }
    }
}
