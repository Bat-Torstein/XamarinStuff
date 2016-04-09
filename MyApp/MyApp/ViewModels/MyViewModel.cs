using Xamarin.Forms;
using MyApp.Models;
using System.Windows.Input;
using System.Threading.Tasks;
using System;
using System.Diagnostics;

namespace MyApp.ViewModels
{
    public class MyViewModel : BaseViewModel
    {
        MyModel model;

        public MyViewModel(Page page) : base(page)
        {
        }

        Command refreshCommand;

        public string Name { get { return model != null ? model.Name : string.Empty; } }
        public string Id { get; set; }

        public ICommand RefreshCommand
        {
            get { return refreshCommand ?? (refreshCommand = new Command(async () => await ExecuteRefreshCommand(Id))); }
        }

        public async Task ExecuteRefreshCommand(string id)
        {
            try
            {
                var freshItem = await restService.GetItem(id);
                model = freshItem;
                OnPropertyChanged(string.Empty);
            }
            catch (Exception ex)
            {
                //Console.Log("oh noes: " + ex.Message);
            }
        }
    }
}
