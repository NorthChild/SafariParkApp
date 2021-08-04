using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public sealed class Rectangle : Shape
    {
        private int _width;
        private int _height;


        public Rectangle(int width, int height) 
            {
                _width = width;
                _height = height;
            }

        public override int CalculateArea()
        {
            return _width * _height;
        }
    }

}
