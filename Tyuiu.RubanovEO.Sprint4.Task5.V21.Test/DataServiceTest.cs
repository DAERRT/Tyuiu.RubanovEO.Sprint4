using Tyuiu.RubanovEO.Sprint4.Task5.V21.Lib;

namespace Tyuiu.RubanovEO.Sprint4.Task5.V21.Test
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
            Assert.That(ds.Calculate(new int[,] { {2,2,2},{2,2,2} }), Is.EqualTo(new int[,] { { 1, 1, 1 }, { 1, 1, 1 } }));
        }
    }
}