namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var House = new House("A");
            House.Create();
        }
    }

    class House
    {
        public string Name;
        public House(string name)
        {
            Name = name;
        }
        public void Create()
        {
            Console.WriteLine(Name + "さんの家を作りました!");
        }
    }
}