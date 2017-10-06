using POCPrism.Helpers;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POCPrism.ViewModels
{
    public class FollowingViewModel : BindableBase
    {
        private List<Following> _following;
        public List<Following> Following
        {
            get { return _following; }
            set { SetProperty(ref _following, value); }
        }

        public FollowingViewModel()
        {
            this.Following = new List<Following> {
                new Following { Image = "KirkProfile.png", Name = "Following 1"},
                new Following { Image = "KirkProfile.png", Name = "Following 2"},
                new Following { Image = "KirkProfile.png", Name = "Following 3"},
                new Following { Image = "KirkProfile.png", Name = "Following 4"},
                new Following { Image = "KirkProfile.png", Name = "Following 5"},
                new Following { Image = "KirkProfile.png", Name = "Following 6"},
                new Following { Image = "KirkProfile.png", Name = "Following 7"},
                new Following { Image = "KirkProfile.png", Name = "Following 8"},
                new Following { Image = "KirkProfile.png", Name = "Following 9"},
            };
        }
    }
}
