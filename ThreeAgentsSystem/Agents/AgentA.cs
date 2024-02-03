using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeAgentsSystem.Agents
{
    public class AgentA : Agent
    {
        public override double? GetMean(List<double> realNumbers)
        {
            var mean = 0.0;

            if (realNumbers.Count > 0)
            {
                mean = Math.Round(realNumbers.Sum() / realNumbers.Count, 2);
            }

            return mean;
        }

        public override string GetStaircase(int n)
        {
            if (n <= 0 || n >= 100) return "The value of n does not satisfy the condition of 0 < n < 100";

            string staircaseFig = "";

            int hashCount = n - 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j < hashCount)
                    {
                        staircaseFig += " ";
                    }
                    else
                    {
                        staircaseFig += "#";
                    }
                }

                hashCount--;
                staircaseFig += "\n";
            }
            return staircaseFig;
        }
    }
}
