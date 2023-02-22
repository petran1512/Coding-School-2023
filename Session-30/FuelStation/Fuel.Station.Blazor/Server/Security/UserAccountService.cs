namespace Fuel.Station.Blazor.Server.Security
{
    public class UserAccountService
    {
        private List<UserAccount> _userAccountList;

        public UserAccountService()
        {
            _userAccountList = new List<UserAccount>
            {
                new UserAccount{ UserName = "manager", Password = "manager", Role = "Manager" },
                new UserAccount{ UserName = "cashier", Password = "cashier", Role = "Cashier" },
                new UserAccount{ UserName = "staff", Password = "staff", Role = "Staff" }
            };
        }

        public UserAccount? GetUserAccountByUserName(string userName)
        {
            return _userAccountList.FirstOrDefault(x => x.UserName == userName);
        }
    }
}
