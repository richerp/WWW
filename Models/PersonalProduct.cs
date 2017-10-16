using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WWW.Models
{
    public class PersonalProduct
    {
        [Key]
        public int ProductId { get; set; }
        public string Discriminator { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }

        public string CreatorId { get; set; }
        [ForeignKey(nameof(CreatorId))]
        public WWWUser Creator { get; set; }
    }
}
