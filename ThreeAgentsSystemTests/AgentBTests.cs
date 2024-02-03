using ThreeAgentsSystem.Agents;
namespace ThreeAgentsSystemTests
{

    [TestClass]
    public class AgentBTests
    {
        [TestMethod]
        public void GetMean_AgentB_EmptyList_ReturnsNaN()
        {
            var agent = new AgentB();
            var realNumbers = new List<double>() { };
            Assert.AreEqual(double.NaN, agent.GetMean(realNumbers));
        }

        [TestMethod]
        public void GetMean_AgentB_ListWithRealNumbers_ReturnsCorrectValue()
        {
            var agent = new AgentB();
            var realNumbers = new List<double>() { 3.2, 2.5, 4, 2.0, 10.9 };
            Assert.AreEqual(3.22, agent.GetMean(realNumbers));
        }

        [TestMethod]
        public void GetStaircase_AgentB_NValueEqualToZero_ReturnsMessageThatNotifyIncorrectArgumentValue()
        {
            var agent = new AgentB();
            Assert.AreEqual("The value of n does not satisfy the condition of 0 < n < 100", agent.GetStaircase(0));
        }

        [TestMethod]
        public void GetStaircase_AgentB_NValueLessThanZero_ReturnsMessageThatNotifyIncorrectArgumentValue()
        {
            var agent = new AgentB();
            Assert.AreEqual("The value of n does not satisfy the condition of 0 < n < 100", agent.GetStaircase(-1));
        }

        [TestMethod]
        public void GetStaircase_AgentB_NValueGreaterThanOneHundred_ReturnsMessageThatNotifyIncorrectArgumentValue()
        {
            var agent = new AgentB();
            Assert.AreEqual("The value of n does not satisfy the condition of 0 < n < 100", agent.GetStaircase(200));
        }

        [TestMethod]
        public void GetStaircase_AgentB_NValueEqualToOneHundred_ReturnsMessageThatNotifyIncorrectArgumentValue()
        {
            var agent = new AgentB();
            Assert.AreEqual("The value of n does not satisfy the condition of 0 < n < 100", agent.GetStaircase(100));
        }

        [TestMethod]
        public void GetStaircase_AgentB_ReturnsCorrectStringLength()
        {
            var agent = new AgentB();
            int n = 4;
            Assert.AreEqual((n * n) + n, agent.GetStaircase(n).Length);
        }
    }
}