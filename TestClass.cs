using Xunit;
using CardGame;
using Microsoft.VisualStudio.TestPlatform.Common.Utilities;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace Pokerhands;

public class TestClass
{

    [Fact]
    public void TestMethodSameHandLowerFirst()
    {
        // Arrange
        var lowerHand = new Hand(
        [
            new Card('♣', '5'),
            new Card('♠', '5'),
            new Card('♠', '5'),
            new Card('♣', 'K'),
            new Card('♠', 'K')
        ]);

        var higherHand = new Hand(
        [
            new Card('♠', 'A'),
            new Card('♣', 'A'),
            new Card('♠', 'A'),
            new Card('♠', 'K'),
            new Card('♣', 'K')
        ]);

        // Act

        var (winningHand, handType) = CompareHands.CheckHands(lowerHand, higherHand);

        // Assert

        Assert.True(winningHand == higherHand);
        Assert.Equal("Full House", handType);
    }

    [Fact]
    public void TestMethodSameHandHigherFirst()
    {
        // Arrange
        var lowerHand = new Hand(
        [
            new Card('♣', '5'),
            new Card('♠', '5'),
            new Card('♠', '5'),
            new Card('♣', 'K'),
            new Card('♠', 'K')
        ]);

        var higherHand = new Hand(
        [
            new Card('♠', 'A'),
            new Card('♣', 'A'),
            new Card('♠', 'A'),
            new Card('♠', 'K'),
            new Card('♣', 'K')
        ]);

        // Act

        var (winningHand, handType) = CompareHands.CheckHands(higherHand, lowerHand);

        // Assert

        Assert.True(winningHand == higherHand);
        Assert.Equal("Full House", handType);
    }

    [Fact]
    public void TestMethodIsPair()
    {
        // Arrange
        var pairHand = new Hand(
        [
            new Card('♣', '5'),
            new Card('♠', '5'),
            new Card('♠', '4'),
            new Card('♣', '7'),
            new Card('♠', '9')
        ]);


        // Act

        var (hand1Result, handType) = CompareHands.IsPair(pairHand);

        // Assert
        // Example of types of asserts
        Assert.NotNull(hand1Result);
        Assert.NotNull(handType);
        Assert.True(hand1Result == pairHand);
        Assert.Equal("Pair", handType);
    }

    [Fact]
    public void TestMethodIsStraightRoyalFlush()
    {

        // Arrange
        var royalStraightFlushHand = new Hand([
            new Card('♠', 'A'),
            new Card('♠', 'K'),
            new Card('♠', 'Q'),
            new Card('♠', 'J'),
            new Card('♠', 'T')
        ]);
        
        // Act

        var (hand1Result, handType) = CompareHands.IsRoyalStraightFlush(royalStraightFlushHand);
    
        // Then
        Assert.NotNull(hand1Result);
        Assert.NotNull(handType);
        Assert.True(hand1Result == royalStraightFlushHand);
        Assert.Equal("Royal Straight Flush", handType);
    }

    [Fact]
    public void TestMethodIsRoyalFlush()
    {
        // Arrange
        var royalFlushHand = new Hand([
            new Card('♠', 'A'),
            new Card('♠', 'K'),
            new Card('♠', 'Q'),
            new Card('♠', 'J'),
            new Card('♠', 'T')
        ]);
        // Act
        var (hand1Result, handType) = CompareHands.IsRoyalFlush(royalFlushHand);
        // Then
        Assert.NotNull(hand1Result);
        Assert.NotNull(handType);
        Assert.True(hand1Result == royalFlushHand);
        Assert.Equal("Royal Flush", handType);
    }

    [Fact]
    public void TestMethodIsStraightFlush()
    {
        // Arrange
        var straightFlushHand = new Hand([
            new Card('♠', 'T'),
            new Card('♠', '9'),
            new Card('♠', '8'),
            new Card('♠', '7'),
            new Card('♠', '6')
        ]);
        // Act
        var (hand1Result, handType) = CompareHands.IsStraightFlush(straightFlushHand);
        // Then
        Assert.NotNull(hand1Result);
        Assert.NotNull(handType);
        Assert.True(hand1Result == straightFlushHand);
        Assert.Equal("Straight Flush", handType);
    }

    [Fact]
    public void TestMethodIsFourOfAKind()
    {
        // Arrange
        var fourOfAKindHand = new Hand([
            new Card('♣', 'A'),
            new Card('♠', 'A'),
            new Card('♦', 'A'),
            new Card('♥', 'A'),
            new Card('♠', '2')
        ]);
        // Act
        var (hand1Result, handType) = CompareHands.IsFourOfAKind(fourOfAKindHand);
        // Then
        Assert.NotNull(hand1Result);
        Assert.NotNull(handType);
        Assert.True(hand1Result == fourOfAKindHand);
        Assert.Equal("Four of a Kind", handType);
    }

