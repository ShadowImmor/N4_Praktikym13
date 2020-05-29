using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_к
{
    class Rectangle : Figure
    {
        public double width;
        public double height;

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                    width = -value;
                else
                    width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                    height = -value;
                else
                    height = value;
            }
        }
        /// <summary>
        /// Конструктор класса Rectangle (прямоугольник)
        /// </summary>
        /// <param name="rectangleWidth"> ширина прямоугольника </param>
        /// <param name="rectangleHeight"> высота прямоугольника </param>
        public Rectangle(double reсleWidth, double recleHeight)
        {
            Width = reсleWidth;
            Height = recleHeight;
        }

        /// <summary>
        /// Метод, вычисляющий площадь прямоугольника
        /// </summary>
        /// <returns> Площадь прямоугольника </returns>
        public override double Area()
        {
            return (width * height);
        }

        /// <summary>
        /// Метод, вычисляющий периметра прямоугольника
        /// </summary>
        /// <returns> Периметр прямоугольника </returns>
        public override double Perimeter()
        {
            return (width * 2 + height * 2);
        }

        /// <summary>
        /// Метод, возвращающий тип фигуры
        /// </summary>
        /// <returns> Тип фигуры </returns>
        public override string FigureType()
        {
            return "Прямоугольник";
        }
    }
}
