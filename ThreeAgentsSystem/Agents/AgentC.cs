using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeAgentsSystem.Agents
{
    public class AgentC : Agent
    {
        public override double? GetMean(List<double> realNumbers)
        {
            double median = 0.0;

            if (realNumbers.Count == 0) return double.NaN;

            List<double> realNumbersSorted = realNumbers.Order().ToList();

            if (realNumbersSorted.Count % 2 == 0)
            {
                median = (realNumbersSorted[(realNumbersSorted.Count / 2) - 1] + realNumbersSorted[realNumbersSorted.Count / 2]) / 2;
            }
            else
            {
                median = realNumbersSorted[(realNumbersSorted.Count / 2)];
            }

            return median;
        }

        public override string GetStaircase(int n)
        {
            if (n <= 0 || n >= 100) return "The value of n does not satisfy the condition of 0 < n < 100";

            string staircaseFig = "";
            int fullLength = n + (2 * (n - 1));
            int start = n - 1;
            int end = start + n;

            for (int i = 0; i < (n * 2) - 1; i++)
            {
                for (int j = 0; j < fullLength; j++)
                {
                    if (j >= start && j < end)
                    {
                        staircaseFig += "#";
                    }
                    else
                    {
                        staircaseFig += " ";
                    }
                }

                if (i < n - 1)
                {
                    start -= 1;
                    end += 1;
                }
                else
                {
                    start += 1;
                    end -= 1;
                }

                staircaseFig += "\n";
            }
            return staircaseFig;
        }
    }
}
