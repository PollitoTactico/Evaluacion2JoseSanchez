namespace Evaluacion2JS;

public partial class Telefonica : ContentPage
{
    public Telefonica()
    {
        InitializeComponent();
    }


    async void JSButton_Clicked (object sender, EventArgs args)
    {
        await label.RelRotateTo(360, 1000);
        await DisplayAlert("Muy bien!", "Su recarga se completo", "OK");
    }
}