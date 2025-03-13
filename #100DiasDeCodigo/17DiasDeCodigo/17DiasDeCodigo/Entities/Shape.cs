﻿using _17DiasDeCodigo.Entities.Enums;

namespace _17DiasDeCodigo.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
