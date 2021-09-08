using System;
using System.Collections.Generic;
using System.IO;
using BppLib.CIDFile;

namespace BppLib.CID.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir=@"C:\WNC\home\d_xnc\p_p\prog\TestPrg";
            ///------------------------------------------------------------------------------------------
            /// Boring 
            ///-----------------------------------------------------------------------------------------
            var prg = new CIDProgram{Lx = 800, Ly = 300, Lz = 18, FileName = "CidBoringExample"};

            var tech1 = new Tech{Cat = 1, Typ = 1, Diam = 4.5, DepthStart = 34, DepthEnd = 34, Ang0 = 0, Ang1 = 270};
            var bore1 = new Custom{TechBlock = tech1, RefPoint = 2, X = 700, Y = 300, Z = 9};
            prg.Operations.Add(bore1);
            var bore2 = new Custom{TechBlock = tech1, RefPoint = 2, X = 100, Y = 300, Z = 9};
            prg.Operations.Add(bore2);

            var tech2 = new Tech{Cat = 1, Typ = 1, Diam = 4.5, DepthStart = 34, DepthEnd = 34, Ang0 = 0, Ang1 = 180};
            var bore3 = new Custom{TechBlock = tech2, RefPoint = 2, X = 800, Y = 60, Z = 9};
            prg.Operations.Add(bore3);
            var bore4 = new Custom{TechBlock = tech2, RefPoint = 2, X = 800, Y = 240, Z = 9};
            prg.Operations.Add(bore4);

            var tech3 = new Tech{Cat = 1, Typ = 1, Diam = 8, DepthStart = 30, DepthEnd = 30, Ang0 = 0, Ang1 = 0};
            var bore5 = new Custom{TechBlock = tech3, RefPoint = 2, X = 0, Y = 263, Z = 9};
            prg.Operations.Add(bore5);
            var bore6 = new Custom{TechBlock = tech3, RefPoint = 2, X = 0, Y = 37, Z = 9};
            prg.Operations.Add(bore6);

            var tech4 = new Tech{Cat = 1, Typ = 1, Diam = 8, DepthStart = 22, DepthEnd = 22, Ang0 = 0, Ang1 = 0};
            var bore7 = new Custom{TechBlock = tech4, RefPoint = 2, X = 0, Y = 231, Z = 9};
            prg.Operations.Add(bore7);
            var bore8 = new Custom{TechBlock = tech4, RefPoint = 2, X = 0, Y = 69, Z = 9};
            prg.Operations.Add(bore8);

            var tech5 = new Tech{Cat = 1, Typ = 1, Diam = 15, DepthStart = 13.5, DepthEnd = 13.5, Ang0 = 90, Ang1 = 0};
            var bore9 = new Custom{TechBlock = tech5, RefPoint = 2, X = 34, Y = 263, Z = 0};
            prg.Operations.Add(bore9);
            var bore10 = new Custom{TechBlock = tech5, RefPoint = 2, X = 34, Y = 37, Z = 0};
            prg.Operations.Add(bore10);

            var tech6 = new Tech{Cat = 1, Typ = 1, Diam = 8, DepthStart = 30, DepthEnd = 30, Ang0 = 0, Ang1 = 90};
            var bore11 = new Custom{TechBlock = tech6, RefPoint = 2, X = 100, Y = 0, Z = 9};
            prg.Operations.Add(bore11);
            var bore12 = new Custom{TechBlock = tech6, RefPoint = 2, X = 700, Y = 0, Z = 9};
            prg.Operations.Add(bore12);

            var tech7 = new Tech{Cat = 1, Typ = 1, Diam = 8, DepthStart = 22, DepthEnd = 22, Ang0 = 0, Ang1 = 90};
            var bore13 = new Custom{TechBlock = tech6, RefPoint = 2, X = 132, Y = 0, Z = 9};
            prg.Operations.Add(bore13);
            var bore14 = new Custom{TechBlock = tech6, RefPoint = 2, X = 668, Y = 0, Z = 9};
            prg.Operations.Add(bore14); 

            var bore15 = new Custom{TechBlock = tech5, RefPoint = 2, X = 100, Y = 34, Z = 0};
            prg.Operations.Add(bore15);
            var bore16 = new Custom{TechBlock = tech5, RefPoint = 2, X = 700, Y = 34, Z = 0};
            prg.Operations.Add(bore16);  

            string fileName = dir +"\\" + prg.FileName + ".cid";
            File.WriteAllText(fileName, prg.AsCidCode()); 

        }
    }
}
