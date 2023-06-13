using MinimalJwt.Models;

namespace MinimalJwt.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new()
            {
                UserName = "EmanuelRa",  
                Email = "emanuelrr55@gmail.com",
                Password = "emra" ,
                GivenName = "Emanuel", 
                Surname = "Ramirez",   
                Role = "Administrator",
            },

            new()
            {
                UserName = "luke95",
                Email = "luke98@gmail.com",
                Password = "12345" ,
                GivenName = "Luke",
                Surname = "Rogers",
                Role = "Standard",
            }

        };
    }
}
