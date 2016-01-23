using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_Geometry_Figure
{
    interface AreaCountable
    {
        double Area();
    }

    class Rectangle : AreaCountable
    {
        private double height;
        private double width;

        public double Height {
            get {
                return height;
            }
            set {
                if (value <= 0) {
                    throw new Exception("Error");
                }
                else
                {
                    height = value;
                }
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Error");
                }
                else {
                    width = value;
                }
            }
        }
        
        public double Area() 
        {
            return height * width;
        }
    }
    class Triangle : AreaCountable
    {
        private double height;
        private double basa;

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Error");
                }
                else
                {
                    height = value;
                }
            }
        }
        public double Basa
        {
            get
            {
                return basa;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Error");
                }
                else
                {
                    basa = value;
                }
            }
        }

        public double Area()
        {
            return (height * basa)/2;
        }
    }

    class Circle : AreaCountable
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Error");
                }
                else
                {
                    radius = value;
                }
            }
        }
        
        public double Area()
        {
            return radius * radius * Math.PI;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Triangle t = new Triangle();
            Circle c = new Circle();
            r.Height = 10;
            r.Width = 10;
            t.Basa = 12;
            t.Height = 10;
            c.Radius = 10;
            Console.WriteLine(r.Area());
            Console.WriteLine(t.Area());
            Console.WriteLine(c.Area());
            Console.ReadKey();
        }
    }
}
