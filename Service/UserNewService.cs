namespace Dependency_Injection_Example.Service
{
    public class UserServiceNew:IUserService
    {

        public string GetUserName()
        {
            return "This is Updated UserService";
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
