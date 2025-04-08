namespace CadastroPam2
{
    public partial class MainPage : ContentPage
    {
        public static List<Produto> Produtos { get; private set; } = new List<Produto>();
        public MainPage()
        {
            InitializeComponent();
        }

        private void AdicionarProduto_Clicked(object sender, EventArgs e)
        {

            string nome = nomeEntry.Text;
            string descricao = descriEntry.Text;
            string validade = validadeEntry.Text;
            string categoria = categoriaEntry.Text;

            if (double.TryParse(precoEntry.Text, out double preco) && !string.IsNullOrWhiteSpace(nome) )

            {

                MainPage.Produtos.Add(new Produto { Nome = nome, Preco = preco, Descricao = descricao, Validade = validade, Categoria= categoria});


                mensagemLabel.Text = "Produto Cadastrado com Sucesso!";

                nomeEntry.Text = string.Empty;

                precoEntry.Text = string.Empty;

                descriEntry.Text = string.Empty;

                validadeEntry.Text = string.Empty;

                categoriaEntry.Text = string.Empty;

            }

            else

            {

                mensagemLabel.Text = "Preencha os campos corretamente!";

            }

        }


        private async void IrParaLista_Clicked(object sender, EventArgs e)

        {

            await Shell.Current.GoToAsync("//ListaProdutosPage");

        }

        public class Produto

        {

            public string Nome { get; set; }

            public double Preco { get; set; }

            public string Descricao { get; set; }

            public string Validade { get; set; }

            public string Categoria { get; set; }


            // Propriedade calculada para exibir o preço formatado

            public string PrecoFormatado => $"R$ {Preco:F2}";


            // Construtor para garantir que 'Nome' nunca seja nulo

            public Produto(string nome, double preco,string descricao, string validade, string categoria )

            {

                Nome = nome;

                Preco = preco;
                Descricao = descricao;
                Validade = validade;
                Categoria = categoria;


            }


            // Construtor vazio para compatibilidade com a lista

            public Produto() { Nome = "";
                Descricao = "";
                Validade = "";
                Categoria = "";
            }


        }


    }
}


