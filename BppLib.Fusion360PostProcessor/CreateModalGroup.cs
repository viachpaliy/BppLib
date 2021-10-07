using System;
using Jurassic;
using System.Globalization;
using System.Text;

namespace Fusion360PostProcessor
{
    /// <summary> Class <c>Fu360PostProcessor</c> models post processor for the Fusion 360.</summary>
    public partial class Fu360PostProcessor
    {
       
        public void SetCreateModalGroup()
        {
            engine.Evaluate(@"function createModalGroup(specifiers){
                return {};
            }");
        }
    }
}