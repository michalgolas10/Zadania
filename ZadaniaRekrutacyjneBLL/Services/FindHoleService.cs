using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadaniaRekrutacyjneBLL.Interfaces;

namespace ZadaniaRekrutacyjneBLL.Services
{
    public class FindHoleService : IFindHoleService
    {
        public int[,] CreateMatrixFromString(string matrixofString)
        {
            var matrixSplited = matrixofString.Split(',');
            var numberOfRows = matrixSplited[0].Length;
            var numberOfColumns = matrixSplited.Length;
            var matrixTwoDimensionsIntArray = new int[numberOfRows,numberOfColumns];
            for(int i = 0; i < numberOfRows; i++)
            {
                for(int j =0; j< numberOfColumns; j++)
                {
                    matrixTwoDimensionsIntArray[i, j] = (int.Parse(matrixSplited[i].ToString()))[j];
                }
            }
        }

        public List<string> FindHole(int[,] matrixofInts)
        {
            var ListOfHoles = new List<string>();
            for(int i =0; i < matrixofInts.GetLength(0)-1; i++)
            {
                for(int j =0; j < matrixofInts.GetLength(1)-1; j++)
                {
                    if (matrixofInts[i+1,j]==0 || matrixofInts[i, j + 1]==0)
                    {
                        ListOfHoles.Add($"Hole is on index{i};{j}");
                    }
                }
            }
            return ListOfHoles;
        }
    }
}
