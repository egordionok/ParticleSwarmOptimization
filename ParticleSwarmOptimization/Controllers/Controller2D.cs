using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSwarmOptimization
{
    public class Controller2D
    {
        private View2D view;
        private PSOModel model;

        public Controller2D(View2D view, PSOModel model)
        {
            this.model = model;
            this.view = view;
        }
        public void StartStop()
        {
            model.StartStop();
        }
        public void SetParam(string f, int s, double low, double up)
        {
            model.SetParam(f, s, low, up);
        }
    }
}
