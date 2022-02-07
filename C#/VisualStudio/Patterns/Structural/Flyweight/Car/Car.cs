namespace Flyweight
{
    // Класс машины
    public class Car
    {
        // Который имеет свойства
        // Имя Владельца автомобиля
        public string Owner { get; set; }
        // Регистрационный номер автомобиля
        public string Number { get; set; }
        // Марка автомобиля
        public string Company { get; set; }
        // Модель автомобиля
        public string Model { get; set; }
        // Цвет автомобиля
        public string Color { get; set; }
    }
}