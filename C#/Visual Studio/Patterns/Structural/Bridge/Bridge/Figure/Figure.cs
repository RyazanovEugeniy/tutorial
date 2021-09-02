using System;

namespace Bridge
{
    class Figure
    {
        protected IColor color;

        public Figure(IColor color)
        {
            this.color = color;
        }

        public virtual string Info()
        {
            return "AbstractFigure: " +
                color.GetColor();
        }
    }

    class Cube : Figure
    {
        public Cube(IColor color) : base(color)
        {
        }

        public override string Info()
        {
            return "Cube: " +
                base.color.GetColor();
        }
    }

    class Sphere : Figure
    {
        public Sphere(IColor color) : base(color)
        {
        }

        public override string Info()
        {
            return "Sphere: " +
                base.color.GetColor();
        }
    }

    class Pyramid : Figure
    {
        public Pyramid(IColor color) : base(color)
        {
        }

        public override string Info()
        {
            return "Pyramid: " +
                base.color.GetColor();
        }
    }
}