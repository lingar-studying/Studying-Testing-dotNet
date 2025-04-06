using StudyingTesting.poker_hands.game_area;

namespace StudyingTesting.users
{
    public class User
    {
        private string username;
        private List<User_Role> roles;

        private List<Table> tables = new List<Table>();

        public List<User_Role> Roles { get => roles; set => roles = value; }
        public string Username { get => username; set => username = value; }

        public void AddTable()
        {

            tables.Add(new Table());
        }
    }
}
