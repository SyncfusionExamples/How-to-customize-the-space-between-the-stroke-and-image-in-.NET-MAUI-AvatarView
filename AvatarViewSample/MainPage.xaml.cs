using Syncfusion.Maui.Sliders;

namespace AvatarViewSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnValueChanged(object sender, SliderValueChangedEventArgs e)
        {
            var valueRange = (sender as SfSlider)?.Value;
            if (valueRange != null && circleBorder != null && customBorder != null && squareBorder != null && circleRadius != null && customRadius != null)
            {
                circleBorder.WidthRequest = (double)valueRange;
                circleBorder.HeightRequest = (double)valueRange;
                circleRadius.CornerRadius = (double)valueRange / 2;

                squareBorder.WidthRequest = (double)valueRange;
                squareBorder.HeightRequest = (double)valueRange;

                customBorder.WidthRequest = (double)valueRange * 2;
                customBorder.HeightRequest = (double)valueRange;
                customRadius.CornerRadius = (double)valueRange / 2;
            }
        }
    }

}
