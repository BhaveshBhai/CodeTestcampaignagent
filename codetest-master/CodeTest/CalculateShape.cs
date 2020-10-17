using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTest
{
    public class CalculateShape
    {
        public readonly double lengthOrRadius;
        public CalculateShape(double _lengthOrRedius)
        {
            lengthOrRadius = _lengthOrRedius;
        }
        public double CalculateCircleArea()
        {
            return Math.Round(Math.PI * (lengthOrRadius * lengthOrRadius), 2);

        }
        public double CalculateRectangleArea(double height)
        {
            return Math.Round((lengthOrRadius * height), 2);
        }
        public double CalculateCirclePerimeter()
        {
            return Math.Round((2 * Math.PI * lengthOrRadius), 2);
        }
        public double CalculateRectanglePerimeter(double height)
        {
            return Math.Round(2 * (lengthOrRadius + height), 2);
        }
    }
}
