namespace helloapp_black
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello everyone");
            GreetBlack();
        }

        private static void GreetBlack()
        {
            Console.WriteLine("hello black");
        }

        private static void GreetWhite()
        {
            Console.WriteLine("hello white");
        }
    }
}