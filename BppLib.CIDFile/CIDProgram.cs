using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;

namespace BppLib.CIDFile
{
    ///<summary>Class <c>CIDProgram</c> represents the CID program.</summary>
    public class CIDProgram
    {
        protected FileId _header = new FileId();

        protected MainData _mainData = new MainData();

        ///<value> Property <c>FileName</c> represents the name of the CID program.</value>
        public string FileName
        {
             get{
                 return _header.FileName;
             }

             set{
                _header.FileName = value;
             }
        }

        /// <value>Property <c>Lx</c> represents the piece width (X dimension of the piece).</value>
        public double Lx
        {
            get{
                return _mainData.Lx;
            }

            set{
                _mainData.Lx = value;
            }
        }

        /// <value>Property <c>Ly</c> represents the piece height (Y dimension of the piece).</value>
        public double Ly
        {
            get{
                return _mainData.Ly;
            }

            set{
                _mainData.Ly = value;
            }
        }

        /// <value>Property <c>Lz</c> represents the thickness of the piece.</value>
        public double Lz
        {
            get{
                return _mainData.Lz;
            }

            set{
                _mainData.Lz = value;
            }
        }

        public List<IBlock> Operations = new List<IBlock>();

        /// <summary>This method serializes an object as Cid code.</summary>
		/// <returns>A string  is coded as Cid code.</returns>
        public string AsCidCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(_header.AsCidCode());
            sb.Append(_mainData.AsCidCode());
            foreach(var item in Operations)
            {
                sb.Append("\r\n" + item.AsCidBlock());
            }
            return sb.ToString();
        }    
    }
}