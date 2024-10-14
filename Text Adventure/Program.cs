namespace Text_Adventure
{
    internal class Program
    {

        static void NormalReaction()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(300);
            WriteLetterByLetter(" Hmm.");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(); // Blank Line
            Console.WriteLine(); // Blank Line
        }

        private enum Item
        {
            stick,
            rock,
            pinecone,
            nothing
        }

        

        static void WriteLetterByLetter(string text)
        {
            for (int i = 0; i < text.Length; ++i)
            {
                Console.Write(text[i]);
                Thread.Sleep(49);
            }
        
        }
        //
        static void EndMessage()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(); // Blank Line
            Console.WriteLine(); // Blank Line
            WriteLetterByLetter("        Press space bar to exit.");
            Console.ReadKey();
        }

        private static bool hasExpired = false;
        private static bool isOutside = false;  

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


                Thread.Sleep(1300);
                WriteLetterByLetter(" A crashing sound disturbs the matching silence, muffled, as if there's a wall of earth between you and the sound.");
                

                Thread.Sleep(1300);
                WriteLetterByLetter(" Suddenly a soft ring pitches out as a hidden overhead speaker turns on.");
                Console.Beep(1700, 995);
                Console.WriteLine(); // Blank Line
                Console.WriteLine(); // Blank Line

                Thread.Sleep(1300);
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

                Thread.Sleep(1300); //Delay between text lines. MAY NEED EDITING
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                WriteLetterByLetter(" 'Each enclosure will have a Fandril released into it's environs.'"); // DIALOGUE
                Console.WriteLine(); // Blank Line
                Console.WriteLine(); // Blank Line
                Thread.Sleep(900);//Delay between text lines. MAY NEED EDITING
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                WriteLetterByLetter(" this voice was more down to earth. like they'd be bored if this 'event' wasn't so important, which it seems to be.");
                Console.WriteLine(); // Blank Line
                Console.WriteLine(); // Blank Line
                Console.WriteLine(); // Blank Line
                Console.WriteLine(); // Blank Line

                Thread.Sleep(1300);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                WriteLetterByLetter(" Suddenly, the wall in front of you began to open. Not like a door, but like a sliding panel; sinking down into the ground. Disturbingly seemless.");

                Thread.Sleep(1300);
                WriteLetterByLetter(" Once the wall had completely melded into the floor the same tone rang out that, which had marked the beginning of an announcement. Now marking the end of the announcement.");
                Thread.Sleep(600);
                Console.Beep(1700, 995);

            }

            Thread.Sleep(2010);
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
                Thread.Sleep(900);
                WriteLetterByLetter(" and a strange hissing fills the cave-like room behind as you leave.");
                Thread.Sleep(900);
                WriteLetterByLetter(" With a frown you ignore it and look to what lies ahead.");

                bool isOutside = true;
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
                    WriteLetterByLetter(" You panic at the sound of the gas and rush out through the opening.");
                    Thread.Sleep(3000);    //EDIT THIS: it needs to match the previous scenes panic
                    WriteLetterByLetter(" After forcing yourself to cough and expel the gas you begin to take in your background.");
                    Thread.Sleep(3000);    //EDIT THIS: it needs to match the previous scenes panic
                    WriteLetterByLetter(" Noting how the gas hadn't tasted nor smelt any different from air but you could've sworn you felt a few wisps of flame exit your mouth with the fumes.");
                    bool isOutside = true;
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
                    hasExpired = true;    
                }

                

                if (isOutside == true)
                {

                    Thread.Sleep(3000);
                    WriteLetterByLetter("You shake off the remaining shaken feelings from that cave-like room.");
                    Thread.Sleep(900);
                    WriteLetterByLetter("Taking in your surroundings, you begin to notice the grass beneath your boots.");
                    Thread.Sleep(700);
                    WriteLetterByLetter("The massive trees with low hanging branches around you,");
                    Thread.Sleep(700);
                    Console.WriteLine(" ");
                    WriteLetterByLetter("and the relieving scent of morning dew, like a foggy morning in the mountains");
                    Console.WriteLine(); // Blank Line
                    Console.WriteLine(); // Blank Line
                   Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Thread.Sleep(900);
                    WriteLetterByLetter(" Strange, I don't remember being to any mountains..");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(700);
                    WriteLetterByLetter(" You frowned in confusion.");
                    Thread.Sleep(700);
                    WriteLetterByLetter(" Which only worsened as you noticed how the grass was dry,");
                    Console.WriteLine(); // Blank Line
                    Console.WriteLine(); // Blank Line
                    Thread.Sleep(1200);
                    WriteLetterByLetter(" You shrug it off and begin to walk through the forest,");
                    Thread.Sleep(900);
                    WriteLetterByLetter(" enjoying the sun and grass.");

                    Console.WriteLine(); // Blank Line
                    Console.WriteLine(); // Blank Line
                    Thread.Sleep(1300);
                    WriteLetterByLetter(" You come across a flattened ring of flora,");
                    Thread.Sleep(900);
                    WriteLetterByLetter(" smushed.");
                    Thread.Sleep(1000);
                    WriteLetterByLetter(" Upon looking up you see a gap in branches.");
                    Thread.Sleep(900);
                    WriteLetterByLetter(" Something had fallen from the sky and landed here.");
                    Thread.Sleep(1000);
                    WriteLetterByLetter(" Most of the debris is supersized to match the forest, however some of it is small enough");

                    Console.WriteLine(); // Blank Line
                    Console.WriteLine(); // Blank Line
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Thread.Sleep(700);
                    Console.WriteLine(" Pick up a stick, pinecone, rock, or nothing?");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(); // Blank Line
                    Console.WriteLine(); // Blank Line

                    string input5= Console.ReadLine();
                    if (input5 == "nothing") 
                    {
                        NormalReaction();
                        Item item = Item.nothing;
                    }

                    else if (input5 == "rock")
                    {
                        NormalReaction();
                        Item item = Item.rock;
                    }

                    else if (input5 == "pinecone") 
                    {
                        NormalReaction();
                        Item item = Item.pinecone;
                    }

                    else if (input5 == "stick")
                    {
                        NormalReaction();
                        Item item = Item.stick;
                    }



                }


            }

            if (hasExpired == true)
            {
                EndMessage();
            }
            
        }
    }
}
// I have RUBRIC CATEGORIES:...