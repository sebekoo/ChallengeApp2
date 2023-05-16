namespace ChallengeApp2.Test
{
    public class TypeTests
    {
        [Test]
        public void TEST()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");


            // act
            

            // assert
            Assert.AreNotEqual(user1, user2);
        }
        
        [Test]
        public void TEST2()
        {
            // arrange
            int number1 = 1;
            int number2 = 1;


            // act


            // assert
            Assert.AreEqual(number1, number2);
        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
