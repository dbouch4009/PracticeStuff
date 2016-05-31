using System;
using System.Collections.Generic;
using System.Timers;

namespace BoggleWithLists
{
    class Program
    {

        private static void HappensAtElapsed(object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Time's Up!");
        }

        static void Main(string[] args)
        {
            List<string> blocks = new List<string>();

            Random r = new Random();

            Timer t = new Timer();

            blocks.Add("AAAFRS");
            blocks.Add("AEEGMU");
            blocks.Add("CEIILT");
            blocks.Add("DHLNOR");
            blocks.Add("FIPRSY");

            blocks.Add("AAEEEE");
            blocks.Add("AEGMNN");
            blocks.Add("CEILPT");
            blocks.Add("DDLNOR");
            blocks.Add("GORRVW");

            blocks.Add("AAFIRS");
            blocks.Add("AFIRSY");
            blocks.Add("CEIPST");
            blocks.Add("EIIITT");
            blocks.Add("HIPRRY");

            blocks.Add("ADENNN");
            blocks.Add("BJKQXZ");
            blocks.Add("DHHNOT");
            blocks.Add("EMOTTT");
            blocks.Add("NOOTUW");

            blocks.Add("AEEEEM");
            blocks.Add("CCNSTW");
            blocks.Add("DHHLOR");
            blocks.Add("ENSSSU");
            blocks.Add("OOOTTU");

            int blockCount = blocks.Count; //Keeps track of remaining blocks after each iteration
            int spaceCount = 5; //Number of letter possibilities on a block
            char c; 
            string holder;  //Both used for generating a space in the cmd prompt
            
            for (int i = spaceCount; i > 0 ; i--)
            {
                for(int j = spaceCount; j > 0; j--)
                {
                    holder = blocks[r.Next(0, blockCount)];
                    c = holder[r.Next(0, spaceCount)];

                    //Console.WriteLine(holder);   Uncomment for debugging
                    blocks.Remove(holder);
                    
                    Console.Write(c + " ");


                    blockCount = blocks.Count;
                    //Console.WriteLine(blockCount);       Uncomment for debugging
                }

                Console.WriteLine();
            }

            //Timer in milliseconds
            t.Interval = 30000;
            t.Enabled = true;
            t.Start();
            Console.WriteLine("Timer set for {0}", t.Interval);

            t.Elapsed += HappensAtElapsed;

            Console.ReadLine();
        }
    }
}
