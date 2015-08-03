namespace CohesionAndCoupling
{
    using System;

    public static class DistanceCalculator
    {
        public enum DiagonalFormat
        {
            Xyz,
            Xy,
            Yz,
            Xz
        }
        
        public static double CalcDistance2D(double aX, double aY, double bX, double bY)
        {
            double distance2D = Math.Sqrt(
                ((bX - aX) * (bX - aX)) + 
                ((bY - aY) * (bY - aY)));
            
            return distance2D;
        }

        public static double CalcDistance3D(
            double aX, double aY, double aZ, double bX, double bY, double bZ)
        {
            double distance3D = Math.Sqrt(
                ((bX - aX) * (bX - aX)) + 
                ((bY - aY) * (bY - aY)) + 
                ((bZ - aZ) * (bZ - aZ)));
            
            return distance3D;
        }

        public static double Calc3DSpaceDiagonalDistance(
            double width, double height, double depth, DiagonalFormat diagonalFormat)
        {
            switch (diagonalFormat)
            {
                case DiagonalFormat.Xyz:
                    return CalcDistance3D(0, 0, 0, width, height, depth);
                
                case DiagonalFormat.Xy:
                    return CalcDistance2D(0, 0, width, height);
                
                case DiagonalFormat.Xz:
                    return CalcDistance2D(0, 0, width, depth);
                
                case DiagonalFormat.Yz:
                    return CalcDistance2D(0, 0, height, depth);
                
                default:
                    throw new ArgumentException("Invalid diagonal format."); // should never happen
            }
        }
    }
}
