namespace DataBindingDemo;

using System.ComponentModel;
using DataBindingDemo.Models;

public partial class MainPage : ContentPage
{
	Person person = new Person();

	public MainPage()
	{
		InitializeComponent();

		person = new Person
        {
            Name = "John",
            Phone = "46545",
            Address = "Newyork"
        };
        BindingContext = person;
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
        /* This never update the UI directly or indirectly. this is place when datasource changes, how the ui get updated. there MVVM comes to save us :) */
        person = new Person
        {
            Name = "Gandhi",
            Phone = "0000",
            Address = "India"
        };

        /* Here when we change the property value. how the ui get updated! */
        //person.Name = "Gandhi";
        //person.Phone = "0000";
        //person.Address = "India";

        /*var person = new Person
		{
			Name = "John",
			Phone = "46545",
			Address = "Newyork"
		};*/

        /* Here we are using data binding in source file. ie.code file
		Binding personBinding = new Binding();
		personBinding.Source = person; //here Source is Generics. anything you can use string or object
		personBinding.Path = "Name";

		txtName.SetBinding(Label.TextProperty, personBinding);
		*/

        //txtName.BindingContext = person;
        //      txtName.SetBinding(Label.TextProperty, "Name");

        //BindingContext = person;
    }
}


