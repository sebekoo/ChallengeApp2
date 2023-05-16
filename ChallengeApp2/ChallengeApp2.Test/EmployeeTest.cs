namespace ChallengeApp2.Test
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollect_ShouldReturnCorrectResult()
        {
            // arrange
            var employee = new Employee("Adam", "qwerty");
            employee.AddScore(1);
            employee.AddScore(10);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(11, result);
        }
    }
}