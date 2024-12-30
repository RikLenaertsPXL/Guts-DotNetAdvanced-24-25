
using System.Collections.Generic;

namespace CardGames.Domain;

public class CardDeck : ICardDeck
{
    public int RemainingCards { get; }
    private readonly IList<ICard> _cardDeck = new List<ICard>();
    private static readonly Random _random = new Random();

    public CardDeck()
    {
        foreach (CardSuit suit in Enum.GetValues<CardSuit>())
        {
            foreach (CardRank rank in Enum.GetValues<CardRank>())
            {
                _cardDeck.Add(new Card(suit, rank));
            }
        }
    }

    private CardDeck(IList<ICard> cards)
    {
        _cardDeck = cards;
    }

    public ICard DealCard()
    {
        if (_cardDeck.Count == 0)
        {
            throw new InvalidOperationException();
        }
        ICard lastCard = _cardDeck.Last();
        _cardDeck.Remove(lastCard);
        return lastCard;
    }

    public void Shuffle()
    {
        int n = _cardDeck.Count;
        while (n > 1)
        {
            n--;
            int k = _random.Next(n + 1);
            ICard card = _cardDeck[k];
            _cardDeck[k] = _cardDeck[n];
            _cardDeck[n] = card;
        }
    }

    public IList<CardDeck> SplitBySuit()
    {
        IList<CardDeck> carddecks;

        var groupedBySuit = (from card in _cardDeck
                            group card by card.Suit into suitGroup
                            select new CardDeck(suitGroup.ToList())).ToList();
        return groupedBySuit;
    }

    public ICardDeck WithoutCardsRankingLowerThan(CardRank minimumRank)
    {
        var cards = (from c in _cardDeck
                   where c.Rank >= minimumRank
                   select c).ToList();

        return new CardDeck(cards);
    }
}