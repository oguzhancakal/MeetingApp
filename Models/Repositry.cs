namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new ();

        static Repository()
        {
            _users.Add( new UserInfo (){Id = 1, Name = "Oğuzhan", Email="oguzhan@gmail.com",Phone = "111111", WillAttend = true});
            _users.Add( new UserInfo (){Id = 2, Name = "Sevim", Email="Sevim@gmail.com",Phone = "222222", WillAttend = true});
            _users.Add( new UserInfo (){Id = 3, Name = "Cenk", Email="Cenk@gmail.com",Phone = "333333", WillAttend = false});
        }
        public static List<UserInfo> Users {
            get{
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}