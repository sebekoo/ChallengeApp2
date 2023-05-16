namespace ChallengeApp2
{
    public class User
    {
        List<int> Score = new();

        public User(string login)
        {
            Login = login;
        }
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public string Login { get; private set; }
        public string Password { get; private set; }
        public int Result { get { return this.Score.Sum(); } }

        public void AddScore(int number)
        {
            Score.Add(number);
        }
    }
}
