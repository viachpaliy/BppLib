using System;
using BppLib.Core;
using System.Collections.Generic;

namespace BppLib.Core.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            WallCabinet wallCabinet = new WallCabinet() ;
            wallCabinet.saveBppPrg();
        }
    }
}
