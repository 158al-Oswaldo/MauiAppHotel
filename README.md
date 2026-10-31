# MauiAppHotel

Aplicativo móvel multiplataforma desenvolvido em .NET MAUI para simular a contratação e o gerenciamento de reservas em um hotel[cite: 1].

## Funcionalidades
* **Contratação de Hospedagem:** Interface interativa para selecionar e reservar quartos (`ContratacaoHospedagem.xaml`)[cite: 1].
* **Resumo da Reserva:** Tela com a confirmação e os detalhes da hospedagem contratada (`HospedagemContratada.xaml`)[cite: 1].
* **Sobre:** Informações e créditos do aplicativo (`Sobre.xaml`)[cite: 1].

## Estrutura do Projeto
O padrão do projeto é dividido nas seguintes camadas principais:
* `Models/`: Entidades de dados e regras de negócio, contendo as classes `Hospedagem.cs`, `Quarto.cs` e `InfoSobre.cs`[cite: 1].
* `Views/`: Interfaces gráficas (arquivos `.xaml`) onde ocorre a interação com o usuário[cite: 1].
* `Resources/`: Armazena fontes customizadas (Kalam e OpenSans), imagens, ícones e a folha de estilos padrão do app (`Styles.xaml`)[cite: 1].
