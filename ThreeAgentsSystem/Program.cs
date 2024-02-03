using ThreeAgentsSystem.Agents;

Console.WriteLine("Bienvenido!");

Console.WriteLine("Por favor seleccione uno de los tres agentes (AGENTE_A, AGENTE_B, AGENTE_C) introduciendo a continuación uno de los nombres que está entre paréntesis: ");

string agentNameSelection = Console.ReadLine();

var realNumbersList = new List<double>() { 1.5, 2.5, 3.5, 5.5 };

var n = 12;

Agent agentSelected = AgentFactory.Creator(agentNameSelection.ToUpper());

var media = agentSelected.GetMean(realNumbersList);

var str = agentSelected.GetStaircase(n);

Console.WriteLine(media.ToString());

Console.WriteLine(str.ToString());
