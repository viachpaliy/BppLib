using System;
using Fusion360PostProcessor;

namespace Fu360PostProcessorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Fu360PostProcessor("haas.cps");
           obj.OutPutMethod = delegate(string cncCode){Console.WriteLine(cncCode);};
           obj.JsErrorMethod = delegate(string text){Console.WriteLine("Post processor error : {0}",text);};
           
           obj.SetProgramName(128);
           obj.SetProgramComment("This is example of program");
           obj.SetHighFeedrate(3000);
           obj.AddTool(1,16);
           obj.Open();
           obj.Comment("this is my comment");
          
        }
    }
}
