using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WWW.Models
{
    public class Organization
    {
        [Key]
        public int OrgId { get; set; }
        public string OrgName { get; set; }

        [InverseProperty(nameof(OrgUserRelation.Org))]
        public List<OrgUserRelation> Users { get; set; }

        [InverseProperty(nameof(OrgProduct.BelongingOrg))]
        public List<OrgProduct> Products { get; set; }

        [InverseProperty(nameof(OrgCourse.BelongingOrg))]
        public List<OrgCourse> Courses { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
