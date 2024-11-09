using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    public class Rectangle
    {
        public Rectangle(string color)
        {
            Color = color;
        }

        // declaration of field
        public const int NumberOfCorner = 4;

        private const int NUMBER_OF_CORNER = 10;

        // declaration of field
        public readonly string Color;

        // naming convention is it is private then there is a dash, if it is not private then it will have a capital letter
        private readonly string _color;

        public double Width { get; set; }
        public double Height { get; set; }
        public double Area { get
            {
                return Width * Height; 
            } 
         }

        public void DisplayDetails() 
        {
            Console.WriteLine($"Color: {Color}, Width: {Width}, Height: {Height}, Area: {Area}, Corners: {NUMBER_OF_CORNER}");
        }
    }
}
