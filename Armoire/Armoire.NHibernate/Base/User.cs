using System;
using System.Collections.Generic;
using System.Text;

namespace Armoire.NHibernate.Base
{
    public abstract class User
    {
        public virtual string username { get; set; }
        public virtual string password { get; set; }
    }
    }
}
