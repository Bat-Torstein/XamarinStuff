using MyApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace MyApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        internal readonly IRestService restService;
        internal readonly Page page;
        public BaseViewModel(Page page)
        {
            this.page = page;
            restService = DependencyService.Get<IRestService>();
        }

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
            {
                return;
            }

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
