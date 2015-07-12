namespace ConsoleApplication1
{
    using System;

    class MatricesMultiplier
    {
        static void Main()
        {
            var firstMatrix = new double[,]
            {
                { 1, 3 }, 
                { 5, 7 }
            };

            var secondMatrix = new double[,]
            {
                { 4, 2 }, 
                { 1, 5 }
            };

            var resultMatrix = MultiplyMatrices(firstMatrix, secondMatrix);

            for (int rowIndex = 0; rowIndex < resultMatrix.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < resultMatrix.GetLength(1); colIndex++)
                {
                    Console.Write(resultMatrix[rowIndex, colIndex] + " ");
                }
                Console.WriteLine();
            }

        }

        static double[,] MultiplyMatrices(double[,] firstMatrix, double[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
            {
                throw new ArgumentException("Matrices cannot be multiplied");
            }

            var firstMatrixColumnLength = firstMatrix.GetLength(1);
            var resultMatrix = new double[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

            for (int resultMatrixRow = 0; resultMatrixRow < resultMatrix.GetLength(0); resultMatrixRow++)
            {
                for (int resultMatrixCol = 0; resultMatrixCol < resultMatrix.GetLength(1); resultMatrixCol++)
                {
                    for (int currentIndex = 0; currentIndex < firstMatrixColumnLength; currentIndex++)
                    {
                        resultMatrix[resultMatrixRow, resultMatrixCol] += 
                            firstMatrix[resultMatrixRow, currentIndex] * 
                            secondMatrix[currentIndex, resultMatrixCol];
                    }
                }
            }
                        
            return resultMatrix;
        }
    }
}