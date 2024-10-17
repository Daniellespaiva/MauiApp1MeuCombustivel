namespace MauiApp1MeuCombustivel
{

    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);
                string marca = txt_marca.Text;
                string modelo = txt_modelo.Text;

                string msg = "";

                if (etanol <= (gasolina * 0.7))
                {
                    msg = "O etanol no valor de R$ " + etanol + " está compensando para  a marca de veículo " + marca + " modelo " + modelo;
                }
                else
                {
                    msg = "A gasolina no valor de R$ " + gasolina + " está compensando para a marca de veículo " + marca + " modelo " + modelo;
                }

                DisplayAlert("Calculando", msg, "OK");
            } catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }

        }//Fechando Método

    }//Fechando Classe
}//Fechando namespace


