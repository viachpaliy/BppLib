using System;
using BppLib.Core;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BppLib.BppParser
{
    public static partial class ParserBpp
    {
        public static string[] SplitColon(string code)
        {
            string[] arr = new string[2];
            bool isQuoteOpen = false;
            for(int i = 0 ; i < code.Length ; i++)
            {
                if (code[i] == '"') 
                    {isQuoteOpen = !isQuoteOpen ;}
                if ((code[i] == ':') & (!isQuoteOpen))
                {
                    arr[0] = code.Substring(0, i);
                    arr[1] = code.Substring(i + 1);
                    break;
                }
            }
            return arr;
        }

        public static string[] SplitComma(string code)
        {
            List<string> lst = new List<string>();
            int startPos = 0;
            
            bool isQuoteOpen = false;
            for(int i = 0 ; i < code.Length ; i++)
            {
                if (code[i] == '"') 
                    {isQuoteOpen = !isQuoteOpen ;} 
                if ((code[i] == ',') & (!isQuoteOpen))
                {
                    int stringLength = i - startPos ; 
                    lst.Add(code.Substring(startPos, stringLength));
                    startPos = i + 1;
                }
            }

            if (startPos < code.Length)
                    {lst.Add(code.Substring(startPos));}

            return lst.ToArray();
        }

    }
    
}
