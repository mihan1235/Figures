using System;

namespace FiguresLib
{
    public abstract class Figure
    {
    }

    //Не все фигуры имеют площадь. Например, луч или точка.
    public interface IArea
    {
        public double Area();
    }

    // В задании не указано в какой системе координат будут данные фигуры,
    // соответсвенно не использую координаты
    public class Circle : Figure, IArea
    {
        public Circle()
        {
            Radius = 1;
        }
        public Circle(double radius) { this.Radius = radius; }

        public double Radius
        {
            get; set;
        }

        public double Area()
        {
            if (Radius > 0)
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
            return -1;
        }

    }

    //Подразумеваем обычный треугольник.
    public class Triangle : Figure, IArea
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }

        public Triangle(double FS = 1, double SS = 2, double TS = 3)
        {
            FirstSide = FS;
            SecondSide = SS;
            ThirdSide = TS;
        }

        bool CheckTriangle()
        {
            //Неравенство треугольника
            if (FirstSide <= SecondSide + ThirdSide)
            {
                if (SecondSide <= FirstSide + ThirdSide)
                {
                    if (ThirdSide <= FirstSide + SecondSide)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Является ли прямоугольным треугольником
        public  bool IsRightTriangle()
        {
            // Не самый оптимальный вариант. Можно было найти максимальную сторону 
            // и потом вычислить один раз теорему Пифагора, но так проще.
            if (CheckTriangle() == false) return false;
            if (Math.Pow(FirstSide,2) == Math.Pow(SecondSide,2) + Math.Pow(ThirdSide, 2))
            {
                return true;
            }
            if (Math.Pow(SecondSide,2) == Math.Pow(FirstSide,2) + Math.Pow(ThirdSide, 2))
            {
                return true;
            }
            if (Math.Pow(ThirdSide,2) == Math.Pow(SecondSide,2) + Math.Pow(FirstSide, 2))
            {
                return true;
            }
            return false;
        }
        public double Area()
        {
            if (CheckTriangle())
            {
                double p = 1.0 / 2.0 * (FirstSide + SecondSide + ThirdSide);
                //Формула Герона
                return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
            }
            else return -1;
        }
    }
}
