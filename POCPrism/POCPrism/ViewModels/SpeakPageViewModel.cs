using Prism.Commands;
using Prism.Mvvm;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POCPrism.ViewModels
{
    public class SpeakPageViewModel : BindableBase
    {
        IPageDialogService _dialogService;
        private string _textToSay = "Hello Prism";
        public string TextToSay
        {
            get { return _textToSay; }
            set { SetProperty(ref _textToSay, value); }
        }

        public DelegateCommand SpeakCommand { get; set; }

        public SpeakPageViewModel(IPageDialogService dialogService)
        {
            this._dialogService = dialogService;
            SpeakCommand = new DelegateCommand(Speak);
        }        

        private void Speak()
        {
            this._dialogService.DisplayAlertAsync("Alert", "You've said " + this.TextToSay, "Ok");
        }
    }
}
