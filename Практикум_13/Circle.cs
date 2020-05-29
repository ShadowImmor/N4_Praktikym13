using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_к
{
    class Circle : Figure
    {
        private double circumference;

        public double Circumference
        {
            get
            {
                return circumference;
            }
            set
            {
                if (value < 0)
                    circumference = -value;
                else
                    circumference = value;
            }
        }

        /// <summary>
        /// Конструктор класса Circle (круг)
        /// </summary>
        /// <param name="cir"> длина окружности </param>
        public Circle(double cir)
        {
            Circumference = cir;
        }

        /// <summary>
        /// Метод, вычисляющий площадь круга
        /// </summary>
        /// <returns> Площадь круга </returns>
        public override double Area()
        {
            return ((circumference * circumference) / (4 * Math.PI));
        }

        /// <summary>
        /// Метод, вычисляющий периметр круга
        /// </summary>
        /// <returns> Периметр круга </returns>
        public override double Perimeter()
        {
            return circumference;
        }

        /// <summary>
        /// Метод, возвращающий тип фигуры
        /// </summary>
        /// <returns> Тип фигуры </returns>
        public override string FigureType()
        {
            return "Круг";
        }
    }
}
