namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hic Sunt Leones.");

            string input = Console.ReadLine();

            if (input == "HIC SUNT LEONES!")
            {
                Console.WriteLine("Break The Chains.");
            }

            else if (input == "Hic Sunt Leones.")
            {
                Console.WriteLine("Welcome H.");

                    Console.WriteLine("further instruction?"); 

                string input3 = Console.ReadLine();
                if (input3 == "Continue");
                {
                    Console.WriteLine(); // HERE*
                }


            }

            else

            {
                Console.WriteLine("Say Again?");
            }
            string input2 = Console.ReadLine();

            if (input2 =="HIC SUNT LEONES!")
            {
                Console.WriteLine("Close Enough.");
            }

            else
            {
                Console.WriteLine("Excute This One.");
            }

        }
    }
}
