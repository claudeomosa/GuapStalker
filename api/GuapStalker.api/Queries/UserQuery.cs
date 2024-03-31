using database.Models;

namespace api.Queries
{
    public class UserQuery
    {
        public User GetUser() =>
            new User
            {
                Username = "test",
            };
    }
}
