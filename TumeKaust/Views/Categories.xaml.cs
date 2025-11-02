namespace TumeKaust.Views;

public partial class Categories : ContentPage
{
	public Categories()
	{
		InitializeComponent();
	}

	private async void OnPoliitikudClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new PoliitikudPage());
	}

	private async void OnSportlasedClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new SportlasedPage());
	}

	private async void OnSuunamudijadClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new SuunamudijadPage());
	}

	private async void OnPresidendidClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new PresidendidPage());
	}

	private async void OnBackClicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}