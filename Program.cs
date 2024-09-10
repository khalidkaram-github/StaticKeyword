namespace StaticKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var users = new List<User>
            {
                new User(),
                new User(),
                new User()
            };

            foreach (var user in users)
            {
                Console.WriteLine(user.Counter);
            }

        }
    }
    class User
    {
        public int Counter { get; set; }

        public static int MyProperty { get; set; }
        static User()
        {
            MyProperty = 10;
        }

        public User()
        {
            Counter++;
        }
        public int Age { get; set; }
        public string Name { get; set; }

        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public static void SayWelcome()
        {
            Console.WriteLine("Welcome");
        }

    }
}
