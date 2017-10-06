using POCPrism.Helpers;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POCPrism.ViewModels
{
    public class FollowersViewModel : BindableBase
    {

        private List<Followers> _followers;
        public List<Followers> Followers
        {
            get { return _followers; }
            set { SetProperty(ref _followers, value); }
        }

        public FollowersViewModel()
        {
            this.Followers = new List<Followers>();

            for (int i = 0; i < 50; i++)
            {
                this.Followers.Add(new Helpers.Followers
                {
                    Image = "KirkProfile.png",
                    Name = "Following " + i + 1
                });
            }            
        }
    }
}
