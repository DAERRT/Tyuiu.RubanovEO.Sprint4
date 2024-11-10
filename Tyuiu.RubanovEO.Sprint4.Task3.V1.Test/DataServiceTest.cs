using Tyuiu.RubanovEO.Sprint4.Task3.V1.Lib;

namespace Tyuiu.RubanovEO.Sprint4.Task3.V1.Test
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
            Assert.That(ds.Calculate(new int[5,5] {{3, 4, 3, 4, 1}, 
                                                   {8, 1, 6, 6, 9}, 
                                                   {9, 8, 5, 1, 3},
                                                   {1, 8, 7, 1, 2},
                                                   {9, 9, 7, 5, 6}}), Is.EqualTo(21));
        }
    }
}