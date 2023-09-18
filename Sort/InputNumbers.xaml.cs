using Sort.Resources;
using System.Security.Cryptography.X509Certificates;

namespace Sort;

public partial class InputNumbers : ContentPage
{

    public InputNumbers()
	{
		InitializeComponent();
        VerticalStackLayout stack = this.FindByName<VerticalStackLayout>("stackLayout");
		InitInputPage initInputPage = new InitInputPage(stack);
    }

    async  public void NextPage()
    {
        SortAnimation sortAnimation = new SortAnimation();
        await Navigation.PushAsync(sortAnimation);
    }
}