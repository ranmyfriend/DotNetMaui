namespace PerfectPay;

public partial class MainPage : ContentPage
{
	decimal bill;
	int tip;
	int noPersons = 1;

	public MainPage()
	{
		InitializeComponent();
	}

    void txtBill_Completed(System.Object sender, System.EventArgs e)
    {
		bill = decimal.Parse(txtBill.Text);
		CalculateTotal();
    }

	private void CalculateTotal()
	{
		//Total tip
		var totalTip = (bill * tip) / 100;

		//Tip by person
		var tipByPerson = (totalTip / noPersons);
		lblTipByPerson.Text = $"{tipByPerson:C}";

		//Subtotal
		var subtotal = (bill / noPersons);
		lblSubtotal.Text = $"{subtotal:C}";

		//total
		var totalByPerson = (bill + totalTip) / noPersons;
		lblTotal.Text = $"{totalByPerson:C}";
	}

    void sldTip_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
		tip = (int)sldTip.Value;
		lblTip.Text = $"Tip: {tip}%";
		CalculateTotal();
    }

    private void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		if(sender is Button)
		{
			var btn = (Button)sender;
			var percentge = int.Parse(btn.Text.Replace("%", ""));
			sldTip.Value = percentge;
		}
    }

    void btnMinus_Clicked(System.Object sender, System.EventArgs e)
    {
		if(noPersons > 1)
		{
			noPersons--;
		}
		lblNoPersons.Text = noPersons.ToString();
		CalculateTotal();
    }

    void btnPlus_Clicked(System.Object sender, System.EventArgs e)
    {
		noPersons++;
        lblNoPersons.Text = noPersons.ToString();
        CalculateTotal();
    }
}


