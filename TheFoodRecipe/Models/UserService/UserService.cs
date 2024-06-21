using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using TheMealDB.API.Client; 

namespace TheFoodRecipe.Models.UserService
{
    public class UserService
    {
        public class UserService
        {
            TheMealDBClient client;

            public UserService()
            {
                client = new TheMealDBClient("https://www.themealdb.com/");
            }

            public async Task<bool> IsUserExists(string uname)
            {
                var user = (await client.Child("Users")
                    .OnceAsync<User>()).Where(u => u.Object.Username == uname).FirstOrDefault();

                return (user != null);
            }

            public async Task<bool> RegisterUser(string uname, string passwd)
            {
                if (await IsUserExists(uname) == false)
                {
                    await client.Child("Users")
                        .PostAsync(new User()
                        {
                            Username = uname,
                            Password = passwd
                        });
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public async Task<bool> LoginUser(string uname, string passwd)
            {
                var user = (await client.Child("Users")
                    .OnceAsync<User>()).Where(u => u.Object.Username == uname)
                    .Where(U => U.Object.Password == passwd).FirstOrDefault();

                return (user != null);
            }
        }
    }
}
