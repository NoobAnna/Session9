using session9git.Model;

namespace session9git.Repository
{
    public class UserRepository
    {
        List<User> users;
        public UserRepository()
        {
            users = new List<User>()
            {
                new User(){Id=1,Name="GJH"},
                new User(){Id=2,Name="GJH"},
            };

        }
        public List<User> GetAllUsers()
        {
            return users;


        }
    }
}

