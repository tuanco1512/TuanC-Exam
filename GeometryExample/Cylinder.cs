using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    internal class Cylinder
    {
        private double radius;
        private double height;
        private double baseArea;
        private double lateralArea;
        private double totalArea;
        private double volume;

        public double Radius { get => radius; set => radius = value; }
        public double Height { get=> height; set => height = value; }
        public double BaseArea {get=> baseArea; private set => baseArea = value; }
        public double LateralArea { get =>lateralArea; private set => lateralArea = value;}
        public double TotalArea { get => totalArea; private set => totalArea = value; }
        public double Volume { get=> volume; private set => volume = value; }

        public Cylinder(){}
        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
            Process();
        }
        public void Process() {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }
        public void Result() {
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine("Radius: " + Radius + ", Height: " + Height);
            Console.WriteLine("Base: " + string.Format("{0:0.00}", BaseArea) + " | Lateral: " + string.Format("{0:0.00}", LateralArea) + " | ToTal: " + string.Format("{0:0.00}", TotalArea) + " | Volumn: " + string.Format("{0:0.00}", Volume));
        }
    }
}
