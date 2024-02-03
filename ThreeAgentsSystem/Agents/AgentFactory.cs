using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeAgentsSystem.Agents
{
    public class AgentFactory
    {

        public static Agent Creator(string agentName)
        {
            switch (agentName)
            {
                case "AGENTE_A":
                    return new AgentA();
                case "AGENTE_B":
                    return new AgentB();
                case "AGENTE_C":
                    return new AgentC();
                    default: return new AgentA();
            }
        }
    }
}
