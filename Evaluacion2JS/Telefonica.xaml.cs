using System.Diagnostics;

namespace Evaluacion2JS;

public partial class Telefonica : ContentPage
{
    public Telefonica()
    {
        InitializeComponent();

       



    }
    private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        MaximumHeightRequest = 10;
        Console.WriteLine($"Texto ingresado: {entryTelefono.Text}");
    }



    async void JSButton_Clicked (object sender, EventArgs args)
    {
        
        await label.RelRotateTo(360, 1000);
        bool answer = await DisplayAlert("Confirmacion", "Seguro quieres recargar te vamos a estafabar veras", "Si, Me estan Amenzando", "No");
        Debug.WriteLine("Answer: " + answer);
        await DisplayAlert("Muy bien!", "Su recarga se completo", "OK");
    }

    Image image = new Image
    {
        Source = ImageSource.FromFile("conejito.jpg")
    };


}