using System;

namespace Bridge
{
    class Client
    {
        public void ClientCode(AbstractFigure abstractFigure)
        {
            Console.Write(abstractFigure.Info());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            AbstractFigure figure;

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