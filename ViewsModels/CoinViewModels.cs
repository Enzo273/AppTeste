using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTeste.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AppTeste.ViewsModels
{
    public partial class CoinViewModels : ObservableObject
    {
        public string _ladoEscolhido = string.Empty;
        public string _imagem = string.Empty;
        public string _resultado = string.Empty;    

        public void Flip()
        {
            Coin coin = new Coin();
            _resultado = coin.Jogar(_ladoEscolhido);
            // lol
        }

    }
}
