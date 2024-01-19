using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCT.CCAlib
{
    public static class StaticDetails // Static Details
    {
        public enum ApiType
        {
            GET,
            POST, 
            PUT, 
            DELETE
        }

        public enum API
        {
            AmpiAPI,
            ManagedCareAPI
        }
    }
}
