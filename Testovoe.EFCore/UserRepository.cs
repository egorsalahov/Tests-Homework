using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testovoe.Domain;
using Testovoe.EFCore.Model;


namespace Testovoe.EFCore
{
    public interface IUserRepository
    {
        User Create(CreateUserModel createUserModel);
    }

    public class UserRepository(IDbContext _dbContext) : IUserRepository
    {
        public User Create(CreateUserModel createUserModel)
        {
            if (string.IsNullOrEmpty(createUserModel.Login))
            {
                throw new Exception("Логин должен быть заполнен");
            }
            User user = new User
            {
                Login = createUserModel.Login,
                Name = createUserModel.Name,
                Password = createUserModel.Password,
                Birthday = createUserModel.Birthday
            };

            _dbContext.Users.Add(user);

            return user;

        }
    }
}
