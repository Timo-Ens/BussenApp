using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace BussenApp.GameModels
{
    public class Game : INotifyPropertyChanged, INotifyCollectionChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public event NotifyCollectionChangedEventHandler? CollectionChanged;

        public ObservableCollection<Player> Players { get; set; }
        
        public Deck Deck { get; set; }

        public Game()
        {
            Players = new ObservableCollection<Player>();
            Deck = new Deck();
        }

        public void AddPlayer(Player player)
        {
            this.Players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            this.Players.Remove(player);
        }

    }
}
