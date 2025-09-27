using AppTeste.ViewsModels;

namespace AppTeste.Views;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();
		// CTRL + . : Mostra soluções para alguns erros(import)
		this.BindingContext = new CoinViewModels();
	}
}