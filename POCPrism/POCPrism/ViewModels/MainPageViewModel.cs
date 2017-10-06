using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POCPrism.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private INavigationService _navigationService;
        private IPageDialogService _dialogService;

        public DelegateCommand NavigateToLikesPageCommand { get; private set; }
        public DelegateCommand NavigateToFollowingPageCommand { get; private set; }
        public DelegateCommand NavigateToFollowersPageCommand { get; private set; }
        public DelegateCommand FollowCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService, IPageDialogService dialogService)
        {
            this._navigationService = navigationService;
            this._dialogService = dialogService;

            NavigateToLikesPageCommand = new DelegateCommand(NavigateToLikesPage);
            NavigateToFollowersPageCommand = new DelegateCommand(NavigateToFollowersPage);
            NavigateToFollowingPageCommand = new DelegateCommand(NavigateToFollowingPage);

            FollowCommand = new DelegateCommand(Follow);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        private void NavigateToLikesPage()
        {
            _navigationService.NavigateAsync("Likes");
        }

        private void NavigateToFollowersPage()
        {
            _navigationService.NavigateAsync("Followers");
        }

        private void NavigateToFollowingPage()
        {
            _navigationService.NavigateAsync("Following");
        }

        private void Follow()
        {
            this._dialogService.DisplayAlertAsync("Alert", "Sorry. I can't let you follow this person.", "Ok");
        }
    }
}
