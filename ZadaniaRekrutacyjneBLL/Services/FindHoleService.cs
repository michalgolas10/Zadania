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
            var matrixOfIntigers = new int[numberOfRows, numberOfColumns];
            var matrixTwoDimensionsIntArray = new int[numberOfRows,numberOfColumns];
            for(int i = 0; i < numberOfRows; i++)
            {
                for(int j =0; j< numberOfColumns; j++)
                {
                    matrixOfIntigers[i, j] = int.Parse(matrixSplited[i].ElementAt(j).ToString());
                }
            }
            return matrixOfIntigers;
        }

        public List<string> FindHole(int[,] matrixofInts)
        {
            int rows = matrixofInts.GetLength(0);
            int cols = matrixofInts.GetLength(1);
            var ListOfHoles = new List<string>();
            for(int i =0; i < rows; i++)
            {
                for(int j =0; j < cols; j++)
                {
                    if (matrixofInts[i, j] == 0)
                    {
                        if (IsHole(matrixofInts, i, j, rows, cols))
                            ListOfHoles.Add($"Hole is on index: {i};{j}");
                    }
                }
            }
            return ListOfHoles;
        }
        static bool IsHole(int[,] matrix, int row, int col, int numRows, int numCols)
        {
            if ((col > 0 && matrix[row, col - 1] == 0) || (col < numCols - 1 && matrix[row, col + 1] == 0))
            {
                return true;
            }

            if ((row > 0 && matrix[row - 1, col] == 0) || (row < numRows - 1 && matrix[row + 1, col] == 0))
            {
                return true;
            }

            return false;
        }
    }
}
