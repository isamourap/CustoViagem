using System;
using System.Linq;
using System.Threading.Tasks;
using AppMauiCustoViagem.Models;

namespace AppMauiCustoViagem
{
    public partial class MainPage : ContentPage
    {
        private App PropridadesApp;

        public MainPage()
        {
            InitializeComponent();
        }

      

        private async void Button_Calcular(object sender, EventArgs e)
        {
            try
            {
                // Usan Linq para somar os pedágios.             

                //Validçãoes das entradas

                if (string.IsNullOrEmpty(etyDistancia.Text))
                    throw new Exception("Por favor, preencha a distância.");

                if (string.IsNullOrEmpty(etyRendimento.Text))
                    throw new Exception("Por favor, preencha o consumo do veículo.");

                if (string.IsNullOrEmpty(etyPrecoG.Text))
                    throw new Exception("Por favor, preencha o valor da gasolina.");

                decimal consumo = Convert.ToDecimal(etyRendimento.Text);
                decimal preco_combustivel = Convert.ToDecimal(etyPrecoG.Text);
                decimal distancia = Convert.ToDecimal(etyDistancia.Text);

                // Consumo do carro
                decimal consumo_carro = (distancia / consumo) * preco_combustivel;
               

                string origem = etyOrigem.Text;
                string destino = etyDestino.Text;

                string mensagem = string.Format("Viagem de {0} a {1} custará {2}", origem,
                    destino, consumo_carro.ToString("C"));

                await DisplayAlert("Resultado final", mensagem, "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", "Ocorreu um erro: ", ex.Message, "Ok");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                bool confirmar = await DisplayAlert("Tem certeza?",
                    "Limpar todos os dados?", "sim", "não");

                if (confirmar)
                {
                    etyRendimento.Text = " ";
                    etyDestino.Text = string.Empty;
                    etyDistancia.Text = " ";
                    etyOrigem.Text = " ";
                    etyPrecoG.Text = " ";
                   

                    
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

       
    }
}


