namespace C_Sharp
{
    internal class Program
    {
        int Add(int a, int b)

        {
            return a + b;
        }

        static void Main(String[] args)
        {
            int a = 2;
            int b = 5;
            int result = a + b;
            Console.WriteLine(result);
            test.Increment(ref a);
            test.Ref();
            //list.array();
            //Dict.dictionary();
            Linq.grade();
            //print.example();
        }
    }
}
