using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSwarmOptimization
{
    public class ViewConsole : IObserver
    {
        PSOModel model;
        ControllerConsole controller;


        public ViewConsole(PSOModel model)
        {
            this.model = model;
            this.model.Register(this);

            AddController(MakeConrtoller());
        }

        public void UpdateState()
        {
            double[] points = model.GetPoints();
            Console.WriteLine($"Шаг номер {model.GetIter()}\nКоординаты точек:");
            foreach(double point in points)
            {
                Console.Write($"{Math.Round(point, 5)} ");
            }
            Console.WriteLine();
        }

        public ControllerConsole MakeConrtoller()
        {
            return new ControllerConsole(this, this.model);
        }
        public void AddController(ControllerConsole controller)
        {
            this.controller = controller;
        }

        public void Answer(double g)
        {
            Console.WriteLine("Минимум найден: ({0}, {1})", Math.Round(g, 5), Math.Round(model.GetFunction().calculate(g), 5));
        }
    }
}
