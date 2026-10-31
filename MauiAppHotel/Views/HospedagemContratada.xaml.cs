namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

	private async void NovaReserva_Clicked(object? sender, EventArgs e)
	{
		await Navigation.PopToRootAsync();
	}
}
