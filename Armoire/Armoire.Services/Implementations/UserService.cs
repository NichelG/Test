using Armoire.Entities;
using System;

namespace Armoire.Services
{
    public class UserService: IUserService
    {
        private readonly ISession _nhSession;

        public UserService(ISession nhSession)
        {
            _nhSession = nhSession;
        }

        public void Register(RegisterViewModel vm)
        {
            var newUser = new Patrons()
            {
                FirstName = viewModel.FirstnameRF,
                LastName = viewModel.LastnameRF,
                Username = viewModel.UsernameRF,
                Password = viewModel.PasswordRF,
                AccountStatus = "Active",
                AccountType = 2,
                Image = viewModel.ImageRF,
                dateCreated = DateTime.UtcNow,
                lastUpdated = DateTime.UtcNow

            };

            //upload data to database
        }
    }
}
