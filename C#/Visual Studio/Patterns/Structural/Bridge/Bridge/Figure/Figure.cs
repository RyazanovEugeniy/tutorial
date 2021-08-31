using System;

namespace Bridge
{
    class AbstractFigure
    {
        protected IColor color;

        public AbstractFigure(IColor color)
        {
            this.color = color;
        }

        public virtual string Info()
        {
            return "AbstractFigure: " +
                color.GetColor();
        }
    }

    class Cube : AbstractFigure
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

    class Sphere : AbstractFigure
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

    class Pyramid : AbstractFigure
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