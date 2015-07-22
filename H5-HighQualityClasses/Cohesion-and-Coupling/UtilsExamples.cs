namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        public static void Main()
        {
            // Console.WriteLine(FileExtensions.GetFileExtension("example")); // throws exception
            Console.WriteLine(FileExtensions.GetFileExtension("example.pdf"));
            Console.WriteLine(FileExtensions.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileExtensions.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileExtensions.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileExtensions.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine(
                "Distance in the 2D space = {0:f2}",
                DistanceCalculator.CalcDistance2D(1, -2, 3, 4));
            
            Console.WriteLine(
                "Distance in the 3D space = {0:f2}",
                DistanceCalculator.CalcDistance3D(5, 2, -1, 3, -6, 4));

            double width = 3;
            double height = 4;
            double depth = 5;
            
            Console.WriteLine("Volume = {0:f2}", VolumeUtilities.CalcVolume(width, height, depth));

            double xyz = DistanceCalculator.Calc3DSpaceDiagonalDistance(
                                    width,
                                    height,
                                    depth,
                                    DistanceCalculator.DiagonalFormat.Xyz);

            Console.WriteLine("Diagonal XYZ = {0:f2}", xyz);

            double xy = DistanceCalculator.Calc3DSpaceDiagonalDistance(
                                    width,
                                    height,
                                    depth,
                                    DistanceCalculator.DiagonalFormat.Xy);

            Console.WriteLine("Diagonal XY = {0:f2}", xy);

            double xz = DistanceCalculator.Calc3DSpaceDiagonalDistance(
                                    width,
                                    height,
                                    depth,
                                    DistanceCalculator.DiagonalFormat.Xz);

            Console.WriteLine("Diagonal XZ = {0:f2}", xz);

            double yz = DistanceCalculator.Calc3DSpaceDiagonalDistance(
                                    width,
                                    height,
                                    depth,
                                    DistanceCalculator.DiagonalFormat.Yz);

            Console.WriteLine("Diagonal YZ = {0:f2}", yz);
        }
    }
}
