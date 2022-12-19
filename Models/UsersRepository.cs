namespace NetApi.Models
{
    class UserRepository : IUsersRepository
    {
        public List<User> users = new List<User>();
        private int _newId = 1;

        public UserRepository()
        {
            AddUser( new User {firstName= "Pete", lastName="Rodriguez", age=27} );
            AddUser( new User {firstName= "Juan", lastName="Soto", age=21} );
        }

        public User AddUser(User user)
        {
            // if user is null throw a Exception
            if(user == null) throw new ArgumentNullException("user");
            //set user id "server side"
            user.id = _newId++;
            //add user
            users.Add(user);
            return user;
        }

        public User DeleteUser(int id)
        {
            //get user
            User user = GetUser(id);
            //remove data
            users.Remove(user);
            return user;
        }

        public User GetUser(int userid)
        {
            //find user in user list
            User user = users.Find(x => x.id == userid);
            //if not null return user
            if( user != null)
            {
                return user;
            }
            //if null throw a Exception
            throw new ArgumentNullException("user");
        }

        public IEnumerable<User> GetUsers()
        {
            //return all users
            return users;
        }

        public User UpdateUser(User user)
        {
            //Get old user 
            User NotUpdated = GetUser(user.id);
            
            //Update user data
            NotUpdated.firstName = user.firstName;
            NotUpdated.lastName = user.lastName;
            NotUpdated.age = user.age;

            return user;
        }
    }
}