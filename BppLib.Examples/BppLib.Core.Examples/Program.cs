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
            /// Simple example
            /// BV ID="Confirmat" SIDE=0 CRN="1,2,4,3" X=9 Y=50 Z=0 DP=5 DIA=7 THR=YES TTP=1
            /// CUT_X SIDE=0 CRN="1" X=0 Y=LPY-20 Z=0 DP=8 L=LPX TNM="LAMA120" CRC=2
            /// BV ID="AventosHF" SIDE=0 CRN="1" X=0.3*LPX-57 Y=37 Z=0 DP=13 DIA=5 RTY=rpY DX=0 DY=192 R=0 DA=0 NRP=2
            /// BV ID="Shelf" SIDE=0 CRN="1" X=LPX/2+11 Y=70 Z=0 DP=13 DIA=5 RTY=rpY DX=0 DY=LPY-2*70 R=0 DA=0 NRP=2
            /// ROUT ID="Milling" SIDE=0 CRN="2" Z=0 DP=5 DIA=12 THR=YES DIN=20 DOU=20
            ///     START_POINT X=18 Y=0
            ///     LINC_EP XI=0 YI=10
            ///     LINC_EP XI=100 YI=0
            ///     LINC_EP XI=0 YI=-10
            ///     ENDPATH
            /// GEO ID="PVC" SIDE=0 CRN="1" DP=0
            ///     START_POINT X=0 Y=-10
            ///     LINE_EP XE=LPX YE=-10
            ///     START_POINT X=-10 Y=0
            ///     LINE_EP XE=-10 YE=LPY
            ///     START_POINT X=LPX+10 Y=0
            ///     LINE_EP XE=LPX+10 YE=LPY
            ///     ENDPATH
            /// GEOTEXT ID="PVC" SIDE=0 CRN="2" TXT="PVC 0.6 mm" X=LPX/2 Y=LPY+25 Z=0 ANG=0 VRS=0 ALN=0 ACC=0 FNT="Arial" SZE=32
            /// GEOTEXT ID="PVC_Left" SIDE=0 CRN="2" TXT="PVC 0.6 mm" X=-35 Y=LPY/2 Z=0 ANG=90 VRS=0 ALN=0 ACC=0 FNT="Arial" SZE=32
            /// GEOTEXT ID="PVC_Right" SIDE=0 CRN="2" TXT="PVC 0.6 mm" X=LPX+35 Y=LPY/2 Z=0 ANG=270 VRS=0 ALN=0 ACC=0 FNT="Arial" SZE=32
            var pg = new BiesseProgram();
            pg.Lpx = 800;
            pg.Lpy = 320;
            pg.Lpz = 18;
            pg.Origins = "5,8";
            pg.Operations.Add(new Bv{Id="Confirmat", Side=0, Crn="1,2,4,3", X=9, Y=50, Dp=5, Dia=7, Thr=true, Ttp=1});
            pg.Operations.Add(new Bv{Id="AventosHF", Side=0, Crn="1", X=0.3*pg.Lpx-57, Y=37, Dp=13, Dia=5, Rty=Repetition.rpY, Dx=0, Dy=192, R=0, Da=0, Nrp=2});
            pg.Operations.Add(new Bv{Id="Shelf", Side=0, Crn="1", X=pg.Lpx/2 + 11, Y=70, Z=0, Dp=13, Dia=5, Rty=Repetition.rpY, Dx=0, Dy=pg.Lpy-2*70, R=0, Da=0, Nrp=2});
            pg.Operations.Add(new CutX{Side=0, Crn="1", X=0, Y=pg.Lpy-20, Z=0, Dp=8, L=pg.Lpx, Tnm="LAMA120", Crc=ToolCorrection.Left});
            pg.Operations.Add(new Rout{ Id="Milling", Side=0, Crn="2", Z=0, Dp=5, Dia=12, Thr=true, Din=20, Dou=20});
            pg.Operations.Add(new StartPoint{X=18, Y=0});
            pg.Operations.Add(new LincEp{Xi=0, Yi=10});
            pg.Operations.Add(new LincEp{Xi=100, Yi=0});
            pg.Operations.Add(new LincEp{Xi=0, Yi=-10});
            pg.Operations.Add(new EndPath());
            pg.Operations.Add(new Geo{Id="PVC", Side=0, Crn="1", Dp=0});
            pg.Operations.Add(new StartPoint{X=0, Y=-10});
            pg.Operations.Add(new LineEp{Xe=pg.Lpx, Ye=-10});
            pg.Operations.Add(new StartPoint{X=-10, Y=0});
            pg.Operations.Add(new LineEp{Xe=-10, Ye=pg.Lpy});
            pg.Operations.Add(new StartPoint{X=pg.Lpx + 10, Y=0});
            pg.Operations.Add(new LineEp{Xe=pg.Lpx + 10, Ye=pg.Lpy});
            pg.Operations.Add(new EndPath());
            pg.Operations.Add(new GeoText{Id="PVC", Side=0, Crn="2", Txt="PVC 0.6 mm", X=pg.Lpx/2, Y=pg.Lpy+25,  Ang=0, Fnt="Arial", Sze=32});
            pg.Operations.Add(new GeoText{Id="PVC_Left", Side=0, Crn="2", Txt="PVC 0.6 mm", X=-35, Y=pg.Lpy/2, Ang=90, Fnt="Arial", Sze=32});
            pg.Operations.Add(new GeoText{Id="PVC_Right", Side=0, Crn="2", Txt="PVC 0.6 mm", X=pg.Lpx + 35, Y=pg.Lpy/2, Ang=270, Fnt="Arial", Sze=32});
            string dir=@"C:\WNC\home\d_xnc\p_p\prog\TestPrg";
            /// write file as .bpp
            string fileName = dir +"\\" + "SimpleExample.bpp";
            File.WriteAllText(fileName, pg.AsBppCode());
            /// write file as .cix
            fileName = dir +"\\" + "SimpleExample.cix";
            File.WriteAllText(fileName, pg.AsCixCode());


            /// Uses <c>WallCabinet</c> class for generation 3 "bpp" files;
            WallCabinet wallCabinet = new WallCabinet() ;
            wallCabinet.saveBppPrg(dir);

            ///------------------------------------------------------------------------------------------
            /// Boring 
            ///------------------------------------------------------------------------------------------
            var prg = new BiesseProgram();
            prg.Lpx = 800;
            prg.Lpy = 320;
            prg.Lpz = 18;
            prg.Origins = "5,8";
            /// Uses extension method <c>MiniFixOperation</c> of <c>CustomOperations</c> class for generation machining operation.
            prg.MiniFixOperation(2, 37);
            /// write file as .bpp
            fileName = dir +"\\" + "Minifx800x320.bpp";
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
            /// Uses extension method <c>MillingOperation</c> of <c>CustomOperations</c> class for generation milling operation.
            millPrg.MillingOperation();
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
            /// Uses extension method <c>KitchenDoorOperation</c> of <c>CustomOperations</c> class for generation milling operations.
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
