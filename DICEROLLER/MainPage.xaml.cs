namespace DICEROLLER
{
    public partial class MainPage : ContentPage
    {
        int PickerValue = 0;

        public MainPage()
        {
            InitializeComponent();
            DicePicker.SelectedIndex = 0;
        }

        private void OnRollClicked(object sender, EventArgs e)
        {

            PickerValue = Convert.ToInt32(DicePicker.SelectedItem);
            
            Random rnd = new Random();

            ResultadoRolagem.Text = ($"{rnd.Next(1, PickerValue+1)}");
                
        }


    }

}
