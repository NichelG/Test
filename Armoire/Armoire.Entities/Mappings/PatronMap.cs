using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;

namespace Armoire.Entities.Mappings
{
    public class PatronMap : ClassMap<Patrons>
    {
        public PatronMap()
        {
            Table("Patrons");
            Id(x => x.Id).Column("patronsID");
            Map(x => x.FirstName).Column("username");
            Map(x => x.LastName).Column("pword");
            Map(x => x.Email).Column("email");
            Map(x => x.Address).Column("address").Nullable();
            Map(x => x.City).Column("city").Nullable();
            Map(x => x.Zip).Column("zip").Nullable();
            Map(x => x.Phone).Column("phone").Nullable();
            Map(x => x.Image).Column("picture").Nullable();
            Map(x => x.AccountStatus).Column("accountStatus");
            Map(x => x.dateCreated).Column("dateCreated");
            Map(x => x.lastUpdated).Column("lastUpdated").Nullable();

            References(x => x.AccountType)
                .Column("TypeID")
                .ForeignKey("TypeID");
        }


    }
}
