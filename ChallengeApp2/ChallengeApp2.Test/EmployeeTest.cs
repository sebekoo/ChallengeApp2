namespace ChallengeApp2.Test
{
    public class Tests
    {
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            // arrange
            var employee = new Employee("Adam", "qwerty");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(6, statistics.Max);
        }
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            // arrange
            var employee = new Employee("Adam", "qwerty");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(2, statistics.Min);
        }
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAvg()
        {
            // arrange
            var employee = new Employee("Adam", "qwerty");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));
        }
        [Test]
        public void TestOfFloatEqualValue()
        {

            var number1 = 6.37f;
            var number2 = 6.37f;


            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void TestOfCharEqualValue()
        {

            var number3 = 'f';
            var number4 = 'f';


            Assert.AreEqual(number3, number4);
        }
    }
}