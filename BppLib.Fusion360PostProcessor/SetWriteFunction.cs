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
            SetFormatWords();
            SetWriteWords();
            SetWriteWords2();
            SetGetAsInt();
            SetConditional();
        }

        public void SetFormatWords(){
            engine.Evaluate(@"function formatWords(arguments){
                var result = """";
                var args = Array.prototype.slice.call(arguments, 1);
                result += args.join("""");
                return result;}");
        }

        public void SetWriteWords(){
            engine.Evaluate(@"function writeWords(a0, a1 = """", a2 = """", a3 = """", a4 = """", a5 = """", a6 = """", a7 = """", a8 = """", a9 = """", a10 = """", a11 = """"){
                 var args = [a0, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11];
                 writeln(args.join(''));}");
        }

        public void SetWriteWords2(){
             engine.Evaluate(@"function writeWords2(a0, a1 = """", a2 = """", a3 = """", a4 = """", a5 = """", a6 = """", a7 = """", a8 = """", a9 = """", a10 = """", a11 = """"){
                 var args = [a0, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11];
                 writeln(args.join(''));}");
        }

        public void SetGetAsInt(){
            engine.Evaluate(@"function getAsInt(value){return Number(value);}");
        }

        public void SetConditional(){
            engine.Evaluate(@"function conditional(a0, a1 = """", a2 = """", a3 = """", a4 = """", a5 = """", a6 = """", a7 = """", a8 = """", a9 = """", a10 = """", a11 = """"){
                 var args = [a0, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11];
                 return(args.join(''));}");
        }

    }
}