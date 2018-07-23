using Armoire.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Armoire.Services.Interfaces
{
    public interface IUserService
    {
        void Register(RegisterViewModel vm);
    }
}
