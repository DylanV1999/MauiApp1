using Microsoft.Maui.Layouts;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var label1 = new Label()
            {
                Text = "Layout1"
            };

            FlexLayout layout1 = new FlexLayout()
            {
                BackgroundColor = Colors.Red,
                Children = { label1 },
                Margin = new Thickness(10)
            };

            FlexLayout layout2 = new FlexLayout()
            {
                BackgroundColor = Colors.Blue,
                Children = { layout1 },
                Margin = new Thickness(10)
            };
            layout2.SetGrow(layout1, 1);

            FlexLayout layout3 = new FlexLayout()
            {
                BackgroundColor = Colors.Orange,
                Children = { layout2 },
                Margin = new Thickness(10),

            };
            layout3.SetGrow(layout2, 1);

            FlexLayout layout4 = new FlexLayout()
            {
                BackgroundColor = Colors.HotPink,
                Children = { layout3 },
                Margin = new Thickness(10),
                Padding = new Thickness(10),
            };
            layout4.SetGrow(layout3, 1);


            // ROOT //

            FlexLayout rootLayout = new FlexLayout()
            {

                Children = { layout4 },
                Direction = FlexDirection.Column,
                BackgroundColor = Colors.LimeGreen

            };

            rootLayout.SetGrow(layout4, 1);

            //////////

            Content = rootLayout;

        }

    }

}
