using System;
using BppLib.Core;
using System.Collections.Generic;
using System.IO;

namespace BppLib.Core.Examples
{
    /// <summary>Class <c>WallCabinet</c> models the wall cabinet with a shelf and two doors.</summary>
    public class WallCabinet
    {
        public double Width { get; set;} = 800 ;

        public double Height { get; set; } = 800 ; 

        public double Depth { get; set; } = 320 ;

        
        public WallCabinet (double width = 800, double height = 800, double depth = 320)
        {
            Width = width;
            Height = height;
            Depth = depth;
        }

        public BiesseProgram getLeftSidePrg()
        {
            var prg = new BiesseProgram();
            prg.MainData.Lpx = Height;
            prg.MainData.Lpy = Depth;
            prg.MainData.Lpz = 18;
            prg.MainData.OrLst = "5";
            prg.ProgramSec.BiesseEntities.Add(new Bv{Id="D7L19", Side=0, Crn="1,2,4,3", X=9, Y=50, Z=0, Dp=19, Dia=7, Ttp=1});
            prg.ProgramSec.BiesseEntities.Add(new Bv{Id="Shelf", Side=0, Crn="1,2", X=(Height/2 - 11), Y=50, Z=0, Dp=13, Dia=5});
            prg.ProgramSec.BiesseEntities.Add(new CutX{Side=0, Crn="1", X=0, Y=(Depth - 18), Dp=8, L=Height, Crc=2, Th=3.5});
            return prg;
        }

        public BiesseProgram getRightSidePrg()
        {
            var prg = new BiesseProgram();
            prg.MainData.Lpx = Height;
            prg.MainData.Lpy = Depth;
            prg.MainData.Lpz = 18;
            prg.MainData.OrLst = "5";
            prg.ProgramSec.BiesseEntities.Add(new Bv{Id="D7L19", Side=0, Crn="1,2,4,3", X=9, Y=50, Z=0, Dp=19, Dia=7, Ttp=1});
            prg.ProgramSec.BiesseEntities.Add(new Bv{Id="Shelf", Side=0, Crn="1,2", X=(Height/2 + 11), Y=50, Z=0, Dp=13, Dia=5});
            prg.ProgramSec.BiesseEntities.Add(new CutX{Side=0, Crn="1", X=0, Y=(Depth - 18), Dp=8, L=Height, Crc=2, Th=3.5});
            return prg;
        }

        public BiesseProgram getTopBottomPrg()
        {
           var prg = new BiesseProgram();
            prg.MainData.Lpx = Height - 36 ;
            prg.MainData.Lpy = Depth;
            prg.MainData.Lpz = 18;
            prg.MainData.OrLst = "5"; 
            prg.ProgramSec.BiesseEntities.Add(new Bh{Id="LeftSide", Side=1, Crn="1,4", X=50, Y=0, Z=0, Dp=35, Dia=4.5, Md = true});
            prg.ProgramSec.BiesseEntities.Add(new Bh{Id="RightSide", Side=3, Crn="1,4", X=50, Y=0, Z=0, Dp=35, Dia=4.5, Md = true});
            prg.ProgramSec.BiesseEntities.Add(new CutX{Side=0, Crn="1", X=0, Y=(Depth - 18), Dp=8, L=(Height - 36), Crc=2, Th=3.5});
            return prg;
        }
    
        public void saveBppPrg()
        {
            string dir=@"C:\WNC\home\d_xnc\p_p\prog\TestPrg";
            string LeftSideFileName = dir + "\\" + "LeftSide" + Height.ToString() + "x" + Depth.ToString() + ".bpp";
            string RightSideFileName = dir + "\\" + "RightSide" + Height.ToString() + "x" + Depth.ToString() + ".bpp";
            string TopBottomFileName = dir + "\\" + "TopBottom" + (Height - 36).ToString() + "x" + Depth.ToString() + ".bpp";
            File.WriteAllText(LeftSideFileName,getLeftSidePrg().AsBppCode());
            File.WriteAllText(RightSideFileName,getRightSidePrg().AsBppCode());
            File.WriteAllText(TopBottomFileName,getTopBottomPrg().AsBppCode());
        }

    }
}