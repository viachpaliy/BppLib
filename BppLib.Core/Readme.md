# BppLib.Core
### The main purpose of this library is to create tools for generating "bpp" and "cix" files for Biesse CNC.

[![Nuget](https://img.shields.io/nuget/v/BppLib.Core)](https://www.nuget.org/packages/BppLib.Core)
![Nuget](https://img.shields.io/nuget/dt/BppLib.Core)


### The `BiesseProgram` class models both ".bpp" and "cix" files :
 - the `AsBppCode` method returns the string as a "bpp" program.
 - the `AsCixCode` method returns the string as a "cix" program.

### The `BiesseProgram` class is divided into sections like the "bpp" program.

### The section `MainData` includes "piece variables" such as: 
 - Lpx - the piece width (X dimension of the piece);
 - Lpy - the piece height (Y dimension of the piece);
 - Lpz - the thickness of the piece;
 - and many others.

### The section `ProgramSec` models the program section of "bpp" programme and includes objects that model BiesseWorks instructions:
- class `Geo` models the geometry definition.
- class `GeoText` models the text geometry.
- class `OffGeo` models the geometry offset.

### The following classes model boring operations :
- class `Bca` models the bore with C axis on circular side operation.
- class `Bcl` models the bore with C axis on straigh side operation.
- class `Bg` models the generic boring operation.
- class `BGeo` models the bore from geometry operation.
- class `Bh` models the boring operation using the horizontal spindle.
- class `Bv` models the boring operation using the vertical spindle.
- class `S32` models the repeated boring operation.

### The following classes model cutting operations :
- class `CutF` models the squaring operation centred on the top or bottom side of the piece.
- class `CutFR` models the squaring operation that is not centred on the top or bottom side of the piece.
- class `CutG` models the generic cutting operation.
- class `CutGeo` models the cut from geometry.
- class `CutX` models the cut along the X-axis.
- class `CutY` models the cut along the Y-axis.

### The following classes model milling operations :
- class `Rout` models the milling operation using an “integrated” geometric profile.
- class `RoutG` models the milling operation with “generic” geometric profile.
- class `Pock` models the geometric profile pocketing.

### The following classes are used to create lines in a geometric profile:
- class `Chamfer` models the chamfer.
- class `LincEp` models the incremental line given end point(i.e. "LINC_EP").
- class `LineAnXe` models the line given angle and final X(i.e. "LINE_ANXE").
- class `LineAnYe` models the line given angle and final Y(i.e. "LINE_ANYE").
- class `LineEp` models the line given end point(i.e. "LINE_EP").
- class `LineEpAnTp` models the line given end point angle and tangency to previous item(i.e. "LINE_EPANTP").
- class `LineEpTp` models the line given end point and tangency to previous item(i.e. "LINE_EPTP").
- class `LineLnAn` models the line given length and angle(i.e. "LINE_LNAN").
- class `LineLnTp` models the line given length and tangency to previous item(i.e "LINE_LNTP").
- class `LineLnXe` models the line given length and final X(i.e "LINE_LNXE").
- class `LineLnYe` models the line given length and final Y(i.e "LINE_LNYE").

### The following classes are used to create arcs in a geometric profile:
- class `AincAnCe` models the incremental curve given angle and centre point(i.e. "AINC_ANCE").
- class `AincEpRa` models the incremental curve given radius and end point(i.e. "AINC_EPRA").
- class `ArcAnCe` models the curve given angle and centre(i.e. "ARC_ANCE").
- class `ArcAnCeRaTp` models the curve given angle centre radius and tangency to previous item(i.e. "ARC_ANCERATP").
- class `ArcCeTs` models the curve given centre and tangency to next element with previous point determined(i.e "ARC_CETS").
- class `ArcCeTsPk` models the curve given centre and tangency to next element with previous point not determined(i.e. "ARC_CETSPK").
- class `ArcEpCe` models the curve given end point and centre(i.e. "ARC_EPCE").
- class `ArcEpRa` models the curve given end point and radius(i.e "ARC_EPRA").
- class `ArcEpRaTp` models the curve given end point and radius and tangency to previous item(i.e. "ARC_EPRATP").
- class `ArcEpTp` models the curve given end point and tangency to previous item(i.e. "ARC_EPTP").
- class `ArcIpEp` models the curve using three points(i.e. "ARC_IPEP").
- class `ArcRaTs` models the curve given radius and tangency to next element with previous point determined(i.e. "ARC_RATS").
- class `ArcRaTsPk` models the curve given radius and tangency to next element with previous point not determined(i.e. "ARC_RATSPK").
- class `ConnectorA` models the connection radius between the selected element and the preceding one (of type A)(i.e. "CONNECTOR"). 
- class `ConnectorB` models the connection radius that can be used to machine door and window frames (of type B)(i.e. "CONNECTOR2").

### The following classes are used to create figures in a geometric profile:
- class `Circle3P` models the circle given three points(i.e. "CIRCLE_3P").
- class `CircleCR` models the circle given centre and radius(i.e. "CIRCLE_CR").
- class `Ellipse` models the ellipse.
- class `Oval` models the oval.
- class `Polygon` models the polygon.
- class `Rectangle` models the rectangle.
- class `Star` models the star.

Class `StartPoint` models the starting point.
Class `EndPath` models the end of the machining operation.

### In version 1.1 the following classes are added :
- class `WFC` models ircular side. 
- class `WFG` models sides from geometry.
- class `WFGL` models side from geometry on side faces.
- class `WFGPS` models side from geometry using section plan.
- class `WFL` models straight side.

Most classes only have a default constructor.

### Simple example :
```C#
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
        }
    }
}
```

### This code is equivalent to the following BiesseWorks script:
```VB
BV ID="Confirmat" SIDE=0 CRN="1,2,4,3" X=9 Y=50 Z=0 DP=5 DIA=7 THR=YES TTP=1
CUT_X SIDE=0 CRN="1" X=0 Y=LPY-20 Z=0 DP=8 L=LPX TNM="LAMA120" CRC=2
BV ID="AventosHF" SIDE=0 CRN="1" X=0.3*LPX-57 Y=37 Z=0 DP=13 DIA=5 RTY=rpY DX=0 DY=192 R=0 DA=0 NRP=2
BV ID="Shelf" SIDE=0 CRN="1" X=LPX/2+11 Y=70 Z=0 DP=13 DIA=5 RTY=rpY DX=0 DY=LPY-2*70 R=0 DA=0 NRP=2
ROUT ID="P1021" SIDE=0 CRN="2" Z=0 DP=5 DIA=12 THR=YES DIN=20 DOU=20
  START_POINT X=18 Y=0
  LINC_EP XI=0 YI=10
  LINC_EP XI=100 YI=0
  LINC_EP XI=0 YI=-10
  ENDPATH

GEO ID="PVC" SIDE=0 CRN="1" DP=0
  START_POINT X=0 Y=-10
  LINE_EP XE=LPX YE=-10
  START_POINT X=-10 Y=0
  LINE_EP XE=-10 YE=LPY
  START_POINT X=LPX+10 Y=0
  LINE_EP XE=LPX+10 YE=LPY
  ENDPATH
GEOTEXT ID="PVC" SIDE=0 CRN="2" TXT="PVC 0.6 mm" X=LPX/2 Y=LPY+25 Z=0 ANG=0 VRS=0 ALN=0 ACC=0 FNT="Arial" SZE=32
GEOTEXT ID="PVC_2" SIDE=0 CRN="2" TXT="PVC 0.6 mm" X=-35 Y=LPY/2 Z=0 ANG=90 VRS=0 ALN=0 ACC=0 FNT="Arial" SZE=32
GEOTEXT ID="PVC_2_2" SIDE=0 CRN="2" TXT="PVC 0.6 mm" X=LPX+35 Y=LPY/2 Z=0 ANG=270 VRS=0 ALN=0 ACC=0 FNT="Arial" SZE=32
```