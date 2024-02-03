using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeAgentsSystem.Agents
{
    public abstract class Agent
    {
        public abstract double? GetMean(List<double> realNumbers);

        public abstract string GetStaircase(int n);
    }
}
