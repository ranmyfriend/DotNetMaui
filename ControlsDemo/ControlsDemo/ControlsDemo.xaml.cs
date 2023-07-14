namespace ControlsDemo;

public partial class ControlsDemo : ContentPage
{
	public ControlsDemo()
	{
		InitializeComponent();
	}

    void btnTest_Clicked(System.Object sender, System.EventArgs e)
    {
		DisplayAlert("Test", "This is demo", "OK");
    }

    void RadioButton_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
        DisplayAlert("RaidoButton", $"Changed: {e.Value}", "OK");
    }

    void searchControl_SearchButtonPressed(System.Object sender, System.EventArgs e)
    {
        DisplayAlert("Searching", $"Searching: {searchControl.Text}", "OK");
    }

    void SwipeItem_Invoked(System.Object sender, System.EventArgs e)
    {
        DisplayAlert("SwipeView", $"Element Tapped", "OK");
    }
}
