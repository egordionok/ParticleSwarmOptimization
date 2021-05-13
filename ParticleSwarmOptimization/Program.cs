using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace ParticleSwarmOptimization
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            PSOModel model = new PSOModel();

            ViewConsole console = new ViewConsole(model);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View2D(model));
        }
    }
}
