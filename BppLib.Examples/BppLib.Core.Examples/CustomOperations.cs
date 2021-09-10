using System;
using BppLib.Core;
using System.Collections.Generic;
using System.IO;

namespace BppLib.Core.Examples
{
    /// <summary>Class <c>CustomOperations</c> models the custom machining operations.</summary>
    public static partial class CustomOperations 
    {
        public static void MiniFixOperation(this BiesseProgram prg, int side, double Xshift)
        {
            prg.Operations.Add(new Bh{Id = "8x30", Side = side, Crn = "1,4", X = Xshift, Dp = 30, Dia = 8, Md = true});
            prg.Operations.Add(new Bh{Id = "8x22", Side = side, Crn = "1,4", X = Xshift + 32, Dp = 22, Dia = 8, Md = true});
            string corners = "";
            switch(side)
            {
                case 1 :
                  corners = "1,2";
                  prg.Operations.Add(new Bv{Id="D15x13", Side=0, Crn= corners , X = 34, Y = Xshift, Dp=13.5, Dia=15});
                  break;
                case 2 :
                  corners = "2,3";
                  prg.Operations.Add(new Bv{Id="D15x13", Side=0, Crn= corners , X = Xshift, Y = 34, Dp=13.5, Dia=15});
                  break;
                case 3 :
                  corners = "4,3";
                  prg.Operations.Add(new Bv{Id="D15x13", Side=0, Crn= corners , X = 34, Y = Xshift, Dp=13.5, Dia=15});
                  break;
                case 4 :
                  corners = "1,4";
                  prg.Operations.Add(new Bv{Id="D15x13", Side=0, Crn= corners , X = Xshift, Y = 34, Dp=13.5, Dia=15});
                  break;
                default :
                  corners = "1,2";
                  prg.Operations.Add(new Bv{Id="D15x13", Side=0, Crn= corners , X = 34, Y = Xshift, Dp=13.5, Dia=15});
                  break;
            }
        }
      
    }
}