using System.Threading.Tasks;
using TumeKaust.Models;

namespace TumeKaust.Views;

public partial class Persons : ContentPage
{
	public Persons()
	{
		InitializeComponent();
		BindingContext = new Persons();
	}

    private async void OnBackClicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}