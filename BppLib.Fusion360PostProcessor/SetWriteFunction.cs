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
        public event WritelnHandler OutPutMethod = delegate{};
       
        public void OutPut(string cncCode)
        {
            OutPutMethod?.Invoke(cncCode);
        }

        public void SetWriteFunction()
        {
            engine.SetGlobalFunction("writeln", new Action<string>((a) => this.OutPut(a)));
            SetFormatWords();
            SetWriteWords();
            SetWriteWords2();
        }

        public void SetFormatWords(){
            engine.Evaluate(@"function formatWords(arguments){
                var result = """";
                var args = Array.prototype.slice.call(arguments, 1);
                result += args.join("""");
                return result;}");
        }

        public void SetWriteWords(){
            engine.Evaluate(@"function writeWords(arguments){
                var result = """";
                var args = Array.prototype.slice.call(arguments, 1);
                result += args.join("""");
                writeln(result);}");
        }

        public void SetWriteWords2(){
            engine.Evaluate(@"function writeWords2(arguments){
                var result = """";
                var args = Array.prototype.slice.call(arguments, 1);
                result += args.join("""");
                writeln(result);}");
        }


    }
}