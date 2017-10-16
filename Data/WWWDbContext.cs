using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WWW.Models;

namespace WWW.Data
{
    public class WWWDbContext : IdentityDbContext<WWWUser>
    {
        public WWWDbContext(DbContextOptions<WWWDbContext> options) : base(options) { }

        public DbSet<Organization> Orgs { get; set; }
        public DbSet<OrgUserRelation> OURelations { get; set; }

        public DbSet<OrgProduct> OrgProducts { get; set; }
        public DbSet<PersonalProduct> PersonalProducts { get; set; }
    }
}
