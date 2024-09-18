using BussenApp.GameModels;
using BussenApp.Pages;
using System.ComponentModel;
using System.Windows.Input;

namespace BussenApp.ViewModels
{
    public class PlayersViewModel : INotifyPropertyChanged, IQueryAttributable
    {

        public event PropertyChangedEventHandler PropertyChanged;        
        public Game Game { get; set; }

        public string PlayerAddName { get; set; }

        public ICommand AddPlayerCommand { get; set; }

        public ICommand RemovePlayerCommand { get; set; }

        public ICommand StartCommand { get; set; }

        public PlayersViewModel()
        {
            AddPlayerCommand = new Command<string>(AddPlayer);
            RemovePlayerCommand = new Command<Player>(RemovePlayer);
            StartCommand = new Command(StartGame);
        }


        public void AddPlayer(string name)
        {
            Game.AddPlayer(new Player(name));
            PlayerAddName = "";
        }

        public void RemovePlayer(Player player)
        {
            Game.RemovePlayer(player);
        }

        public async void StartGame()
        {
            Console.WriteLine("Hoi");
            var navigationParameter = new Dictionary<string, object> { { "Game", Game } };
            await Shell.Current.GoToAsync("//Cards", navigationParameter);
        }


        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Game? game = query["Game"] as Game;
            this.Game = game;
        }
    }
}
