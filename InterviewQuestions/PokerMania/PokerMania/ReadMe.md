# Problem Statement:


"Design and implement a method that can deal 'n' hands of poker.  This includes designing and implementing any objects needed to perform this.  Please document your design decisions. You have 90 minutes."

## Extra Details:
- limited to one standard 52 deck of cards excluding Jokers.

## Documentation of Design Decisions:

I used a four class structure for the solution to dealing 'n' hands of poker. 
- The Card class just contains the definition of a single card and also adds the enums for Suit and Value to the namespace.
- The DeckofCards class contains a deck of cards (a List<Card> object limited to 52 cards) and the methods to handle shuffling, getting a card from the top of the deck, and resetting the deck back to its initial state
- The PokerHand class contains a single hand of cards (a List<Card> object limited to 5 cards) and a method for adding to the hand. I did not implement a method for removing cards from the hand to save time since it wasn't necessary to solve the problem statement, but it would be needed for a complete implementation.
- The Dealer class contain a single DeckOfCards object which it initializes and a method for dealing 1 - 7 PokerHand obects from that deck. I return the hands as a List<PokerHand> object so that an external user of the class can then decide what to do with those cards. 

The class structure should make adding new features to this code easily since responsibilities are separated and limit code duplication.

### 1st commit
This was a first pass of creating the class structure and functionality of the Poker Mania solution. It contains limited error checking and 5 hands of Poker are hardcoded to be dealt in the Program.cs.

For the card suits and values I decided to use enums. I also changed the default values of the enums of CardValues so that future development could include comparing the hands dealt to find a winner.
  
Now that the base requirements of the problem solution are complete I will work on a second commit to add better error handling and allow the user to choose the number of hands to be dealt.

Total time spent is about 45 minutes coding. 


### 2nd commit 
I added the ability for the user to imput the number of hands they want from the command line. 

I also added error checking if they provided invalid input with either a number outside the range of allowed number of hands or a non-numerical value.

### 3rd commit
Spent the last few minutes of the hour and a half going back through the code to add proper comments for each of the methods.