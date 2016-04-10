using System;
using MyApp.ViewModels;
using Xamarin.Forms;

namespace MyApp.Views
{
	public partial class MyView : ContentPage
	{
        MyViewModel viewModel;
		public MyView ()
		{
			InitializeComponent();

            viewModel = new MyViewModel(this);
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = viewModel;
            viewModel.Id = "1";
            viewModel.RefreshCommand.Execute(null);
        }
    }
}
