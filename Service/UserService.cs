using OS7.Data;

namespace OS7.Service
{
    internal class UserService
    {
        private List<User> users;

        public UserService(List<User> users)
        {
            this.users = users;
        }
        public void Service()
        {
            Console.Clear();
            foreach (User user in users)
            {
                user.Execute();
                Console.WriteLine();
            }
        }
    }
}
