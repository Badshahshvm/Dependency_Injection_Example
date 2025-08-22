namespace Dependency_Injection_Example.Service
{
    public class UserService : IUserService
    {
        public string GetUserName()
        {
            return "This is UserService";
        }

        public int GetUserId()
        {
            return 101;
        }

        public string GetUserRole()
        {
            return "Admin";
        }
    }
}
