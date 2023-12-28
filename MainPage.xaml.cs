namespace AceleradoresDeTeclado
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

       

        private void MenuFlyoutItem_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Hola", "Presionaste un acelerador de teclado", "Salir");
        }

        private void MenuFlyoutItem_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Hola", "Presionaste un acelerador de varios modificadores", "Salir");
        }

        private void MenuFlyoutItem_Clicked_2(object sender, EventArgs e)
        {
            DisplayAlert("Hola", "Presionaste un acelerador especifico de la plataforma windows", "Salir");
        }

        private void MenuFlyoutItem_Clicked_3(object sender, EventArgs e)
        {
            DisplayAlert("Hola", "Presionaste la tecla especial F1", "Salir");
        }
    }

}
