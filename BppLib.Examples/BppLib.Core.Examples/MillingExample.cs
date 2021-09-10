using System;
using BppLib.Core;
using System.Collections.Generic;
using System.IO;

namespace BppLib.Core.Examples
{
    /// <summary>Class <c>CustomOperations</c> models the custom machining operations.</summary>
    public static partial class CustomOperations 
    {
        /// ROUT SIDE=0 CRN=”1” Z=0 DP=10 DIA=18 ER=NO
        ///   START_POINT X=120 Y=264.2061763 
        ///   LINE_EP XE=120 YE=410.208482 
        ///   LINE_EP XE=584 YE=410.208482 
        ///   LINE_EP XE=584 YE=360.208482 
        ///   ARC_EPCE XE=602.1490579 YE=336.9771299 XC=607.9429514 YC=360.208482 DIR=dirCW 
        ///   ARC_EPCE XE=602.1490579 YE=191.4352226 XC=584 YC=264.2061763 DIR=dirCCW 
        ///   ARC_EPCE XE=584 YE=168.2038705 XC=607.9429514 YC=168.2038705 DIR=dirCW 
        ///   LINE_EP XE=584 YE=118.2038705 
        ///   LINE_EP XE=120 YE=118.2038705 
        ///   LINE_EP XE=120 YE=264.2061763 
        ///   ENDPATH

        public static void MillingOperation(this BiesseProgram prg)
        {
            prg.Operations.Add(new Rout{ Side=0, Crn="1", Z=0, Dp=10, Dia=18, Er=false});
            prg.Operations.Add(new StartPoint{X=120, Y=264.2061763});
            prg.Operations.Add(new LineEp{Xe=120, Ye=410.208482});
            prg.Operations.Add(new LineEp{Xe=584, Ye=410.208482});
            prg.Operations.Add(new LineEp{Xe=584, Ye=360.208482});
            prg.Operations.Add(new ArcEpCe{Xe=602.1490579, Ye=336.9771299, Xc=607.9429514, Yc=360.208482, Dir=CircleDirection.dirCW});
            prg.Operations.Add(new ArcEpCe{Xe=602.1490579, Ye=191.4352226, Xc=584, Yc=264.2061763, Dir=CircleDirection.dirCCW});
            prg.Operations.Add(new ArcEpCe{Xe=584, Ye=168.2038705, Xc=607.9429514, Yc=168.2038705, Dir=CircleDirection.dirCW});
            prg.Operations.Add(new LineEp{Xe=584, Ye=118.2038705});
            prg.Operations.Add(new LineEp{Xe=120, Ye=118.2038705});
            prg.Operations.Add(new LineEp{Xe=120, Ye=264.2061763});
            prg.Operations.Add(new EndPath());
        }

    }
}