using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace ParticleSwarmOptimization
{
    public class PSO
    {
        double[] x; // координата в пространстве решений
        double[] v; // скорость 
        double[] p; //  лучшее из известных положений частицы i
        double g; // наилучшее известное состояние роя в целом
        int s;  //  количество частиц в рое
        double up, low; // область иксов графика
        Random rnd;

        public int iter;
        public Function func;

        public PSO(Function func, int s, double low, double up)
        {
            this.s = s;
            this.up = up;
            this.low = low;
            this.func = func;

            init();
        }

        private void init()
        {
            x = new double[s];
            v = new double[s];
            p = new double[s];

            iter = 0;

            rnd = new Random();

            x[0] = rnd.NextDouble() * (up - low) + low;
            p[0] = x[0];
            g = x[0];

            for (int i = 1; i < s; i++)
            {
                x[i] = rnd.NextDouble() * (up - low) + low;
                p[i] = x[i];
                if (func.calculate(x[i]) < func.calculate(g)) g = x[i];

                v[i] = rnd.NextDouble() * (-(up - low) - (up - low)) + (up - low);
            }
        }

        public double[] GetPoints()
        {
            return this.x;
        }

        public void Update()
        {
            for (int i = 0; i < s; i++)
            {
                double Rp = rnd.NextDouble();
                double Rg = rnd.NextDouble();

                v[i] = 0.3 * v[i] + 2 * Rp * (p[i] - x[i]) + 5 * Rg * (g - x[i]);
                x[i] += 0.02*v[i];
                if (func.calculate(x[i]) < func.calculate(p[i]))
                {
                    p[i] = x[i];
                    if (func.calculate(p[i]) < func.calculate(g))
                    {
                        g = p[i];
                    }
                }
            }
            iter++;
        }

        public double Answer()
        {
            return g;
        }

    }
    public class PSOModel
    {
        PSO pso;
        Timer timer;
        public PSOModel()
        {
            timer = new Timer();
            timer.Enabled = false;
            timer.Interval = 10;

            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            double[] points = pso.GetPoints();
            int n = 0;
            foreach (double point in points)
            {
                if (Math.Round(point, 2) == Math.Round(pso.Answer(), 2)) n++;
            }
            if (pso.iter > 1000 || (double)n / points.Length > 0.7)
            {
                timer.Stop();
                AnswerForObservers();
                return;
            }

            pso.Update();
            UpdateObservers();
        }

        public void StartStop()
        {
            if (pso == null)
            {
                MessageBox.Show("Сгенерируйте рой", "Error");
                return;
            }
            timer.Enabled = !timer.Enabled;
        }

        public void SetParam(string RawF, int s, double low, double up)
        {
            Function f = new Function("f(x) = " + RawF);
            pso = new PSO(f, s, low, up);
        }
        
        public double[] GetPoints()
        {
            return pso.GetPoints();
        }

        public Function GetFunction()
        {
            return pso.func;
        }
        
        public int GetIter()
        {
            return pso.iter;
        }



        //-----------------------Работа с наблюдателями------------------------------

        private List<IObserver> listners = new List<IObserver>();

        public void Register(IObserver observer)
        {
            listners.Add(observer);
            //observer.UpdateState();
        }
        public void Deregister(IObserver observer)
        {
            try
            {
                listners.Remove(observer);
            }
            catch (Exception e)
            {
                throw new Exception("Наблюдатель не подписан на обновления!");
            }
        }
        public void UpdateObservers()
        {
            foreach (IObserver observer in listners)
            {
                observer.UpdateState();
            }
        }
        public void AnswerForObservers()
        {
            foreach (IObserver observer in listners)
            {
                observer.Answer(pso.Answer());
            }
        }
    }
}
