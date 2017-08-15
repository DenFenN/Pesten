using Pesten.GameEngine.Cards;
using Pesten.GameEngine.SpecialCardCalculators;

namespace Pesten.GameEngine
{
    public class Engine
    {
        private Deck _deck = null;
        
        public Engine()
        {
            
        }

        public bool Initialize()
        {
            return Deck.TryCreateNewDeck(new DutchSpecialCardCalculator(), out _deck);
        }
    }
}
