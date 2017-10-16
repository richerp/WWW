using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WWW.Models.CreateViewModels
{
    public class CreateOrgViewModel
    {
        public CreateOrgViewModel()
        {
            
        }
        public string OrgName { get; set; }
        public string Description { get; set; }
        public string BillingEmail { get; set; }
    }
}
