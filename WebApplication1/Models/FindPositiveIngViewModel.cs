using ZadaniaRekrutacyjne.Utility;

namespace ZadaniaRekrutacyjne.Models
{
    public class FindPositiveIngViewModel
    {
        [IfNumberSplitedString]
        public string? numbersToCheck { get; set; }
    }
}
