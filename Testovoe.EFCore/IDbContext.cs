using Microsoft.EntityFrameworkCore;
using Testovoe.Domain;


namespace Testovoe.EFCore
{
    public interface IDbContext
    {
        public ICollection<User> Users { get; set; }
    }
}
