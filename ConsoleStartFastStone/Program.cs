using System;
using System.IO;

namespace ConsoleStartFastStone
{
    class Program
    {
        // FastStoneService _fastStoneService;

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Test1();
        }


        static void Test1()
        {
            /*
             * f:\SHARE2\Projects\20240709104824\01_pr\01\ConsoleStartFastStone\ConsoleStartFastStone\AppFiles\Imgs\Screenshot_1.png
             * f:\SHARE2\Projects\20240709104824\01_pr\01\ConsoleStartFastStone\ConsoleStartFastStone\AppFiles\Imgs\Screenshot_8.png
             */

            string _directoryImgs = @"AppFiles\Imgs\";
            string nameFile = "Screenshot_1.png";

            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _directoryImgs, nameFile); // \AppFiles\Imgs\Screenshot_1.png

            FastStoneService.OpenInFastStoneExecuted(filePath);
        }
    }
}
