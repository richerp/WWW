using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WWW.Models.ExploreViewModels
{
    public class OrganizationsViewModel : ExploreViewModel
    {
        public IEnumerable<Organization> Organizations { get; set; }

        public OrganizationsViewModel(int ActivePanel, IEnumerable<Organization> HomeView) : base(ActivePanel)
        {
            this.Organizations = HomeView;
        }
    }
}