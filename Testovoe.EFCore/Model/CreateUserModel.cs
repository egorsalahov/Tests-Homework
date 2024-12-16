using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testovoe.EFCore.Model
{
    public record CreateUserModel (string Login, string Password, string Name, DateOnly Birthday)
    {
    }
}
