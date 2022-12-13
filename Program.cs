using OS7.Data;
using OS7.Service;

namespace OS7
{
    class Programm 
    {
        public static void Main(string[] args)
        {
            UserService userService = new UserService(
                new List<User>()
                {
                    new Student(),
                    new Student(),
                    new Teacher()
                }
            );
            userService.Service();
        }
    }
}