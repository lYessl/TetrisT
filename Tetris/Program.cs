using System;
using System.Threading;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            //Figure[] f = new Figure[2];
            //f[0] = new Square(2, 5, '*');
            //f[1] = new Stick(6, 6, '*');

            //foreach(Figure fig in f)
            //{
            //    fig.Draw();
            //}

            FigureGenerator generator = new FigureGenerator(20, 0, '*');
            Figure currentFigure = generator.GetNewFigure();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    HandleKey(currentFigure, key);
                }
                //FigureFall(out s, generator);
                //s.Draw();
            }

            //s.Draw();

            //Thread.Sleep(500);
            //s.Hide();
            //s.Rotate();
            //s.Draw();

            //Thread.Sleep(500);
            //s.Hide();
            //s.Rotate();
            //s.Draw();

            //Thread.Sleep(500);
            //s.Hide();
            //s.Move(Direction.LEFT);
            //s.Draw();

            //Thread.Sleep(500);
            //s.Hide();
            //s.Move(Direction.DOWN);
            //s.Draw();

            //Thread.Sleep(500);
            //s.Hide();
            //s.Move(Direction.RIGHT);
            //s.Draw();
            //Stick stick = new Stick(5, 8, '*');
            //stick.Draw();

            //    Point p1 = new Point(2, 3, '*');
            //    p1.Draw();

            //    Point p2 = new Point()
            //    {
            //        x = 4,
            //        y = 5,
            //        c = '#'
            //    };
            //    p2.Draw();

            //    Console.ReadLine();
            //}

            //static void FigureFall(out Figure fig, FigureGenerator generator)
            //{
            //    fig = generator.GetNewFigure();
            //    fig.Draw();

            //    for (int i = 0; i < 15; i++)
            //    {
            //        fig.Hide();
            //        fig.Move(Direction.DOWN);
            //        fig.Draw();
            //        Thread.Sleep(200);
            //    }

        }

            private static void HandleKey(Figure currentFigure, ConsoleKeyInfo key)
            {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    currentFigure.TryMove(Direction.LEFT);
                    break;

                case ConsoleKey.RightArrow:
                    currentFigure.TryMove(Direction.RIGHT);
                    break;
                case ConsoleKey.DownArrow:
                    currentFigure.TryMove(Direction.DOWN);
                    break;
            }
        }
        
    }
}