namespace ExternalResourcesDemo;

using System.Diagnostics;
using System.Text.Json;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        Task.Run(async () => await LoadMauiAsset());
    }

    async Task LoadMauiAsset()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("data.json");
        using var reader = new StreamReader(stream);

        var contents = reader.ReadToEnd();
        var p = JsonSerializer.Deserialize<Person>(contents);
        Debug.WriteLine(p);

    }

}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}


