using Microsoft.Extensions.Options;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    { int Valor = 0;
        int count = 0;

        public MainPage()
        {
            
            InitializeComponent();
        }

        private void RollBtn_Clicked(object sender, EventArgs e)
        {
            //pegar õ valor que foi selecionado pelo usuario no picker 
            Valor = Convert.ToInt32(SidesPicker.SelectedItem)+1;
            //jpgar esse valor em uma variavel 
            //sortear um numero no dado ultilizando o ramdom 
            var ValorSorteado = 0;
            ValorSorteado= new Random().Next(1, Valor+1);

            //o numero deve ficar entre 1 e o numero de face selecionado
            //exibir o valor para o usuario na resultlabel
            ResultLabel.Text= ValorSorteado.ToString();
            //
        }
    }

}
