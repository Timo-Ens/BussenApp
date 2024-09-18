using BussenApp.GameModels;
using System.ComponentModel;

namespace BussenApp.ViewModels
{
    public class CardsViewModel : INotifyPropertyChanged, IQueryAttributable
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public Game Game { get; set; }


        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Game? game = query["Game"] as Game;
            this.Game = game;
        }
    }
}
