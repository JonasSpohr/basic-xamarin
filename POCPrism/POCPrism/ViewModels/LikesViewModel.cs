using POCPrism.Helpers;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace POCPrism.ViewModels
{
    public class LikesViewModel : BindableBase
    {

        private List<Likes> _likes;
        public List<Likes> Likes
        {
            get { return _likes; }
            set { SetProperty(ref _likes, value); }
        }

        public LikesViewModel()
        {
            this.Likes = new List<Likes> {
                new Likes { Image = "KirkProfile.png", Name = "My Like 1"},
                new Likes { Image = "KirkProfile.png", Name = "My Like 2"},
                new Likes { Image = "KirkProfile.png", Name = "My Like 3"}
            };            
        }
    }
}
