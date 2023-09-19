using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadaniaRekrutacyjneBLL.Interfaces;

namespace ZadaniaRekrutacyjneBLL.Services
{
    public class FindPositiveInt : IFindPositiveInt
    {
        public int FindPositiveIntiger(string input)
        {
            var inputListOfInt = new List<int>();
            var inputStringSplited = input.Split(',');
            for(int i = 0;i < inputStringSplited.Length;i++)
            {
                inputListOfInt.Add(int.Parse(inputStringSplited[i]));
            }
            int[] positiveNumbers = inputListOfInt.Where(x => x > 0).Distinct().ToArray();
            if (positiveNumbers.Length == 0)
            {
                return 1;
            }
            int missingNumber = 1;
            Array.Sort(positiveNumbers);
            for (int i = 0; i < positiveNumbers.Length; i++)
            {
                if (positiveNumbers[i] == missingNumber)
                {
                    missingNumber++;
                }
                else if (positiveNumbers[i] > missingNumber)
                {
                    break;
                }
            }
            return missingNumber;
        }
    }
}