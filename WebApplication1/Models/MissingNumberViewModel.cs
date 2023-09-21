using System.ComponentModel.DataAnnotations;
using WebApplication1.Utility;

namespace WebApplication1.Models
{
    public class MissingNumberViewModel
    {
        [IfStringIsNumber]
        public string MissingNumber { get; set; }
    }
}
