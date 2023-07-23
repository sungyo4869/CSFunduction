namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var House = new House();
            House.Create("A");
        }
    }

    class House
    {
        public void Create(string name)
        {
            Console.WriteLine(name + "さんの家を作りました!");
        }
    }
}