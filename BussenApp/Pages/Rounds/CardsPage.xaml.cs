using BussenApp.ViewModels;

namespace BussenApp.Pages.Rounds
{
    public partial class CardsPage : ContentPage
    {

        public CardsPage() {
            InitializeComponent();
            this.BindingContext = new CardsViewModel();
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
            CardsViewModel viewModel = (CardsViewModel)BindingContext;

            
        }

    }
}
