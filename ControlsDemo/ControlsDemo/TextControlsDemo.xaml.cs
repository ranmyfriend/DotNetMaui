using System.Diagnostics;

namespace ControlsDemo;

public partial class TextControlsDemo : ContentPage
{
	public TextControlsDemo()
	{
		InitializeComponent();
	}

    void Entry_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
     
    }

    void Entry_Completed(System.Object sender, System.EventArgs e)
    {
        Debug.WriteLine(txtName.Text);
    }
}
