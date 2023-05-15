namespace ChallengeApp2
{
    public class Employee
    {
        List<int> score = new();
        public Employee(string login, string password) { Login = login; Password = password; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public int Result { get { return score.Sum(); } }

        public void AddScore(int number)
        {
            score.Add(number);
        }
    }
}
