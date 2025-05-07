using System.Text.Json;

namespace experiments.Models;
[QueryProperty(nameof(Data), "data")]
public partial class PersonDetailsPage : ContentPage
{
    private string _data;
    public string Data
    {
        get => _data;
        set
        {
            _data = value;
            var json = Uri.UnescapeDataString(_data);
            var person = JsonSerializer.Deserialize<Person>(json);
            BindingContext = person;
        }
    }
    public PersonDetailsPage()
	{
		InitializeComponent();
	}
}