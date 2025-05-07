using experiments.Models;
using System.Text.Json;

namespace experiments
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            var person = new Person { Name = "Yurii", Surname = "Humen", Age = 21, Group = "SN-41", City = "Ternopil", Country = "Ukraine", University = "TNTU" };
            var json = JsonSerializer.Serialize(person);
            var encoded = Uri.EscapeDataString(json);

            await Shell.Current.GoToAsync($"persondetails?data={encoded}");
        }
    }

}
