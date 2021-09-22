using System;

namespace BppLib.CIDFile
{
    public interface IBlock
    {
        /// <summary>This method serializes an object as Cid block.</summary>
		/// <returns>A string  is coded as Cid block.</returns>
        string AsCidBlock();

        /// <summary>This method serializes an object as Cid code.</summary>
		/// <returns>A string  is coded as Cid code.</returns>
        string AsCidCode();
    }
}