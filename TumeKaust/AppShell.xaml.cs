using TumeKaust.Views;

namespace TumeKaust
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(PersonalDetails), typeof(PersonalDetails));
            Routing.RegisterRoute(nameof(PoliitikudPage), typeof(PoliitikudPage));
        }
    }
}