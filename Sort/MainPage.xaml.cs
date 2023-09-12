namespace Sort
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
                NewPage1 newPage = new NewPage1();
                await Navigation.PushAsync(newPage);

        }
    }
}