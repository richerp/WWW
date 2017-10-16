using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WWW.Models
{
    public class OrgUserRelation
    {
        [Key]
        public int Id { get; set; }

        public int OrgId { get; set; }
        [ForeignKey(nameof(OrgId))]
        public Organization Org { get; set; }

        public string UserID { get; set; }
        [ForeignKey(nameof(UserID))]
        public WWWUser User { get; set; }

        public RelationType Type { get; set; }

        public DateTime JoinTime { get; set; }
    }
}
