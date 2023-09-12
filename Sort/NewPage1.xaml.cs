namespace Sort;

public partial class NewPage1 : ContentPage
{
    public Entry numberEntry = new Entry
    {
        Placeholder = "Number",
        Keyboard = Keyboard.Numeric
        
    };
    
    public NewPage1()
	{
        InitializeComponent();
        VerticalStackLayout stack = this.FindByName<VerticalStackLayout>("stackLayout");
        stack.Children.Add(numberEntry);
    }
    /*numberEntry.Completed += (sender, args) =>
    {
            // Handle the event here
    };*/
}