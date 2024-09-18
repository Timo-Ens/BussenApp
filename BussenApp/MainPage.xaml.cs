using BussenApp.GameModels;

namespace BussenApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnStartClicked(object sender, EventArgs e)
        {
            Game game = new Game();
            // TODO: Remove default players
            game.AddPlayer(new Player("Timo"));
            game.AddPlayer(new Player("Nursel"));
            var navigationParameter = new Dictionary<string, object> { { "Game", game } };
            await Shell.Current.GoToAsync("//Game", navigationParameter);
        }
    }

}
