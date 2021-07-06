using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;

namespace Foundational
{
    public class Drawing  
    {  
        public virtual double Area()  
        {  
            return 55;  
        }  
    }  
  
    public class Circle : Drawing  
    {  
        public double Radius { get; set; }  
        public Circle()  
        {  
            Radius = 5;  
        }
    }  
  
    public class Square : Drawing  
    {  
        public double Length { get; set; }  
        public Square()  
        {  
            Length = 6;  
        }  
        public override double Area()  
        {  
            return Math.Pow(Length, 2);  
        }  
    }  
  
    public class Rectangle : Drawing  
    {  
        public double Height { get; set; }  
        public double Width { get; set; }  
        public Rectangle()  
        {  
            Height = 5.3;  
            Width = 3.4;  
        }  
        public override double Area()  
        {  
            return Height * Width;  
        }  
    }  
  
    class Program  
    {  
        static void Main(string[] args)  
        {  
  
            Drawing circle = new Circle();  
            Console.WriteLine("Area :" + circle.Area());  
  
            Drawing square = new Square();  
            Console.WriteLine("Area :" + square.Area());  
  
            Drawing rectangle = new Rectangle();  
            Console.WriteLine("Area :" + rectangle.Area());  
            
            DoStuff(new List<Drawing> {circle, square, rectangle});
        }

        public static void DoStuff(List<Drawing> collection)
        {
            collection.ForEach((c) =>
            {
                Console.WriteLine("Area: " + c.Area());
            });
        }
    }
}