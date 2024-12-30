namespace CardGames.Domain;

public class HigherLowerGame
{
    public ICard CurrentCard { get; private set; }
    public ICard? PreviousCard { get; private set; }

    public int NumberOfCorrectGuesses { get; private set; }

    public string? Motivation { get; private set; }
    public bool HasWon => _hasWon;

    private ICardDeck _cardDeck;
    private ICard _nextCard;
    private int _requiredNumberOfCorrectGuesses;
    private bool _hasWon;

    public HigherLowerGame(ICardDeck standardDeck, int requiredNumberOfCorrectGuesses, CardRank minimumRank = CardRank.Ace)
    {
        _cardDeck = standardDeck.WithoutCardsRankingLowerThan(minimumRank);
        _cardDeck.Shuffle();
        CurrentCard = _cardDeck.DealCard();
        _nextCard = _cardDeck.DealCard();
        _requiredNumberOfCorrectGuesses = requiredNumberOfCorrectGuesses;
    }

    public void MakeGuess(bool higher)
    {
        if ((higher && _nextCard.Rank > CurrentCard.Rank) || (!higher && _nextCard.Rank < CurrentCard.Rank) || (_nextCard.Rank == CurrentCard.Rank))
        {
            NumberOfCorrectGuesses++;
            PreviousCard = CurrentCard;
            CurrentCard = _nextCard;
            _nextCard = _cardDeck.DealCard();
        }
        else
        {
            Motivation = null;
            NumberOfCorrectGuesses = 0;
            return;
        }

        int guessesRemaining = _requiredNumberOfCorrectGuesses - NumberOfCorrectGuesses;

        if (guessesRemaining <= 3)
        {
            Motivation = $"Only {guessesRemaining} card(s) to go!";
        }
        else
        {
            Motivation = null;
        }

        if (NumberOfCorrectGuesses >= _requiredNumberOfCorrectGuesses)
        {
            _hasWon = true;
        }
    }
}