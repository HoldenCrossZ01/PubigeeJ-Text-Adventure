namespace Text_Adventure
{
    internal class Program
    {
        static void WriteLetterByLetter(string text)
        {
            for (int i = 0; i < text.Length; ++i)
            {
                Console.Write(text[i]);
                Thread.Sleep(53);
            }
        
        }
        //

        static void Main(string[] args)
        {
            WriteLetterByLetter("Hello.");
            Console.WriteLine(); // Blank Line


            string input = Console.ReadLine();
            if (input == "hello")
            {
                Thread.Sleep(900);
                WriteLetterByLetter("The Trial Shall Begin Shortly.");
                Console.WriteLine(); // Blank Line
                Console.WriteLine(); // Blank Line
            }

            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("press spacebar to continue");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(); // Blank Line
            Console.WriteLine(); // Blank Line

            ConsoleKeyInfo input2 = Console.ReadKey();
            if (input2.KeyChar == ' ')
            {
                Thread.Sleep(900);
                WriteLetterByLetter(" The room begins to darken, nonexistent lights seeming to dim.");
                

                Thread.Sleep(2000);
                WriteLetterByLetter(" A crashing sound disturbs the matching silence, muffled, as if there's a wall of earth between you and the sound.");
                

                Thread.Sleep(2000);
                WriteLetterByLetter(" Suddenly a soft ring pitches out as a hidden overhead speaker turns on.");
                Console.Beep(1700, 995);
                Console.WriteLine(); // Blank Line
                Console.WriteLine(); // Blank Line

                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                WriteLetterByLetter(" 'We Shall Begin With Small Game, A Warm-Up If You Will.'"); // DIALOGUE
                Console.WriteLine(); // Blank Line
                Console.WriteLine(); // Blank Line
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Thread.Sleep(900); //Delay between text lines. MAY NEED EDITING
                WriteLetterByLetter(" the voice was serious and hardy, yet seeming to anticipate their own words");
                Console.WriteLine(); // Blank Line
                Console.WriteLine(); // Blank Line
                Console.WriteLine(); // Blank Line
                Console.WriteLine(); // Blank Line

                Thread.Sleep(2500); //Delay between text lines. MAY NEED EDITING
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                WriteLetterByLetter(" 'Each enclosure will have a Fandril released into it's environs.'"); // DIALOGUE
                Console.WriteLine(); // Blank Line
                Console.WriteLine(); // Blank Line
                Thread.Sleep(900);//Delay between text lines. MAY NEED EDITING
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                WriteLetterByLetter(" this voice was more down to earth. like they'd be bored if this 'event' wasn't so important, which it is.");
                Console.WriteLine(); // Blank Line
                Console.WriteLine(); // Blank Line
                Console.WriteLine(); // Blank Line
                Console.WriteLine(); // Blank Line

                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                WriteLetterByLetter(" Suddenly, the wall in front of you began to open. Not like a door, but like a sliding panel; sinking down into the ground. Disturbingly seemless.");

                Thread.Sleep(3000);
                WriteLetterByLetter(" Once the wall had completely melded into the floor the same tone rang out that, which had marked the beginning of an announcement. Now marking the end of the announcement.");
                Thread.Sleep(600);
                Console.Beep(1700, 995);

            }

            Thread.Sleep(5500);
            WriteLetterByLetter(" The sun shines through the opening, blinding and leaving no place for reclusion.");
            Console.WriteLine(); // Blank Line
            Console.WriteLine(); // Blank Line

            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            WriteLetterByLetter(" 'Leave Your room? - Cling to your limited familiarity?'");
            Console.WriteLine(); // Blank Line
            Console.WriteLine(); // Blank Line

            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.White;
            WriteLetterByLetter(" were the words that suddenly burned into the floor in front of your feet, barely visible in the blinding light.");
            Console.WriteLine(); // Blank Line
            Console.WriteLine(); // Blank Line

            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" LEAVE? or STAY?"); //FIRST QUESTION CHIOICE
            Console.WriteLine(); // Blank Line
            Console.WriteLine(); // Blank Line

            string input3 = Console.ReadLine();
            if (input3 == "leave")
            {
                Console.WriteLine(); // Blank Line
                Console.WriteLine(); // Blank Line
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.White;
                WriteLetterByLetter(" Your eyes begin to adjust to the light as you step over the threshold");
                Thread.Sleep(3000);
                WriteLetterByLetter(" You've stepped into a forest.");
            }

           else if (input3 == "stay")
            {
                Console.WriteLine(); // Blank Line
                Console.WriteLine(); // Blank Line
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.White;
                WriteLetterByLetter(" Your cowardice overcomes you as you press your back to the wall at the sight of the invading light and the emblazoned" +
                    " words upon the floor.");
                Thread.Sleep(3000);
                WriteLetterByLetter(" A strange yet soft hiss begins to fill your lonesome corner of pity, coming from the wall itself.");
                Thread.Sleep(3000);
                WriteLetterByLetter(" It's not the whispers of a snake, a distant memory knows the difference, but the breathing of gas.");
                Thread.Sleep(3000);
                Console.WriteLine(); // Blank Line
                WriteLetterByLetter(" As you begin to breath in the gas you expect a strange smell, but nothing happens..");
                Console.WriteLine(); // Blank Line
                Console.WriteLine(); // Blank Line
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Thread.Sleep(4500);
                Console.WriteLine(" LEAVE? or STAY?");
                Console.ForegroundColor = ConsoleColor.White;

                string input4 = Console.ReadLine();
                if (input4 == "leave")
                {
                    Console.WriteLine(); // Blank Line
                    Console.WriteLine(); // Blank Line
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.White;
                    WriteLetterByLetter(" Your eyes begin to adjust to the light as you step over the threshold");
                    Thread.Sleep(3000);    //EDIT THIS: it needs to match the previous scenes panic
                    WriteLetterByLetter(" You've stepped into a forest.");
                }

                else if (input4 == "stay")
                {
                    Console.WriteLine(); // Blank Line
                    Console.WriteLine(); // Blank Line
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteLetterByLetter(" Suddenly a burning sensation begins to creep up your throat from deep in your chest, like a stone steaming inside your esophagus. You cough and try to dispel the feeling but as the burning sensation gets closer to your mouth you can feel it getting warmer.");
                    Thread.Sleep(5000);
                    WriteLetterByLetter(" And warmer..");
                    Thread.Sleep(3000);
                    WriteLetterByLetter(" And warmer..");
                    Thread.Sleep(3000);
                    WriteLetterByLetter(" And warmer until you feel flame dripping along your tongue.");
                    Thread.Sleep(3000);
                    WriteLetterByLetter(" You double over as you feel your throat becoming ash and your teeth being blackened, the escaping flames staining the floor in front of you with scorch.");
                    Console.WriteLine(); // Blank Line
                    Console.WriteLine(); // Blank Line
                    Thread.Sleep(5000);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" Expiration Reached.");

                }

            }


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(); // Blank Line
            Console.WriteLine(); // Blank Line
            WriteLetterByLetter("        Press space bar to exit.");
            Console.ReadKey();
        }
    }
}
