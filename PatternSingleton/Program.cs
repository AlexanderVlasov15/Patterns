using System;

namespace PatternSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Key keyWindows7 = Windows.NewKey("8DFUH9-8SYDHFH-SDW8FHN-3UBE3J");
            Console.WriteLine(keyWindows7.Value);
            Console.WriteLine();

            Key keyWindows8 = Windows.NewKey("S9DJFD-8SD8GHF-8DS7HH-A7SGBDBG");
            Console.WriteLine(keyWindows8.Value);
            Console.WriteLine();

            Key keyWindows10 = Windows.NewKey("7AHGD-AS7DUHX-A7TGTD-7ASCBSI");
            Console.WriteLine(keyWindows10.Value);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
