﻿namespace CohesionAndCoupling
{
    public static class VolumeUtilities
    {
        public static double CalcVolume(double width, double height, double depth)
        {
            double volume = width * height * depth;
            return volume;
        }
    }
}
