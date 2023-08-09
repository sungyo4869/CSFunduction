namespace HelloWorld
{
    public class Program
    {
        public delegate void Test(string s);
        public static void Main(string[] args)
        {
            // var test = new Test(TestMethod1);

            var test = delegate (string s) 
            {
                Console.WriteLine(s + "!");
            };
            test("yes");
        }

        // public static void TestMethod1 (string s)
        // {
        //     Console.WriteLine(s + "!");
        // }
    }
}