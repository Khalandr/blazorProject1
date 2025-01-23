namespace EventEaseApp.Services
{
    public class UserSessionService
    {
        public bool IsLoggedIn { get; private set; }
        public string UserName { get; private set; }

        public void Login(string username)
        {
            IsLoggedIn = true;
            UserName = username;
        }

        public void Logout()
        {
            IsLoggedIn = false;
            UserName = null;
        }
    }
}
