using System;

namespace LibraryCalculatingArea
{
    /// <summary>
    /// Class calculates area triangle
    /// </summary>
    public class Triangle : Figure
    {
        private readonly double _sideB, _sideC, _sideA ;
        private readonly double[] _arraySide;

        /// <summary>
        /// Constructor class
        /// </summary>
        /// <param name="sideA">Side A</param>
        /// <param name="sideB">Side B</param>
        /// <param name="sideC">Side C</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            _arraySide = new double[3] {sideA, sideB, sideC};
        }
        
        ///  <summary>
        /// Calculating the area
        /// </summary>
        /// <returns>The area of the triangle</returns>
        public override double Square()
        {
            IsArgumentsCorrectly(_sideA, _sideB, _sideC);

            double p = (_sideA + _sideB + _sideC) / 2;

            double s = Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));

            return s;
        }

        /// <summary>
        /// Checks whether the triangle is rectangular
        /// </summary>
        /// <returns>If true, the triangle is rectangular, otherwise false</returns>
        public bool IsRightTriangle()
        {
            Array.Sort(_arraySide);
            Array.Reverse(_arraySide);
            
            const byte power = 2;
            
            return Math.Pow(_arraySide[0], power) == Math.Pow(_arraySide[1], power) + Math.Pow(_arraySide[2], power);
        }
        
        /// <summary>
        /// Checks the correctness of the received arguments
        /// </summary>
        /// <param name="sideA">Side A</param>
        /// <param name="sideB">Side B</param>
        /// <param name="sideC">Side C</param>
        /// <exception cref="ArgumentException">Non existent figure</exception>
        private static void IsArgumentsCorrectly(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("None of the sides of the triangle can be less than or equal to zero");
            }

            if (sideA >= (sideB + sideC) || sideB >= (sideA + sideC) || sideC >= (sideA + sideB))
            {
                throw new ArgumentException("A side cannot be greater than or equal to the sum of the two sides");
            }
        }
    }
}