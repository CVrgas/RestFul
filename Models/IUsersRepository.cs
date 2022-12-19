namespace NetApi.Models
{
    public interface IUsersRepository
    {
        User AddUser(User user);
        User GetUser(int id);
        IEnumerable<User> GetUsers();
        User UpdateUser(User user);
        User DeleteUser(int id);
    }
}