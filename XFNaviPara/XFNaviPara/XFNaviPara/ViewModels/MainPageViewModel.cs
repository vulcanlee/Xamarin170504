using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFNaviPara.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        #region MyEntry
        private string _MyEntry;
        /// <summary>
        /// PropertyDescription
        /// </summary>
        public string MyEntry
        {
            get { return this._MyEntry; }
            set { this.SetProperty(ref this._MyEntry, value); }
        }
        #endregion


        public DelegateCommand NextPageCommand { get; set; }

        private readonly INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;
            NextPageCommand = new DelegateCommand(async () =>
            {

               await _navigationService.NavigateAsync("NextPage?Message="+ MyEntry);
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
