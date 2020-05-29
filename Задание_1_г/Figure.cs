using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_г
{
    internal abstract class Figure
    {
        public abstract double Area();
        public abstract double Perimeter();
        public abstract string FigureType();

        public string ShowInfo()
        {
            return string.Format("Название фигуры: {0}\nПлощадь: {1}\nПериметр: {2}", FigureType(), Area(), Perimeter());
        }
    }
}
