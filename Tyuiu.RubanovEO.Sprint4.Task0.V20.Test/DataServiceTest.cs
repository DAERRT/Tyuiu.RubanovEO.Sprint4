using Tyuiu.RubanovEO.Sprint4.Task0.V20.Lib;

namespace Tyuiu.RubanovEO.Sprint4.Task0.V20.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService dataService = new DataService();
            Assert.That(dataService.GetMultEvenArrEl(new int[] { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 }), Is.EqualTo(24576));
        }
    }
}