﻿using System;
using System.Collections.Generic;
namespace CSharpMethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {

            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());


            var canvas = new Canvas();
            canvas.DrawShape(shapes);

        }
    }
}
