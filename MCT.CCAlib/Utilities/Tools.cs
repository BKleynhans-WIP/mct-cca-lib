using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

using MCT.CCAlib.Interfaces;

namespace MCT.CCAlib.Utilities
{
    public class Tools : ITools
    {
        private readonly ILogger<Tools> _logger;

        public Tools(ILogger<Tools> logger)
        {
            _logger = logger;
        }

        /// <summary>
		/// Indicates whether specified list is null or empty
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection"></param>
		/// <returns></returns>
		public bool ListIsNullOrEmpty<T>(List<T> collection)
        {
            return collection == null || collection.Count <= 0;
        }

        /// <summary>
        /// Takes in the name of a variable and the value of the variable to try and convert it 
        /// from a string to an int.  If it is unable to convert it to an int, an exception is
        /// thrown.
        /// </summary>
        /// <param name="variableName">The name of the variable you are passing in used for logging</param>
        /// <param name="value">The value contained int he variable specified in the variableName field</param>
        /// <returns></returns>
        public int IntTryParseWithException(string variableName, string value)
        {
            try
            {
                bool success = int.TryParse(value, out int intValue);

                if (!success)
                {
                    throw new Exception($"The supplied {variableName} could not be parsed to INT : {value}");
                }
                else
                {
                    return intValue;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
