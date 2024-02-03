using ThreeAgentsSystem.Agents;
namespace ThreeAgentsSystemTests
{

    [TestClass]
    public class AgentATests
    {
        [TestMethod]
        public void GetMean_AgentA_EmptyList_ReturnsZero()
        {
            var agent = new AgentA();
            var realNumbers = new List<double>() { };
            Assert.AreEqual(0.0, agent.GetMean(realNumbers));
        }

        [TestMethod]
        public void GetMean_AgentA_ListWithRealNumbers_ReturnsCorrectValue()
        {
            var agent = new AgentA();
            var realNumbers = new List<double>() { 3.2, 2.5, 4, 2.0, 10.9};
            Assert.AreEqual(4.52, agent.GetMean(realNumbers));
        }

        [TestMethod]
        public void GetStaircase_AgentA_NValueEqualToZero_ReturnsMessageThatNotifyIncorrectArgumentValue()
        {
            var agent = new AgentA();
            Assert.AreEqual("The value of n does not satisfy the condition of 0 < n < 100", agent.GetStaircase(0));
        }

        [TestMethod]
        public void GetStaircase_AgentA_NValueLessThanZero_ReturnsMessageThatNotifyIncorrectArgumentValue()
        {
            var agent = new AgentA();
            Assert.AreEqual("The value of n does not satisfy the condition of 0 < n < 100", agent.GetStaircase(-1));
        }

        [TestMethod]
        public void GetStaircase_AgentA_NValueGreaterThanOneHundred_ReturnsMessageThatNotifyIncorrectArgumentValue()
        {
            var agent = new AgentA();
            Assert.AreEqual("The value of n does not satisfy the condition of 0 < n < 100", agent.GetStaircase(200));
        }

        [TestMethod]
        public void GetStaircase_AgentA_NValueEqualToOneHundred_ReturnsMessageThatNotifyIncorrectArgumentValue()
        {
            var agent = new AgentA();
            Assert.AreEqual("The value of n does not satisfy the condition of 0 < n < 100", agent.GetStaircase(100));
        }

        [TestMethod]
        public void GetStaircase_AgentA_ReturnsCorrectStringLength()
        {
            var agent = new AgentA();
            int n = 4;
            Assert.AreEqual( (n * n) + n, agent.GetStaircase(n).Length);
        }
    }
}
