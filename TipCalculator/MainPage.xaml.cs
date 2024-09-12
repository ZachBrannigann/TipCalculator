namespace TipCalculator;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Title = "Mr. Pinks Tipping Calculator";
    }

    public Double Bill;

    public void OkayTip(object sender, EventArgs e)
    {
        Double.TryParse(txtBillAmount.Text, out Bill);
        lblTip.Text = "15% Tip = $" + Bill * .15;
        lblAmount.Text = "Bill Amount = $" + Bill;
        lblTotal.Text = "Total = $" + ((Bill * .15) + Bill);
    }

    private void GoodTip(object sender, EventArgs e)
    {
        Double.TryParse(txtBillAmount.Text, out Bill);
        lblTip.Text = "20% Tip = $" + Bill * .2;
        lblAmount.Text = "Bill Amount = $" + Bill;
        lblTotal.Text = "Total = $" + ((Bill * .2) + Bill);
    }

    private void GreatTip(object sender, EventArgs e)
    {
        Double.TryParse(txtBillAmount.Text, out Bill);
        lblTip.Text = "25% Tip = $" + Bill * .25;
        lblAmount.Text = "Bill Amount = $" + Bill;
        lblTotal.Text = "Total = $" + ((Bill * .25) + Bill);
    }
}