using System;

namespace CodingPractice
{
    public class PathHelper
    {
        private int MaxSoFar = 0;

        internal int GetLongestPath(int[][] array, int startRow, int startColumn)
        {
            DFS(array, startRow, startColumn, currentValue: 1);
            return MaxSoFar;

        }

        private void DFS(int[][] array, int currentRow, int currentCol, int currentValue)
        {
            if (currentRow < 0 || currentCol < 0 ||
            currentRow == array.Length || currentCol == array[0].Length ||
            array[currentRow][currentCol] != 1)
            {
                return;
            }

            array[currentRow][currentCol] = currentValue;
            MaxSoFar = currentValue > MaxSoFar ? currentValue : MaxSoFar;

            DFS(array, currentRow + 1, currentCol, currentValue + 1);
            DFS(array, currentRow - 1, currentCol, currentValue + 1);
            DFS(array, currentRow, currentCol + 1, currentValue + 1);
            DFS(array, currentRow, currentCol - 1, currentValue + 1);

            array[currentRow][currentCol] = 1;
        }
    }
}