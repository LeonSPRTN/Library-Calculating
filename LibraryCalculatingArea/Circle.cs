using System;

namespace LibraryCalculatingArea
{
    /// <summary>
    /// Class calculates area circle
    /// </summary>
    public class Circle: Figure
    {
        private readonly double _radius;

        /// <summary>
        /// Constructor class
        /// </summary>
        /// <param name="radius">Circle radius</param>
        public Circle(double radius)
        {
            _radius = radius;
        }
        
        ///  <summary>
        /// Calculating the area
        /// </summary>
        /// <returns>The area of the circle</returns>
        public override double Square()
        {
            IsArgumentsCorrectly(_radius);
            
            return Math.PI * Math.Pow(_radius, 2);
        }
        
        /// <summary>
        /// Checks the correctness of the received arguments
        /// </summary>
        /// <param name="radius">Circle radius</param>
        /// <exception cref="ArgumentException">Non existent figure</exception>
        private void IsArgumentsCorrectly(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("The radius of the circle cannot be less than or equal to zero");
            }
        }
    }
}