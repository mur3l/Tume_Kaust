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
}