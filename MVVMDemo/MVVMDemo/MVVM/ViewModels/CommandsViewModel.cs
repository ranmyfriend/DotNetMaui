using System;
using System.Windows.Input;

namespace MVVMDemo.MVVM.ViewModels
{
    public class CommandsViewModel
	{
		//Variety of ways to create Commands!
		//public ICommand ClickCommand => new Command(() => App.Current.MainPage.DisplayAlert("Title", "message", "Ok"));
		//public ICommand ClickCommand => new Command(Alert);
		public ICommand ClickCommand { get; }
		public ICommand SearchCommand { get; }
		public string searchText { get; set; }

        public CommandsViewModel()
		{
            ClickCommand = new Command(() =>
			{
				App.Current.MainPage.DisplayAlert("Title", "message", "Ok");
			});

			//This is how we can pass parameter from view to viewModel
			// SearchParameter command will give us the searchTxt as parameter to this command
			SearchCommand = new Command((s) =>
            {
				var data = s;
            });
        }

		private void Alert()
		{
			App.Current.MainPage.DisplayAlert("Title", "message", "Ok");
        }

	}
}

