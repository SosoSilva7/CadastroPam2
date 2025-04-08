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

        // Atualiza a lista toda vez que a p�gina aparecer
        produtosListView.ItemsSource = null;
        produtosListView.ItemsSource = MainPage.Produtos;
    }
}
