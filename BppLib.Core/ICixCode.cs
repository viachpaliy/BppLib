using System;

namespace BppLib.Core
{
    /// <summary> Interface for all entities of Biesse .cix programs.</summary>
    public interface ICixCode
    {
        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
        string AsCixCode();
    }
}