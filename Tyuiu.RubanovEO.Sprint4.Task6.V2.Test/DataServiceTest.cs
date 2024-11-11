using Tyuiu.RubanovEO.Sprint4.Task6.V2.Lib;

namespace Tyuiu.RubanovEO.Sprint4.Task6.V2.Test
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
            Assert.That(ds.Calculate(["Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый"]), Is.EqualTo(new string[] {"Черный", "Зеленый", "Красный", "Желтый", "Фиолетовый"}));
        }
    }
}