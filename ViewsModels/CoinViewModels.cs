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

        public void Flip()
        {
            Coin coin = new Coin();
            _resultado = coin.Jogar(_ladoEscolhido);
            _imagem = $"{coin.Lado}.png";
            
            
            OnPropertyChanged(nameof(Resultado));
            OnPropertyChanged(nameof(Imagem));

        }

    }
}
