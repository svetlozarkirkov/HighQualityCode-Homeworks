namespace Methods
{
    using System;

    public static class Methods
    {
        public enum NumberFormat
        {
            Float,
            Percent,
            PaddedRight
        }

        public static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToDigit(5));

            int[] arr = { 5, -1, 3, 2, 14, 2, 3 };
            Console.WriteLine(FindMax(arr));
            Console.WriteLine("[ " + string.Join(", ", arr) + " ]");

            PrintFormattedNumber(1.3, NumberFormat.Float);
            PrintFormattedNumber(0.75, NumberFormat.Percent);
            PrintFormattedNumber(2.30, NumberFormat.PaddedRight);

            double pointOneX = 3;
            double pointOneY = -1;
            double pointTwoX = 3;
            double pointTwoY = 2.5;
            Console.WriteLine("Distance: " + CalculateDistance(pointOneX, pointOneY, pointTwoX, pointTwoY));
            Console.WriteLine("Horizontal? " + (pointOneX.Equals(pointTwoX)));
            Console.WriteLine("Vertical? " + (pointOneY.Equals(pointTwoY)));

            Student peter = new Student(
                "Peter", 
                "Ivanov", 
                "From Sofia, born at 17.03.1992", 
                new DateTime(1992, 03, 17));

            Student stella = new Student(
                "Stella",
                "Markova",
                "From Vidin, gamer, high results, born at 03.11.1993",
                new DateTime(1993, 11, 03));

            Console.WriteLine(
                "{0} older than {1} -> {2}",
                peter.FirstName, 
                stella.FirstName, 
                peter.IsOlderThan(stella));
        }

        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            bool hasInvalidSides = sideA <= 0 || sideB <= 0 || sideC <= 0;
            
            if (hasInvalidSides)
            {
                throw new ArgumentException("All sides should be positive.");
            }

            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(halfPerimeter * 
                                    (halfPerimeter - sideA) * 
                                    (halfPerimeter - sideB) * 
                                    (halfPerimeter - sideC));
            return area;
        }

        public static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Invalid number!");
            }
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("The array is empty.");
            }

            // Using a clone of the parameter so that the original array is not modified by this method
            int[] elementsClone = (int[])elements.Clone();

            for (int currentIndex = 1; currentIndex < elementsClone.Length; currentIndex++)
            {
                if (elementsClone[currentIndex] > elementsClone[0])
                {
                    elementsClone[0] = elementsClone[currentIndex];
                }
            }

            return elementsClone[0];
        }

        public static void PrintFormattedNumber(object number, NumberFormat format)
        {
            switch (format)
            {
                case NumberFormat.Float:
                    Console.WriteLine("{0:f2}", number);
                    break;
                case NumberFormat.Percent:
                    Console.WriteLine("{0:p0}", number);
                    break;
                case NumberFormat.PaddedRight:
                    Console.WriteLine("{0,8}", number);
                    break;
                default:
                    throw new ArgumentException("Invalid format!"); // should never happen
            }
        }

        public static double CalculateDistance(
            double pointOneX, double pointOneY, double pointTwoX, double pointTwoY)
        {
            // Not using Math.Pow - simple multiplying is faster here
            double distance = 
                Math.Sqrt(((pointTwoX - pointOneX) * (pointTwoX - pointOneX)) + 
                ((pointTwoY - pointOneY) * (pointTwoY - pointOneY)));
            
            return distance;
        }
    }
}
