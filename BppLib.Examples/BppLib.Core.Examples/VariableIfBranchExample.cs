using System;
using BppLib.Core;
using System.Collections.Generic;
using System.IO;

namespace BppLib.Core.Examples
{
    ///<summary> Example of use variable and "if" statement </summary>

    /// GEO ID="BaseContour" SIDE=0 CRN="1" DP=0
    /// If TYP=0 Then
    ///     START_POINT X=LPX/2 Y=L
    ///     LINE_EP XE=LPX-L-dL YE=L SC=sc1
    ///     ARC_IPEP X2=LPX-L Y2=LPY/2 XE=LPX-L-dL YE=LPY-L SC=sc1
    ///     LINE_EP XE=L+dL YE=LPY-L SC=sc1
    ///     ARC_IPEP X2=L Y2=LPY/2 XE=L+dL YE=L SC=sc1
    ///     LINE_EP XE=LPX/2 YE=L
    /// Else
    ///     START_POINT X=L Y=LPY/2
    ///     LINE_EP XE=L YE=L+dL SC=sc1
    ///     ARC_IPEP X2=LPX/2 Y2=L XE=LPX-L YE=L+dL SC=sc1
    ///     LINE_EP XE=LPX-L YE=LPY-L-dL SC=sc1
    ///     ARC_IPEP X2=LPX/2 Y2=LPY-L XE=L YE=LPY-L-dL SC=sc1
    ///     LINE_EP XE=L YE=LPY/2
    /// End If
    /// ENDPATH
    /// OFFGEO ID="InnerContour" GID="BaseContour" OFS=-16 SHC=YES OSL=oslTan LTP=NO RV=NO CRT=1
    /// ROUTG ID="D16" GID="BaseContour" Z=0 DP=8 DIA=16 TIN=0 AIN=0 TOU=0 AOU=0
    /// ROUTG ID="Angel45" GID="BaseContour" Z=0 DP=8 DIA=0.1 TNM="V-BIT90" CRC=0 TIN=0 AIN=0 TOU=0 AOU=0 SC=YES
    /// ROUTG ID="Angel45Inner" GID="InnerContour" Z=0 DP=8 DIA=0.1 TNM="V-BIT90" CRC=0 TIN=0 AIN=0 TOU=0 AOU=0
    
    /// <summary>Class <c>CustomOperations</c> models the custom machining operations.</summary>
    public static partial class CustomOperations
    {
        public static void KitchenDoorOperation(this BiesseProgram prg, double L, double dL)
        {
            prg.PublicVars.PublicVariables.Add(new BiesseVariable{Name = "TYP", Value = "1", Description = "0_horizontal 1_vertical"});
            prg.Operations.Add(new Geo{Id = "BaseContour", Side = 0, Crn = "1"});
            prg.Operations.Add(new VBLine("If TYP=0 Then"));
            prg.Operations.Add(new StartPoint{X = prg.Lpx / 2, Y = L});
            prg.Operations.Add(new LineEp{Xe = (prg.Lpx  - L - dL), Ye = L, Sc = SharpCorner.sc1});
            prg.Operations.Add(new ArcIpEp{X2 = prg.Lpx - L, Y2 = prg.Lpy / 2, Xe = (prg.Lpx - L - dL), Ye = prg.Lpy - L, Sc = SharpCorner.sc1});
            prg.Operations.Add(new LineEp{Xe = L + dL, Ye = prg.Lpy - L, Sc = SharpCorner.sc1});
            prg.Operations.Add(new ArcIpEp{X2 = L, Y2 = prg.Lpy / 2, Xe = L + dL, Ye = L, Sc = SharpCorner.sc1});
            prg.Operations.Add(new LineEp{Xe = prg.Lpx / 2, Ye = L});
            prg.Operations.Add(new VBLine("Else"));
            prg.Operations.Add(new StartPoint{Y = prg.Lpy / 2, X = L});
            prg.Operations.Add(new LineEp{Xe = L, Ye = L + dL, Sc = SharpCorner.sc1});
            prg.Operations.Add(new ArcIpEp{X2 = prg.Lpx / 2, Y2 = L, Xe = prg.Lpx - L, Ye = L + dL, Sc = SharpCorner.sc1});
            prg.Operations.Add(new LineEp{Xe = prg.Lpx - L, Ye = prg.Lpy - L - dL, Sc = SharpCorner.sc1});
            prg.Operations.Add(new ArcIpEp{X2 = prg.Lpx / 2, Y2 = prg.Lpy - L, Xe = L, Ye = prg.Lpy - L - dL, Sc = SharpCorner.sc1});
            prg.Operations.Add(new LineEp{Xe = L, Ye = prg.Lpy / 2});
            prg.Operations.Add(new VBLine("End If"));
            prg.Operations.Add(new EndPath());
            prg.Operations.Add(new OffGeo{Id = "InnerContour", Gid = "BaseContour", Ofs = -16, Shc = true});
            prg.Operations.Add(new RoutG{Id = "D16", Gid = "BaseContour", Z = 0, Dp = 8, Dia = 16, Tin = 0, Ain = 0, Tou = 0, Aou = 0});
            prg.Operations.Add(new RoutG{Id = "Angel45", Gid = "BaseContour", Z = 0, Dp = 8, Dia = 0.1, Tnm="V-BIT90", Crc = ToolCorrection.Central, Tin = 0, Ain = 0, Tou = 0, Aou = 0, Sc = true});
            prg.Operations.Add(new RoutG{Id = "Angel45Inner", Gid = "InnerContour", Z = 0, Dp = 8, Dia = 0.1, Tnm="V-BIT90", Crc = ToolCorrection.Central, Tin = 0, Ain = 0, Tou = 0, Aou = 0});
        }
    }
}