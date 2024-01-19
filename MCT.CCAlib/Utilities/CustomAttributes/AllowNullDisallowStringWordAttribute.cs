using System;
using System.ComponentModel.DataAnnotations;

namespace MCT.CCAlib.Utilities.CustomAttributes
{
    public class AllowNullDisallowStringWordAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null) return true;

            return !value.ToString().Equals("string", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
