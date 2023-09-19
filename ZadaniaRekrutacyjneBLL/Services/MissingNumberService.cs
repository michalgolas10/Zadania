using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadaniaRekrutacyjneBLL.Interfaces;

namespace ZadaniaRekrutacyjneBLL.Services
{
    public class MissingNumberService : IMissingNumberService
    {
        public string FindMissingNumber(string number)
        {
            var allNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            var numbersPassed = new List<int>();
            for(int i = 0; i< number.Length; i++)
            {
                numbersPassed.Add(int.Parse(number[i].ToString()));
            }
            var stringBuilder = new StringBuilder();
            foreach(var element in allNumbers.ExceptBy(numbersPassed, x => x).ToList())
            {
                stringBuilder.Append(element.ToString());
                stringBuilder.Append(" ");
            }
            return stringBuilder.ToString();
        }

    }
}
