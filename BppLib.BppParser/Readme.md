# BppLib.BppParser

    A Nuget Package is available.
[![Nuget](https://img.shields.io/nuget/v/BppLib.BppParser)](https://www.nuget.org/packages/BppLib.BppParser)
![Nuget](https://img.shields.io/nuget/dt/BppLib.BppParser)

## Parser for "bpp" files for Biesse CNC.

The library will read "bpp" code and produce a [`BppLib.Core`](https://www.nuget.org/packages/BppLib.Core) objects from it.

The library consists of one static class `ParserBpp` that contains many static methods for parsing.

`ParserBpp.ParseBppFile` method reads "bpp" file and produces a `BppLib.Core.BiesseProgram` from it.

`ParserBpp.ParseBiesseProgram` method parses a array of strings and returns a `BppLib.Core.BiesseProgram` from it.

`ParserBpp.ParseHeaderSection` method parses a array of strings and returns a `BppLib.Core.HeaderSection` from it.

`ParserBpp.ParseDescriptionSection` method parses a array of strings and returns a `BppLib.Core.DescriptionSection` from it.

`ParserBpp.ParseMainDataSection` method parses a array of strings and returns a `BppLib.Core.MainDataSection` from it.

`ParserBpp.ParsePublicVarsSection` method parses a array of strings and returns a `BppLib.Core.PublicVarsSection` from it.

`ParserBpp.ParsePrivateVarsSection` method parses a array of strings and returns a `BppLib.Core.PrivateVarsSection` from it.

`ParserBpp.ParseProgramSection`  method parses a array of strings and returns a `BppLib.Core.ProgramSection` from it.

`ParserBpp.ParseProgramSectionLine` method  parses any line of code from the program section of the "bpp"  file and returns `BppLib.IBppCode`.

For all the main classes of `BppLib.Core` , the library contains methods that parse a line of code and return an instance of that class (for example, `ParseStartPoint`, `ParseEndPath`, `ParseGeo`, etc.)

### Simple example :

This console program parses  "bpp" file , rotates the workpiece 90 degrees and  saves the "rotated" program to a new "bpp" file.

```csharp
using System;
using BppLib.BppParser;
using BppLib.Core;
using System.IO;

namespace Rotate90Deg
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
               Console.WriteLine("Please enter a name of the file");
            }
            else
            {
                string pathToFile = args[0];
                FileInfo fileInf = new FileInfo(pathToFile);
                if (!fileInf.Exists)
                {
                    Console.WriteLine("{0} - file does not exist", pathToFile);
                    return;
                }
                var prg = ParserBpp.ParseBppFile(pathToFile);
                double temp = prg.Lpx;
                prg.Lpx = prg.Lpy;
                prg.Lpy = temp;
                foreach(var entity in prg.Operations)
                {
                    if (typeof(Bg).IsInstanceOfType(entity))
                    {
                        Bg bore = (Bg)entity;
                        if (bore.Side == 0)
                        {
                            temp = bore.X;
                            bore.X = bore.Y;
                            bore.Y = temp;
                            switch (bore.Crn)
                            {
                                case "1" :
                                    bore.Crn = "2";
                                    break;
                                case "2" :
                                    bore.Crn = "3";
                                    break;
                                case "3" :
                                    bore.Crn = "4";
                                    break;
                                case "4" :
                                    bore.Crn = "1";
                                    break;
                                default :
                                    break;
                            }
                        }
                        else
                            {
                                bore.Side = (bore.Side + 1) % 4;
                            }
                        }
                    if (typeof(Geo).IsInstanceOfType(entity))
                    {
                        Geo geo = (Geo)entity;
                        if (geo.Side == 0)
                        {
                            switch (geo.Crn)
                            {
                                case "1" :
                                    geo.Crn = "2";
                                    break;
                                case "2" :
                                    geo.Crn = "3";
                                    break;
                                case "3" :
                                    geo.Crn = "4";
                                    break;
                                case "4" :
                                    geo.Crn = "1";
                                    break;
                                default :
                                    break;
                            }
                        }
                        else
                        {
                            geo.Side = (geo.Side + 1) % 4;
                        }
                    }
                    if (typeof(StartPoint).IsInstanceOfType(entity))
                    {
                        StartPoint st = (StartPoint)entity;
                        temp = st.X;
                        st.X = st.Y;
                        st.Y = temp;
                    }
                    if (typeof(LineEp).IsInstanceOfType(entity))
                    {
                        LineEp l = (LineEp)entity;
                        temp = l.Xe;
                        l.Xe = l.Ye;
                        l.Ye = temp;
                    }
                    if (typeof(ArcEpCe).IsInstanceOfType(entity))
                    {
                        ArcEpCe a = (ArcEpCe)entity;
                        temp = a.Xe;
                        a.Xe = a.Ye;
                        a.Ye = temp;
                        temp = a.Xc;
                        a.Xc = a.Yc;
                        a.Yc = temp;
                    }
                    if (typeof(GeoText).IsInstanceOfType(entity))
                    {
                        GeoText geo = (GeoText)entity;
                        if (geo.Side == 0)
                        {
                            switch (geo.Crn)
                            {
                                case "1" :
                                    geo.Crn = "2";
                                    break;
                                case "2" :
                                    geo.Crn = "3";
                                    break;
                                case "3" :
                                    geo.Crn = "4";
                                    break;
                                case "4" :
                                    geo.Crn = "1";
                                    break;
                                default :
                                    break;
                            }
                        }
                        else
                        {
                            geo.Side = (geo.Side + 1) % 4;
                        }
                        temp = geo.X;
                        geo.X = geo.Y;
                        geo.Y = temp;
                        geo.Ang = (geo.Ang + 90) % 360;
                    }
                }
                 

                
                Console.WriteLine(prg.AsBppCode());
                string newName = Path.GetDirectoryName(Path.GetFullPath(pathToFile)) + "\\" + Path.GetFileNameWithoutExtension(pathToFile) + "Rotate90Deg.bpp";
                Console.WriteLine("New name for file - {0}", newName);
                File.WriteAllText(newName, prg.AsBppCode());
            }
        }
    }
}
```
