

namespace Tyuiu.AvdeevAS.Sprint0.Task2.V0.Test
{
    using Tyuiu.AvdeevAS.Sprint0.Task2.V0.Lib;
    [TestClass]
    public class DataServiceTest
    {

        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "������";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("������, ������", res);
        }

    }
}