    [Fact]
    public void TestMethodIsFullHouse()
    {
        // Arrange
        var fullHouseHand = new Hand([
            new Card('♣', 'A'),
            new Card('♠', 'A'),
            new Card('♦', 'A'),
            new Card('♥', 'K'),
            new Card('♠', 'K')
        ]);
        // Act
        var (hand1Result, handType) = CompareHands.IsFullHouse(fullHouseHand);
        // Then
        Assert.NotNull(hand1Result);
        Assert.NotNull(handType);
        Assert.True(hand1Result == fullHouseHand);
        Assert.Equal("Full House", handType);
    }

    [Fact]
    public void TestMethodIsFlush()
    {
        // Arrange
        var flushHand = new Hand([
            new Card('♣', '2'),
            new Card('♣', '3'),
            new Card('♣', '4'),
            new Card('♣', '5'),
            new Card('♣', '7')
        ]);
        // Act
        var (hand1Result, handType) = CompareHands.IsFlush(flushHand);
        // Then
        Assert.NotNull(hand1Result);
        Assert.NotNull(handType);
        Assert.True(hand1Result == flushHand);
        Assert.Equal("Flush", handType);
    }

    [Fact]
    public void TestMethodIsStraight()
    {
        // Arrange
        var straightHand = new Hand([
            new Card('♦', '2'),
            new Card('♥', '3'),
            new Card('♥', '4'),
            new Card('♣', '5'),
            new Card('♠', '6')
        ]);
        // Act
        var (hand1Result, handType) = CompareHands.IsStraight(straightHand);
        // Then
        Assert.NotNull(hand1Result);
        Assert.NotNull(handType);
        Assert.True(hand1Result == straightHand);
        Assert.Equal("Straight", handType);
    }

    [Fact]
    public void TestMethodIsThreeOfAKind()
    {
        // Arrange
        var threeOfAKindHand = new Hand([
            new Card('♦', '3'),
            new Card('♥', '3'),
            new Card('♥', '2'),
            new Card('♣', '3'),
            new Card('♠', '6')
        ]);
        // Act
        var (hand1Result, handType) = CompareHands.IsThreeOfAKind(threeOfAKindHand);
        // Then
        Assert.NotNull(hand1Result);
        Assert.NotNull(handType);
        Assert.True(hand1Result == threeOfAKindHand);
        Assert.Equal("Three of a Kind", handType);
    }

    [Fact]
    public void TestMethodIsTwoPair()
    {
        // Arrange
        var twoPairHand = new Hand([
            new Card('♦', '3'),
            new Card('♥', '3'),
            new Card('♥', '6'),
            new Card('♣', '8'),
            new Card('♠', '6')
        ]);
        // Act
        var (hand1Result, handType) = CompareHands.IsTwoPair(twoPairHand);
        // Then
        Assert.NotNull(hand1Result);
        Assert.NotNull(handType);
        Assert.True(hand1Result == twoPairHand);
        Assert.Equal("Two Pair", handType);
    }

    // Test that compares hands containing royal flush and royal straight flush
    [Theory]
    [MemberData(nameof(GetRoyalFlushAndRoyalStraightFlushHands))]
    public void TestMethodCompareRoyalStraightFlushAndRoyalFlush(Hand royalFlushHand, Hand royalStraightFlushHand)
    {
        // Compares the hands twice in different orders
        var (winningLowerHandFirst, handType) = CompareHands.CheckHands(royalFlushHand, royalStraightFlushHand);
        var (winningHigherHandFirst, handType2) = CompareHands.CheckHands(royalStraightFlushHand, royalFlushHand);

        // Compares again but sees if CompareHighestCard returns a hand with high
        // The return value from CompareHighestCard is null
        Assert.Null(CompareHands.CompareHighestCard(royalFlushHand, royalStraightFlushHand));
        Assert.Null(CompareHands.CompareHighestCard(royalStraightFlushHand, royalFlushHand));

        // Compares the hands using the CompareSameTypeHands method since essentially they are the same hand
        Assert.Null(CompareHands.CompareSameTypeHands(royalFlushHand, royalStraightFlushHand));
        Assert.Null(CompareHands.CompareSameTypeHands(royalStraightFlushHand, royalFlushHand));


        // Results = Passed
        // Expected = Fail
        Assert.Equal("Royal Straight Flush", handType);
        Assert.Equal("Royal Straight Flush", handType2);

        // Results = Passed
        // Expected = Fail
        Assert.False(winningHigherHandFirst == royalStraightFlushHand);
        Assert.False(winningHigherHandFirst == royalFlushHand);

        // Results = passed
        // Expected = Fail
        Assert.False(winningLowerHandFirst == royalFlushHand);
        Assert.False(winningLowerHandFirst == royalStraightFlushHand);
    }

    // Method that returns an array with hands containing royal flush and royal straight flush
    public static IEnumerable<object[]> GetRoyalFlushAndRoyalStraightFlushHands()
    { 
        // Returns two arrays of objects containing hands for royal flush/ royal straight flush
        yield return new object[]
        {
            new Hand([
                new Card('♥', 'A'),
                new Card('♥', 'K'),
                new Card('♥', 'Q'),
                new Card('♥', 'J'),
                new Card('♥', 'T')
            ]),
            new Hand([
                new Card('♠', 'A'),
                new Card('♠', 'K'),
                new Card('♠', 'Q'),
                new Card('♠', 'J'),
                new Card('♠', 'T')
            ])
        };
    }

}