using Sort;

namespace Sort.Resources
{
    internal class InitInputPage
    {
        private VerticalStackLayout parentObj;
        private string strLabel = "Введите числа";
        private string next = "Дальше";
        public InitInputPage(VerticalStackLayout parentalElement) {
            parentObj = parentalElement;
            Init();
        }

        private void Init()
        {
            createLabel(strLabel);
            ScrollView scrollView = createScrolBar();
            HorizontalStackLayout views = createStackLayout(scrollView);
            scrollView.Content = views;
            createButton();
        }


        private void createEntryNumb(HorizontalStackLayout views) {
            for (int i = 0; i < int.Parse(UserInfo.arrLength); ++i) {
                Entry entryNumb = new Entry
                {
                    Keyboard = Keyboard.Numeric,
                    FlowDirection = FlowDirection.LeftToRight,
                    FontSize = 10
                };
                entryNumb.Completed += (sender, e) =>
                {
                    UserInfo.arr[i] = int.Parse(entryNumb.Text);
                    ((Entry)sender).Focus();
                    entryNumb.IsReadOnly = true;
                };
                views.Children.Add(entryNumb);
            }
        
        }

        private HorizontalStackLayout createStackLayout(ScrollView scrollView) {
            HorizontalStackLayout views = new HorizontalStackLayout
            {
                Spacing = 20,
                Padding = 30,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center

            };
            createEntryNumb(views);
            return views;
        }
        private ScrollView createScrolBar() {
            ScrollView scrollView = new ScrollView
            {
                Orientation = ScrollOrientation.Horizontal
            };
            parentObj.Children.Add(scrollView);
            return scrollView;
        }

        private void createButton() {
            Button buttonNext = new Button
            {
                Text = next,
                VerticalOptions = LayoutOptions.End
            };
            parentObj.Children.Add(buttonNext);

            buttonNext.Clicked +=  (sender, args) =>
            {
                InputNumbers.NextPage();
            };
        }
        private void createLabel(string text) {
            Label label = new Label
            {
                Text = text
            };
            parentObj.Children.Add(label);
        }

    }
}
