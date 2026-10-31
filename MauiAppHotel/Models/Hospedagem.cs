namespace MauiAppHotel.Models;

public class Hospedagem
{
    public Quarto QuartoSelecionado { get; set; } = new();
    public int QtdAdultos { get; set; }
    public int QtdCriancas { get; set; }
    public DateTime DataCheckIn { get; set; }
    public DateTime DataCheckOut { get; set; }

    public int Estadia => Math.Max((DataCheckOut.Date - DataCheckIn.Date).Days, 0);

    public double ValorTotal =>
        ((QtdAdultos * QuartoSelecionado.ValorDiariaAdulto) +
         (QtdCriancas * QuartoSelecionado.ValorDiariaCrianca)) * Estadia;
}
