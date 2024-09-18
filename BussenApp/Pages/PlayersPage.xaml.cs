using BussenApp.ViewModels;

namespace BussenApp.Pages
{
    public partial class PlayersPage : ContentPage
    {

        public PlayersPage()
        {
            InitializeComponent();
            this.BindingContext = new PlayersViewModel();
        }

    }
}
