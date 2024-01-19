using System.ComponentModel.DataAnnotations;

namespace MCT.CCAlib.Utilities.CustomAttributes
{
    public class NotZeroAttribute : ValidationAttribute
    {
        public override bool IsValid(object value) => (int)value != 0;
    }
}
