namespace TumeKaust
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            FadeInImage();
        }

        private async void FadeInImage()
        {
            // ootab 1 sekundi ja animatsioon kaivitub viieks sekundiks
            await Task.Delay(1000);
            await logoimage.FadeTo(1, 5000); // 0 → 1 opacity, 5000ms
        }
    }
}
