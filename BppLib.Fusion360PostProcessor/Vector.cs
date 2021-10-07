using System;
using Jurassic;
using System.Globalization;
using System.Text;

namespace Fusion360PostProcessor
{
    /// <summary> Class <c>Fu360PostProcessor</c> models post processor for the Fusion 360.</summary>
    public partial class Fu360PostProcessor
    {
        public void SetVector()
        {
            engine.Evaluate(@"function Vector(x = 0, y = 0, z = 0){
                return {
                    x : x,
                    y : y,
                    z : z
                };
            }");
        }

        
    }
}