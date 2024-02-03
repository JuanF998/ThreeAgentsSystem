using ThreeAgentsSystem.Agents;
namespace ThreeAgentsSystemTests
{

    [TestClass]
    public class AgentCTests
    {
        [TestMethod]
        public void GetMean_AgentC_EmptyList_ReturnsNaN()
        {
            var agent = new AgentC();
            var realNumbers = new List<double>() { };
            Assert.AreEqual(double.NaN, agent.GetMean(realNumbers));
        }

        [TestMethod]
        public void GetMean_AgentC_OddListWithRealNumbers_ReturnsCorrectValue()
        {
            var agent = new AgentC();
            var realNumbers = new List<double>() { 3.2, 2.5, 4, 2.0, 10.9 };
            Assert.AreEqual(3.2, agent.GetMean(realNumbers));
        }

        [TestMethod]
        public void GetMean_AgentC_EvenListWithRealNumbers_ReturnsCorrectValue()
        {
            var agent = new AgentC();
            var realNumbers = new List<double>() { 3.2, 2.5, 4, 2.0, 10.9, 1 };
            Assert.AreEqual(2.85, agent.GetMean(realNumbers));
        }

        [TestMethod]
        public void GetStaircase_AgentC_NValueEqualToZero_ReturnsMessageThatNotifyIncorrectArgumentValue()
        {
            var agent = new AgentC();
            Assert.AreEqual("The value of n does not satisfy the condition of 0 < n < 100", agent.GetStaircase(0));
        }

        [TestMethod]
        public void GetStaircase_AgentC_NValueLessThanZero_ReturnsMessageThatNotifyIncorrectArgumentValue()
        {
            var agent = new AgentC();
            Assert.AreEqual("The value of n does not satisfy the condition of 0 < n < 100", agent.GetStaircase(-1));
        }

        [TestMethod]
        public void GetStaircase_AgentC_NValueGreaterThanOneHundred_ReturnsMessageThatNotifyIncorrectArgumentValue()
        {
            var agent = new AgentC();
            Assert.AreEqual("The value of n does not satisfy the condition of 0 < n < 100", agent.GetStaircase(200));
        }

        [TestMethod]
        public void GetStaircase_AgentC_NValueEqualToOneHundred_ReturnsMessageThatNotifyIncorrectArgumentValue()
        {
            var agent = new AgentC();
            Assert.AreEqual("The value of n does not satisfy the condition of 0 < n < 100", agent.GetStaircase(100));
        }

        [TestMethod]
        public void GetStaircase_AgentC_ReturnsCorrectStringLength()
        {
            var agent = new AgentC();
            int n = 4;
            int rows = (n * 2) - 1;
            int columns = n + (2 * (n - 1));
            Assert.AreEqual( (rows * columns) + rows, agent.GetStaircase(n).Length);
        }
    }
}