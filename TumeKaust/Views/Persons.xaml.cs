using System.Threading.Tasks;
using TumeKaust.Models;
using TumeKaust.Models.ViewModels;

namespace TumeKaust.Views;

public partial class Persons : ContentPage
{
	public Persons()
	{
		InitializeComponent();
		BindingContext = new PersonsViewModel();
	}

    private async void OnBackClicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}