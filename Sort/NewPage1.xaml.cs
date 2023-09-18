using Sort.Resources;

namespace Sort;

public partial class NewPage1 : ContentPage
{
    public static InputNumbers newPage = new InputNumbers();

    public NewPage1()
	{
        InitializeComponent();
        Entry numberEntry = new Entry
        {
            Placeholder = "Number",
            Keyboard = Keyboard.Numeric
        };
        VerticalStackLayout stack = this.FindByName<VerticalStackLayout>("stackLayout");
        
        stack.Children.Add(numberEntry);

         numberEntry.Completed += async (sender, args) =>
        {
            UserInfo.arrLength = numberEntry.Text;
            
            await Navigation.PushAsync(newPage);
        };
    }
}