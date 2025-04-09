namespace CadastroPam2;

public partial class ListaProdutosPage : ContentPage
{
    public ListaProdutosPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Atualiza a lista toda vez que a página aparecer
        produtosListView.ItemsSource = null;
        produtosListView.ItemsSource = MainPage.Produtos;
    }

    private async void Voltar_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}
