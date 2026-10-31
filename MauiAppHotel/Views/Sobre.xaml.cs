using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
    public Sobre()
    {
        InitializeComponent();

        BindingContext = new InfoSobre();
    }

    private async void Voltar_Clicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
