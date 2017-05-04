using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFPrism.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {

        #region entry
        private string _entry;
        /// <summary>
        /// PropertyDescription
        /// </summary>
        public string entry
        {
            get { return this._entry; }
            set { this.SetProperty(ref this._entry, value); }
        }
        #endregion

        #region label
        private string _label;
        /// <summary>
        /// PropertyDescription
        /// </summary>
        public string label
        {
            get { return this._label; }
            set { this.SetProperty(ref this._label, value); }
        }
        #endregion

        public DelegateCommand OKCommand { get; set; }


        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainPageViewModel()
        {
            OKCommand = new DelegateCommand(() =>
            {
                label = $"Hello {entry}";
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
