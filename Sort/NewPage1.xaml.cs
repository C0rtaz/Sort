namespace Sort;

public partial class NewPage1 : ContentPage
{
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
    }
}