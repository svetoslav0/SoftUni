using System;
using System.Linq;

namespace _05._Rubiks_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int loops = int.Parse(Console.ReadLine());
            int rows = sizes[0];
            int cols = sizes[1];
            
            int[][] matrix = new int[rows][];
            FillMatrix(matrix, cols);
            ShuffleMatrix(matrix, loops);
            RearrangeMatrix(matrix);
        }
        public static void FillMatrix(int[][] matrix, int cols)
        {
            int counter = 1;
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[cols];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = counter;
                    counter++;
                }
            }
        }
        public static void ShuffleMatrix(int[][] matrix, int loops)
        {

            for (int i = 0; i < loops; i++)
            {
                string[] currentCommand = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int colOrRowIndex = int.Parse(currentCommand[0]);
                string direction = currentCommand[1];
                int moves = int.Parse(currentCommand[2]);

                switch (direction)
                {
                    case "up":
                        MoveUp(matrix, colOrRowIndex, moves);
                        break;
                    case "down":
                        MoveDown(matrix, colOrRowIndex, moves);
                        break;
                    case "left":
                        MoveLeft(matrix, colOrRowIndex, moves);
                        break;
                    case "right":
                        MoveRight(matrix, colOrRowIndex, moves);
                        break;
                }
            }
        }
        public static void MoveUp(int[][] matrix, int colIndex, int moves)
        {
            int height = matrix.Length;
            for (int i = 0; i < moves; i++)
            {
                int memory = matrix[0][colIndex];
                for (int j = 0; j < height - 1; j++)
                {
                    matrix[j][colIndex] = matrix[(j + 1) % height][colIndex];
                    matrix[(j + 1) % height][colIndex] = memory;
                }

            }
        }
        public static void MoveDown(int[][] matrix, int colIndex, int moves)
        {
            int height = matrix.Length;
            for (int i = 0; i < moves; i++)
            {
                int memory = matrix[matrix.Length - 1][colIndex];
                for (int j = height - 1; j > 0; j--)
                {
                    matrix[j][colIndex] = matrix[j - 1][colIndex];
                    matrix[j - 1][colIndex] = memory;
                }
            }
        }
        public static void MoveLeft(int[][] matrix, int rowIndex, int moves)
        {
            int width = matrix[rowIndex].Length;
            for (int i = 0; i < moves; i++)
            {
                int memory = matrix[rowIndex][0];
                for (int j = 0; j < width - 1; j++)
                {
                    matrix[rowIndex][j] = matrix[rowIndex][j + 1];
                    matrix[rowIndex][j + 1] = memory;
                }
            }
        }
        public static void MoveRight(int[][] matrix, int rowIndex, int moves)
        {
            int width = matrix[rowIndex].Length;
            for (int i = 0; i < moves; i++)
            {
                int memory = matrix[rowIndex][matrix[rowIndex].Length - 1];
                for (int j = width - 1; j > 0; j--)
                {
                    matrix[rowIndex][j] = matrix[rowIndex][j - 1];
                    matrix[rowIndex][j - 1] = memory;
                }
            }
        }
        public static void RearrangeMatrix(int[][] matrix)
        {
            int counter = 1;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == counter)
                    {
                        Console.WriteLine($"No swap required");
                    }
                    else
                    {
                        int[] numberLocation = FindNumber(matrix, counter);
                        int foundRow = numberLocation[0];
                        int foundCol = numberLocation[1];
                        int memory = matrix[row][col];
                        matrix[row][col] = matrix[foundRow][foundCol];
                        matrix[foundRow][foundCol] = memory;
                        Console.WriteLine($"Swap ({row}, {col}) with ({foundRow}, {foundCol})");
                    }

                    counter++;
                }
            }
        }
        public static int[] FindNumber(int[][] matrix, int wantedNumber)
        {
            int[] numberLocation = { 0, 0 };
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (wantedNumber == matrix[i][j])
                    {
                        numberLocation[0] = i;
                        numberLocation[1] = j;
                    }
                }
            }
            return numberLocation;
        }
    }
}
