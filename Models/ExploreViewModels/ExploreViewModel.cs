using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WWW.Models.ExploreViewModels
{
    public class ExploreViewModel
    {
        public int ActivePanle { get; set; }

        [Obsolete(error: true, message: "This method is only for framework!")]
        public ExploreViewModel() { }
        public ExploreViewModel(int ActivePanle)
        {
            this.ActivePanle = ActivePanle;
        }
    }
}
