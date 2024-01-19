using System.Collections.Generic;

namespace MCT.CCAlib.Interfaces
{
    public interface ITools
    {
        bool ListIsNullOrEmpty<T>(List<T> collection);
        int IntTryParseWithException(string variableName, string value);
    }
}