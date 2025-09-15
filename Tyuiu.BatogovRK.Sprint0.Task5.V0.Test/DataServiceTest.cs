
using Tyuiu.BatogovRK.Sprint0.Task5.V0.Lib;

namespace Tyuiu.BatogovRK.Sprint0.Task5.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}