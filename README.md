# Pokerhands

## Test Methods ##

### Hands Tests ###
Tests the following on all hands:
* 1. Tests if the hand is not null
* 2. Tests if the hand type is not null
* 3. Tests if the hand result is equal to the result of the cards
* 4. Tests if the string containing the name of the hand is equal to the handtype.
#### TestMethodIsRoyalStraightFlush ####
Results: All passed.
#### TestMethodIsRoyalFlush ####
Results: All passed.
#### TestMethodIsStraightFlush ####
Results: All passed.
#### TestMethodFourOfAKind ####
Results: All passed.
#### TestMethodFullHouse ####
Results: All passed.
#### TestMethodIsFlush ####
Results: All passed.
#### TestMethodIsStraight ####
Results: All passed.
#### TestMethodIsTwoPair ####
Results: All passed.

### Comparing Hands Test ###
#### TestMethodCompareRoyalStraightFlushAndRoyalFlush ####
Royal flush and royal straight flush actually is the same thing but the latter has higher point value.

This test theory gets two hands containing two royal flushes/ royal straight flushes from GetRoyalFlushAndRoyalStraightFlushHands. The test method also contains two winning hands from comparing the hands in different order (winningLowerHandFirst and winningHigherhandFirst).

* 1. Tests if the return value from CompareHighestCard is null.
* 2. Tests if the return value from CompareSameTypeHands is null.
* 3. Tests the winning handtypes are equal to "Royal Straight Flush".
* 4. Tests if winningHigherHandFirst is not the same as royalStraightFlushHand and royalFlushHand.
* 5. Tests is the winningLowerHandFirst is not the same as royalStraightFlushHand and royalFlushHand.

Documentation - TODO - Comming soon♣♠♥