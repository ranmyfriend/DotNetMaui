namespace NavigationDemo.MVVM.Pages;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new FinalPage());
    }


    void Button_Clicked_1(System.Object sender, System.EventArgs e)
    {
        Navigation.PopAsync();
    }
}
