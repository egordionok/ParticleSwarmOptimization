using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSwarmOptimization
{
    public interface IObserver
    {
        void UpdateState();
        void Answer(double ans);
    }
}
