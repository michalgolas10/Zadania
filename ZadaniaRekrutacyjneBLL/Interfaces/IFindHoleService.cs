using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniaRekrutacyjneBLL.Interfaces
{
    public interface IFindHoleService
    {
        public List<string> FindHole(string matrixofString);
        public int[,] CreateMatrixFromString(string matrixofString);
    }
}
