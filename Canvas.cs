﻿using System;
using System.Collections.Generic;

namespace CSharpMethodOverriding
{
    public class Canvas
    {
        public void DrawShape(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        
        }
    }
}
