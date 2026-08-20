using System;

namespace Assignment
{
    class Search2DMatrix
    {
        public bool Find(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                int left = 0;
                int right = columns - 1;

                // Apply Binary Search on each sorted row
                while (left <= right)
                {
                    int middle = left + (right - left) / 2;

                    if (matrix[row, middle] == target)
                        return true;

                    if (matrix[row, middle] < target)
                        left = middle + 1;
                    else
                        right = middle - 1;
                }
            }

            return false;
        }

        public void Display(int[,] matrix, int target)
        {
            if (Find(matrix, target))
                Console.WriteLine($"Target {target} found");
            else
                Console.WriteLine($"Target {target} not found");
        }
    }
}