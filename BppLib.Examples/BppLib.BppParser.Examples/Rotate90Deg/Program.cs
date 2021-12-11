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
                    if (typeof(Rout).IsInstanceOfType(entity))
                    {
                        Rout rout = (Rout)entity;
                        if (rout.Side == 0)
                        {
                            switch (rout.Crn)
                            {
                                case "1" :
                                    rout.Crn = "2";
                                    break;
                                case "2" :
                                    rout.Crn = "3";
                                    break;
                                case "3" :
                                    rout.Crn = "4";
                                    break;
                                case "4" :
                                    rout.Crn = "1";
                                    break;
                                default :
                                    break;
                            }
                        }
                        else
                        {
                            rout.Side = (rout.Side + 1) % 4;
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
