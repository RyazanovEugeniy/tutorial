using System;

namespace Prototype
{
    class MegaClass
    {
        public int number = 0;

        public MegaClass() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MegaClass megaClass = new MegaClass();
            megaClass.number = 2;
            Console.WriteLine("megaClass.number == " + megaClass.number);

            MegaClass megaClass2 = megaClass;
            Console.WriteLine("megaClass2.number == " + megaClass2.number);

            megaClass.number = 1;
            Console.WriteLine("megaClass2.number == " + megaClass2.number);
            Console.WriteLine();


            Person p1 = new Person();
            p1.Age = 42;
            p1.BirthDate = Convert.ToDateTime("1977-01-01");
            p1.Name = "Jack Daniels";
            p1.IdInfo = new IdInfo(666);

            // Выполнить поверхностное копирование p1 и присвоить её p2.
            Person p2 = p1.ShallowCopy();
            // Сделать глубокую копию p1 и присвоить её p3.
            Person p3 = p1.DeepCopy();

            // Вывести значения p1, p2 и p3.
            Console.WriteLine("Original values of p1, p2, p3:");
            Console.WriteLine("   p1 instance values: ");
            p1.DisplayValues();
            Console.WriteLine("   p2 instance values:");
            p2.DisplayValues();
            Console.WriteLine("   p3 instance values:");
            p3.DisplayValues();

            // Изменить значение свойств p1 и отобразить значения p1, p2 и p3.
            p1.Age = 32;
            p1.BirthDate = Convert.ToDateTime("1900-01-01");
            p1.Name = "Frank";
            p1.IdInfo.IdNumber = 7878;
            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            p1.DisplayValues();
            Console.WriteLine("   p2 instance values (reference values have changed):");
            p2.DisplayValues();
            Console.WriteLine("   p3 instance values (everything was kept the same):");
            p3.DisplayValues();

            Console.ReadKey();
        }
    }

}