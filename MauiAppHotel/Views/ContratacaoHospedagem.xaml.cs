using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    readonly List<Quarto> listaQuartos = new()
    {
        new Quarto { Descricao = "Suíte Super Luxo",   ValorDiariaAdulto = 150, ValorDiariaCrianca = 75 },
        new Quarto { Descricao = "Suíte Luxo",         ValorDiariaAdulto = 120, ValorDiariaCrianca = 60 },
        new Quarto { Descricao = "Quarto Standard",    ValorDiariaAdulto = 90,  ValorDiariaCrianca = 45 },
        new Quarto { Descricao = "Quarto Econômico",   ValorDiariaAdulto = 70,  ValorDiariaCrianca = 35 },
    };

    public ContratacaoHospedagem()
    {
        InitializeComponent();

        pck_quarto.ItemsSource = listaQuartos;

        dtpck_checkin.MinimumDate = DateTime.Today;
        dtpck_checkin.Date = DateTime.Today;

        dtpck_checkout.MinimumDate = DateTime.Today.AddDays(1);
        dtpck_checkout.Date = DateTime.Today.AddDays(1);
    }

    // O check-out nunca pode ser anterior (ou igual) ao check-in.
    private void dtpck_checkin_DateSelected(object? sender, DateChangedEventArgs e)
    {
        DateTime minimoCheckout = e.NewDate.AddDays(1);

        dtpck_checkout.MinimumDate = minimoCheckout;

        if (dtpck_checkout.Date < minimoCheckout)
            dtpck_checkout.Date = minimoCheckout;
    }

    private async void Button_Clicked(object? sender, EventArgs e)
    {
        if (pck_quarto.SelectedItem is not Quarto quarto)
        {
            await DisplayAlert("Atenção", "Selecione uma acomodação.", "OK");
            return;
        }

        if (stp_adultos.Value + stp_criancas.Value == 0)
        {
            await DisplayAlert("Atenção", "Informe pelo menos um hóspede.", "OK");
            return;
        }

        Hospedagem h = new()
        {
            QuartoSelecionado = quarto,
            QtdAdultos = Convert.ToInt32(stp_adultos.Value),
            QtdCriancas = Convert.ToInt32(stp_criancas.Value),
            DataCheckIn = dtpck_checkin.Date,
            DataCheckOut = dtpck_checkout.Date,
        };

        // Envia os dados para a próxima tela via BindingContext.
        await Navigation.PushAsync(new HospedagemContratada
        {
            BindingContext = h
        });
    }

    private async void Sobre_Clicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}
