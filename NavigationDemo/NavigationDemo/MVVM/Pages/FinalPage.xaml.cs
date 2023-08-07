namespace NavigationDemo.MVVM.Pages;

public partial class FinalPage : ContentPage
{
	public FinalPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Navigation.PopAsync();
    }

    void Button_Clicked_1(System.Object sender, System.EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}
