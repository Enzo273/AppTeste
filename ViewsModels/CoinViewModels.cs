using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AppTeste.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AppTeste.ViewsModels
{
    public partial class CoinViewModels : ObservableObject
    {
        //ctor + TAB
        public CoinViewModels()
        {
            FlipCommand = new Command(Flip);
        }

        public ICommand FlipCommand { get; set; }


        [ObservableProperty]
        public string _ladoEscolhido = string.Empty;

        [ObservableProperty]
        public string _imagem = string.Empty;

        [ObservableProperty]
        public string _resultado = string.Empty;

        
        public async void Flip()
        {
            try
            {
                await Application.Current.MainPage.DisplayAlert("Mensagem", "Bem-vindo(a) ao COIN FLIP", "Ok");
                if (string.IsNullOrEmpty(_ladoEscolhido)) {
                    throw new Exception("Selecione o lado da moeda");
                }

                string nome = await Application.Current.MainPage.DisplayPromptAsync("Identificação", "Digite seu nome");

                Coin coin = new Coin();
                _resultado = coin.Jogar(_ladoEscolhido);
                _imagem = $"{coin.Lado}.png";


                OnPropertyChanged(nameof(Resultado));
                OnPropertyChanged(nameof(Imagem));
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Mensagem", ex.Message, "Ok");
            }

        }

    }
}
