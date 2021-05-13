using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSwarmOptimization
{
    public class ControllerConsole
    {
        private ViewConsole view;
        private PSOModel model;

        public ControllerConsole(ViewConsole view, PSOModel model)
        {
            this.model = model;
            this.view = view;
        }
    }
}
