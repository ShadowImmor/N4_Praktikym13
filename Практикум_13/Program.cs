using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_к
{
    class Program
    {
        public static Figure[] fileInfo(string filePath)
        {
            if (!File.Exists(filePath))
                return null;
            string[] strmas = File.ReadAllLines(filePath);
            Figure[] figure = new Figure[strmas.Count()];
            string[] strfigur;
            int indexFigure = 0;
            double wh;
            foreach (string str in strmas)
            {
                strfigur = str.Split(new string[] { "; ", ";" }, StringSplitOptions.RemoveEmptyEntries);
                if (strfigur[0] == "Triangle" || strfigur[0] == "triangle" && strfigur.Count() >= 4)
                {
                    if (double.TryParse(strfigur[1], out wh) && double.TryParse(strfigur[2], out wh) && double.TryParse(strfigur[3], out wh))
                    {
                        figure[indexFigure] = new Triangle(double.Parse(strfigur[1]), double.Parse(strfigur[2]), double.Parse(strfigur[3]));
                        indexFigure++;
                    }
                }
                if (strfigur[0] == "Rectangle" || strfigur[0] == "rectangle" && strfigur.Count() >= 3)
                {
                    if (double.TryParse(strfigur[1], out wh) && double.TryParse(strfigur[2], out wh))
                    {
                        figure[indexFigure] = new Rectangle(double.Parse(strfigur[1]), double.Parse(strfigur[2]));
                        indexFigure++;
                    }
                }
                if (strfigur[0] == "Circle" || strfigur[0] == "circle" && strfigur.Count() >= 2)
                {
                    if (double.TryParse(strfigur[1], out wh))
                    {
                        figure[indexFigure] = new Circle(double.Parse(strfigur[1]));
                        indexFigure++;
                    }
                }
            }
            return figure;
        }
        static void Main(string[] args)
        {
            string filepath = "..\\..\\..\\fileinfo.txt";
            Figure[] mas = fileInfo(filepath);
            if (mas == null)
                Console.WriteLine("Некорректный путь");
            else if (mas.Count() == 0)
                Console.WriteLine("Файл пуст");
            else
            {
                Console.WriteLine("Информация о фигурах правильно записанных в файл:");
                for (int i = 0; i < mas.Count() && mas[i] != null; i++)
                {
                    mas[i].ShowInfo();
                    Console.WriteLine("---------------------------------------");
                }
            }
            Console.ReadLine();
        }
    }
}
