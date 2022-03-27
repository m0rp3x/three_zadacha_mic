
namespace ConsoleApp2
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var Rooms = new List<Room>()
            {
                new Room(), new Room(), new Room(),
                new Room(), new Room(), new Room(),
                new Room(), new Room(), new Room(),
                new Room()
            };
            foreach (var _ in Enumerable.Range(0, 3))
            {
                foreach (var i in Rooms)
                {
                    i.pay();
                }

                Console.WriteLine();
            }
        }
    }
}