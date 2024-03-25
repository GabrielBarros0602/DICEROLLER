namespace DICEROLLER
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRollClicked(object sender, EventArgs e)
        {
            Random rnd = new Random();

            ResultadoRolagem.Text = ($"{rnd.Next(1, 10)}");
                
        }


    }

}
