using Tyuiu.RubanovEO.Sprint4.Task7.V2.Lib;

namespace Tyuiu.RubanovEO.Sprint4.Task7.V2.Test
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
            Assert.That(ds.Calculate(3, 4, "123456789012"), Is.EqualTo(26));
        }
    }
}