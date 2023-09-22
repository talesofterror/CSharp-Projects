namespace Story
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("", "Player", 100, 100);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" );
            Console.WriteLine("      (((((( You find yourself in a lush grove of  ))))))     " );
            Console.WriteLine("      (((((( fruit bearing trees. They're not like ))))))     " );
            Console.WriteLine("      (((((( any fruits you've ever seen before.   ))))))     " );
            Console.WriteLine("      (((((( These are pink slimes are dripping    ))))))     " );
            Console.WriteLine("      (((((( off the twisting red branches, as     ))))))     " );
            Console.WriteLine("      (((((( though their ripened state is natural ))))))     " );
            Console.WriteLine("      (((((( rot. You see a large pink beast       ))))))     " );
            Console.WriteLine("      (((((( sitting cross legged at the base of   ))))))     " );
            Console.WriteLine("      (((((( of the tree, staring directly at you  ))))))     " );
            Console.WriteLine("      (((((( waiting for you to notice him.        ))))))     " );
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" );
            Console.WriteLine("Oh hi. What's your name? " );
            string i_playerName = Console.ReadLine();
            player.name = i_playerName;
            Console.WriteLine("Hello " + player.name + ". Welcome to hell. ");
            Console.Write("Your health is currently at " + player.healthStatus + ". ");
            Console.Write("Be careful not to fall down any steep cliffs. Take a look around. ");
            Console.Write("*end of story* \nPress any key to exit");
            Console.ReadLine();
        }
    }
}