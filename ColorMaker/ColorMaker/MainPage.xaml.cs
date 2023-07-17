using CommunityToolkit.Maui.Alerts;

namespace ColorMaker;

public partial class MainPage : ContentPage
{
	bool isRandom;
	string hexValue;

    public MainPage()
	{
		InitializeComponent();
	}

    void Slider_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
		if(isRandom) {
			return;
		}
		var red = sldRed.Value;
		var green = sldGreen.Value;
		var blue = sldBlue.Value;

		Color color = Color.FromRgb(red, green, blue);
        SetColor(color);
    }

	private void SetColor(Color color)
	{
        Console.WriteLine(color.ToString());
        btnRandom.BackgroundColor = color;
		Container.BackgroundColor = color;
        hexValue = color.ToHex();
		lblHex.Text = hexValue;
    }

    void btnRandom_Clicked(System.Object sender, System.EventArgs e)
    {
		isRandom = true;
		var random = new Random();
		var color = Color.FromRgb(
			random.Next(0, 256),
			random.Next(0, 256),
			random.Next(0, 256));
        SetColor(color);
		sldRed.Value = color.Red;
        sldGreen.Value = color.Red;
        sldBlue.Value = color.Red;
		isRandom = false;
    }

    private async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
    {
		await Clipboard.SetTextAsync(hexValue);
		var toast = Toast.Make("Color copied", CommunityToolkit.Maui.Core.ToastDuration.Short, 12);
		await toast.Show();
    }
}


