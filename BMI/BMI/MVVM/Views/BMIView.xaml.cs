using BMI.MVVM.ViewModels;

namespace BMI.MVVM.Views;

public partial class BMIViews : ContentPage
{
	public BMIViews()
	{
		InitializeComponent();
		BindingContext = new BMIViewModel();
	}
}
