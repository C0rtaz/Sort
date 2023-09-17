namespace Sort
{
    public partial class MainPage : ContentPage
    {
        static public NewPage1 newPage = new NewPage1();
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
                
                await Navigation.PushAsync(newPage);

        }
    }
}