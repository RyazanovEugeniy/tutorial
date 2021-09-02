using System;

namespace Bridge
{
    class Client
    {
        public void ClientCode(Figure figure)
        {
            Console.Write(figure.Info());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Figure figure;

            figure = new Cube(new Red());
            client.ClientCode(figure);

            figure = new Pyramid(new Red());
            client.ClientCode(figure);
            figure = new Pyramid(new Blue());
            client.ClientCode(figure);

            figure = new Sphere(new Green());
            client.ClientCode(figure);

            Console.ReadKey();
        }
    }
}