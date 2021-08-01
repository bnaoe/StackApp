using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    public class Stackable : Stack
    {
        public Stackable()
        {
            Console.WriteLine("Start stack program...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var stackable= new Stackable();

            stackable.Push(1);
            stackable.Push(2);
            stackable.Push(3);
            stackable.Push(4);
            stackable.Push(5);

            foreach (var s in stackable.StackList)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Start pop from Stack..");

            Console.WriteLine(stackable.Pop());
            Console.WriteLine(stackable.Pop());
            Console.WriteLine(stackable.Pop());
            Console.WriteLine(stackable.Pop());
            Console.WriteLine(stackable.Pop());

            Console.WriteLine("Start Stack Clear...");

            stackable.Clear();
        }
    }
}
