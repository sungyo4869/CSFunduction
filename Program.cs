namespace HelloWorld
{
    public class Program
    {
        public delegate void Test(string s);
        public static void Main(string[] args)
        {
           var greeting = new Greeting();
           greeting.Word = "hello";

           Console.WriteLine(greeting.Word);
        }
    }

    public class Greeting
    {
        // // private string _word;

        // // public string Word {
        // //     get { return _word; }
        // //     set { _word = value; }
        // // }

        // public string  GetWorld()
        // {
        //     return _word;
        // }

        // public void SetWorld(string word)
        // {
        //     _word = word;
        // }

        public string Word { get; set;}
    }
}