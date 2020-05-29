using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_г
{
    class Triangle : Figure
    {
        public double sideA, sideB, sideC;

        public double SideA
        {
            get
            {
                return sideA;
            }
            set
            {
                if (value < 0)
                    sideA = -value;
                else
                    sideA = value;
            }
        }
        public double SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                if (value < 0)
                    sideB = -value;
                else
                    sideB = value;
            }
        }
        public double SideC
        {
            get
            {
                return sideC;
            }
            set
            {
                if (value < 0)
                    sideC = -value;
                else
                    sideC = value;
            }
        }
        /// <summary>
        /// Конструктор класса Triangle (треугольник)
        /// </summary>
        /// <param name="triangleSideA"> сторна A </param>
        /// <param name="triangleSideB"> сторна B </param>
        /// <param name="triangleSideC"> сторна C </param>
        public Triangle(double triSideA, double triSideB, double triSideC)
        {
            SideA = triSideA;
            SideB = triSideB;
            SideC = triSideC;
        }

        /// <summary>
        /// Метод, вычисляющий площадь треугольника
        /// </summary>
        /// <returns> Площадь треугольника </returns>
        public override double Area()
        {
            double polPer = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(polPer * (polPer - sideA) * (polPer - sideB) * (polPer - sideC));
        }

        /// <summary>
        ///  Метод, вычисляющий периметр треугольника
        /// </summary>
        /// <returns> Периметр треугольника </returns>
        public override double Perimeter()
        {
            return (sideA + sideB + sideC);
        }

        /// <summary>
        /// Метод, возвращающий тип фигуры
        /// </summary>
        /// <returns> Тип фигуры </returns>
        public override string FigureType()
        {
            return "Треугольник";
        }
    }
}
