using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WWW.Models
{
    public class OrgCourse : PersonalCourse
    {
        public int OrgId { get; set; }
        [ForeignKey(nameof(OrgId))]
        public Organization BelongingOrg { get; set; }
    }
}
