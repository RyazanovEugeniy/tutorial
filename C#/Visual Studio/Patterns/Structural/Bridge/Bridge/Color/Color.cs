using System;

namespace Bridge
{
    public interface IColor
    {
        string GetColor();
    }

    class Red : IColor
    {
        public string GetColor()
        {
            return "Red.\n";
        }
    }

    class Blue : IColor
    {
        public string GetColor()
        {
            return "Blue.\n";
        }
    }

    class Green : IColor
    {
        public string GetColor()
        {
            return "Green.\n";
        }
    }
}