using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFNaviPara.ViewModels
{
    public class NextPageViewModel : BindableBase, INavigationAware
    {

        #region MyLabel
        private string _MyLabel;
        /// <summary>
        /// PropertyDescription
        /// </summary>
        public string MyLabel
        {
            get { return this._MyLabel; }
            set { this.SetProperty(ref this._MyLabel, value); }
        }
        #endregion

        public NextPageViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("Message"))
            {
                var fooMessage = parameters["Message"] as string;
                MyLabel = "Hello " + fooMessage;
            }
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}
