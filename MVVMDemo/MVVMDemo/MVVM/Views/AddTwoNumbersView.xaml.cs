using MVVMDemo.MVVM.ViewModels;

namespace MVVMDemo.MVVM.Views;

public partial class AddTwoNumbersView : ContentPage
{
	public AddTwoNumbersView()
	{
		InitializeComponent();
		BindingContext = new AddTwoNumbersViewModel();
	}
}
