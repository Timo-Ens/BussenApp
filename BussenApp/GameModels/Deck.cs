using BussenApp.GameModels;
using System.Runtime.CompilerServices;

public class Deck
{
    private static readonly Random rnd = new();

    public int CardIndex = 0;
    public Stack<Card> Cards { get; set; } = new Stack<Card>();

    public Deck()
    {
        Fill();
        Shuffle();
    }

    public void Fill()
    {
        int cardIndex = 0;
        foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
        {
            for (int i = 1; i <= 13; i++)
            {
                Cards.Push(new Card(i, suit));
            }
        }
    }

    public void Shuffle()
    {
        int n = Cards.Count;
        var values = Cards.ToArray();
        Cards.Clear();
        foreach (var value in values.OrderBy(x => rnd.Next()))
            Cards.Push(value);
    }

    public Card? Next()
    {
        if (Cards.Count == 0) return null;
        return Cards.Pop();
    }
}
