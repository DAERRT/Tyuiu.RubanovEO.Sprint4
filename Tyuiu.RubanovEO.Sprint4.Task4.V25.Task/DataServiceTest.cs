using Tyuiu.RubanovEO.Sprint4.Task4.V25.Lib;

namespace Tyuiu.RubanovEO.Sprint4.Task4.V25.Task
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
            DataService ds = new DataService();
            Assert.That(ds.Calculate(new int[5, 5] {{3, 2, 4, 4, 4 },{2, 6, 6, 3, 2 },{4, 2, 5, 5, 3 },{5, 5, 6, 4, 3 },{2, 6, 5, 6, 2 }}), Is.EqualTo(24));
        }
    }
}