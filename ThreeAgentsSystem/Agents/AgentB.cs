using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeAgentsSystem.Agents
{
    public class AgentB : Agent
    {
        public override double? GetMean(List<double> realNumbers)
        {
            double inverseSum = 0.0;

            foreach (double realNumber in realNumbers)
            {
                inverseSum += 1 / realNumber;
            }

            double harmonicMean = realNumbers.Count / inverseSum;

            return Math.Round(harmonicMean, 2);
        }

        public override string GetStaircase(int n)
        {
            if (n <= 0 || n >= 100) return "The value of n does not satisfy the condition of 0 < n < 100";

            string staircaseFig = "";

            int hashCount = 0;

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
                hashCount++;
                staircaseFig += "\n";
            }
            return staircaseFig;
        }
    }
}