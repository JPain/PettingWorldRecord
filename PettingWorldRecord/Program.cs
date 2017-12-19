using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PettingWorldRecord
{
    class Program
    {
        static bool _dogToggle;
        static int _mashCount;
        static int _pettedCount;

        static void Main(string[] args)
        {
            Console.WriteLine("Ready to beat the world record in dog petting?");
            Console.WriteLine("Mash Space to pet a dog");
            Console.WriteLine("When a dog has been fully pet, you will move on to the next one");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to start");

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("Press Enter to start");
            }

            _pettedCount = 0;
            _mashCount = 0;

            WriteDog(true);

            Console.CursorVisible = false;

            GetPetting:

            do
            {
                while (Console.ReadKey().Key != ConsoleKey.Spacebar) { }
                WriteDog(true);
                _mashCount++;

                while (Console.ReadKey().Key != ConsoleKey.Spacebar) { }
                WriteDog(false);
                _mashCount++;

            }
            while (_mashCount < 20);

            _pettedCount++;
            WriteDog(true);
            _mashCount = 0;

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            WriteDog(true);
            Thread.Sleep(100);
            Console.BackgroundColor = ConsoleColor.Black;
            WriteDog(true);

            if (true)
            {
                goto GetPetting;
            }
            

            Console.ReadKey();
        }

        private static void WriteDog(bool dogToggle)
        {
            _dogToggle = dogToggle;

            Console.Clear();
            Console.WriteLine("Dogs Petted: " + _pettedCount);

            if (dogToggle)
            {
                Console.WriteLine("          __");
                Console.WriteLine(" \\ ______/ V`-,");
                Console.WriteLine("  }        /~~");
                Console.WriteLine(" /_)^ --,r'");
                Console.WriteLine("|b      |b");
            }
            else
            {
                Console.WriteLine("          __");
                Console.WriteLine("  /______/ V`-,");
                Console.WriteLine("  }        /~~");
                Console.WriteLine(" /_)^ --,r'");
                Console.WriteLine("|b      |b");
            }
        }
        private static void UpdateDog(int petted)
        {
            Console.Clear();
            Console.WriteLine("Dogs Petted: " + _pettedCount);

            if (_dogToggle)
            {
                Console.WriteLine("          __");
                Console.WriteLine(" \\ ______/ V`-,");
                Console.WriteLine("  }        /~~");
                Console.WriteLine(" /_)^ --,r'");
                Console.WriteLine("|b      |b");
            }
            else
            {
                Console.WriteLine("          __");
                Console.WriteLine("  /______/ V`-,");
                Console.WriteLine("  }        /~~");
                Console.WriteLine(" /_)^ --,r'");
                Console.WriteLine("|b      |b");
            }
        }
    }
}
