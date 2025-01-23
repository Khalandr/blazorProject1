using Blazored.LocalStorage;
using System.Threading.Tasks;

namespace EventEaseApp.Services
{
    public class UserSessionService
    {
        private readonly ILocalStorageService _localStorage;

        public bool IsLoggedIn { get; private set; }
        public string UserName { get; private set; }

        public UserSessionService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task InitializeAsync()
        {
            // Load state from local storage
            IsLoggedIn = await _localStorage.GetItemAsync<bool>("IsLoggedIn");
            UserName = await _localStorage.GetItemAsync<string>("UserName");
        }

        public async Task Login(string username)
        {
            IsLoggedIn = true;
            UserName = username;

            // Save state to local storage
            await _localStorage.SetItemAsync("IsLoggedIn", IsLoggedIn);
            await _localStorage.SetItemAsync("UserName", UserName);
        }

        public async Task Logout()
        {
            IsLoggedIn = false;
            UserName = null;

            // Clear state in local storage
            await _localStorage.RemoveItemAsync("IsLoggedIn");
            await _localStorage.RemoveItemAsync("UserName");
        }
    }
}
