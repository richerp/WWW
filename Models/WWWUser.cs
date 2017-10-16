using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AiursoftBase.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace WWW.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class WWWUser : AiurUserBase
    {
        [InverseProperty(nameof(OrgUserRelation.User))]
        public List<OrgUserRelation> Orgs { get; set; }

        [InverseProperty(nameof(PersonalCourse.Creator))]
        public List<PersonalCourse> MyCourses { get; set; }

        [InverseProperty(nameof(PersonalProduct.Creator))]
        public List<PersonalProduct> MyProducts { get; set; }
    }
}
