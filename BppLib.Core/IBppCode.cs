using System;

namespace BppLib.Core
{
    /// <summary> Interface for all entities of Biesse .bpp programs.</summary>
    public interface IBppCode : ICixCode
    {
        /// <summary>This method serializes an object as Bpp code.</summary>
		/// <returns>A string  is coded as Bpp code.</returns>
        string AsBppCode();
        
    }
}