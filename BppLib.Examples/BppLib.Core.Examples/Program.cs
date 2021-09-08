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

            ///------------------------------------------------------------------------------------------
            /// Boring 
            ///------------------------------------------------------------------------------------------
            var prg = new BiesseProgram();
            prg.Lpx = 800;
            prg.Lpy = 320;
            prg.Lpz = 18;
            prg.Origins = "5,8";
            /// Uses extension method of <c>CustomOperations</c> class for generation machining operation.
            prg.MiniFixOperation(2, 37);
            /// write file as .bpp
            string fileName = dir +"\\" + "Minifx800x320.bpp";
            File.WriteAllText(fileName, prg.AsBppCode());
            /// write file as .cix
            fileName = dir +"\\" + "Minifx800x320.cix";
            File.WriteAllText(fileName, prg.AsCixCode());

            ///--------------------------------------------------------------------------------------------
            /// Milling
            ///--------------------------------------------------------------------------------------------
            var millPrg = new BiesseProgram();
            prg.Lpx = 800;
            prg.Lpy = 528;
            prg.Lpz = 18;
            prg.Origins = "5,8";
            /// Uses extension method of <c>MillingExample</c> class for generation milling operation.
            millPrg.Operation();
            /// write file as .bpp
            fileName = dir +"\\" + "MillingExample.bpp";
            File.WriteAllText(fileName, millPrg.AsBppCode());
            /// write file as .cix
            fileName = dir +"\\" + "MillingExample.cix";
            File.WriteAllText(fileName, millPrg.AsCixCode());

            ///-------------------------------------------------------------------------------------------
            /// Global variable 
            /// "If" branching
            ///--------------------------------------------------------------------------------------------
            var prgExample = new BiesseProgram();
            prg.Lpx = 797;
            prg.Lpy = 397;
            prg.Lpz = 19.3;
            prg.Origins = "5,8";
            /// Uses extension method of <c>VariableIfBranchExample</c> class for generation milling operations.
            prgExample.KitchenDoorOperation(60,30);
            /// write file as .bpp
            fileName = dir +"\\" + "KitchenDoor.bpp";
            File.WriteAllText(fileName, prgExample.AsBppCode());
            /// write file as .cix
            fileName = dir +"\\" + "KitchenDoor.cix";
            File.WriteAllText(fileName, prgExample.AsCixCode());

        }
    }
}
