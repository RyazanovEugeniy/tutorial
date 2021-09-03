using System;

namespace Bridge
{
    class Figure
    {
        // Выделяем память под интерфейс цвета
        protected IColor color;

        // Конструктор класса, в который передаем выбранный интерфейс цвета фигуры и записываем его
        public Figure(IColor color)
        {
            this.color = color;
        }

        // Метод фигуры по возвращению ее названия и цвета фигуры, используя интерфейс цвета
        // Который будем переопределять в методах наследниках
        public virtual string Info()
        {
            return "AbstractFigure: " +
                color.GetColor();
        }
    }

    // Для примера создаем несколько классов наследующих класс Figure,
    // Куб
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

    // Сфера
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

    // Пирамида
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