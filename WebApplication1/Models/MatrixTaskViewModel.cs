using System.ComponentModel.DataAnnotations;
using WebApplication1.Utility;
using ZadaniaRekrutacyjne.Utility;

namespace ZadaniaRekrutacyjne.Models
{
    public class MatrixTaskViewModel
    {
        [IfNumberSplitedString]
        public string MatrixString { get; set; }
    }
}
