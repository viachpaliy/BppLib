using System;
using BppLib.Core;
using System.Collections.Generic;
using System.IO;

namespace BppLib.Core.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Uses <c>WallCabinet</c> class for generation 3 .bpp files;
            WallCabinet wallCabinet = new WallCabinet() ;
            string dir=@"C:\WNC\home\d_xnc\p_p\prog\TestPrg";
            wallCabinet.saveBppPrg(dir);

            var prg = new BiesseProgram();
            prg.Lpx = 800;
            prg.Lpy = 320;
            prg.Lpz = 18;
            prg.Origins = "5,8";
            /// Uses extension method of <c>CustomOperations</c> class for generation machining operation.
            prg.MiniFixOperation(2, 37);
            string fileName = dir +"\\" + "Minifx800x320.bpp";
            File.WriteAllText(fileName, prg.AsBppCode());
        }
    }
}
