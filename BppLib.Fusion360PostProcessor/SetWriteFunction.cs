using System;
using Jurassic;
using System.Globalization;
using System.Text;

namespace Fusion360PostProcessor
{
    /// <summary> Class <c>Fu360PostProcessor</c> models post processor for the Fusion 360.</summary>
    public partial class Fu360PostProcessor
    {
        public delegate void WritelnHandler(string cncCode);
        public WritelnHandler OutPutMethod = delegate{};
        public WritelnHandler JsErrorMethod = delegate{};
        public delegate string JsLocalize(string text);
        public JsLocalize JsLocalizeMethod = delegate(string text){return text;};
             

        public void SetWriteFunction()
        {
            engine.SetGlobalFunction("writeln", new Action<string>((a) => this.OutPutMethod(a)));
            engine.SetGlobalFunction("error", new Action<string>((a) => this.JsErrorMethod(a)));
            engine.SetGlobalFunction("localize", new Func<string,string>((a) => this.JsLocalizeMethod(a)));
        }
      

    }
}