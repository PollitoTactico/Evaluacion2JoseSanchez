using System.Diagnostics;
using System.IO;

namespace Evaluacion2JS
{
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

        async void JSButton_Clicked(object sender, EventArgs args)
        {
            
            await label.RelRotateTo(360, 1000);
         
            bool answer = await DisplayAlert("Confirmacion", "Seguro quieres recargar te vamos a estafabar veras", "Si, Me estan Amenzando", "No");
            Debug.WriteLine("Answer: " + answer);

            if (answer)
            {
                
                await DisplayAlert("Muy bien!", "Su recarga se completo", "OK");
                string numeroTelefono = entryTelefono.Text;
                if (string.IsNullOrEmpty(numeroTelefono))
                {
                    await DisplayAlert("Error", "Por favor ingrese un número de teléfono válido.", "OK");
                    return;
                }

                
                string montoRecarga = "10";
                if (Content is StackLayout stackLayout)
                {
                    foreach (var view in stackLayout.Children)
                    {
                        if (view is RadioButton radioButton && radioButton.IsChecked)
                        {
                            montoRecarga = radioButton.Content.ToString().Replace("$", "");
                            break;
                        }
                    }
                }
             

                string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");

          
                string textoArchivo = $"Se hizo una recarga de {montoRecarga} dólares en la siguiente fecha; {fechaActual}";
                string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), $"{numeroTelefono}.txt");

               
                File.WriteAllText(rutaArchivo, textoArchivo);

                Debug.WriteLine($"Archivo guardado en: {rutaArchivo}");
            }
        }

        Image image = new Image
        {
            Source = ImageSource.FromFile("conejito.jpg")
        };
    }
}
