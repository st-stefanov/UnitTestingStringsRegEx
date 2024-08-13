﻿using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    // TODO: finish the test
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";

        // Act
        string output = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.That(output, Is.EqualTo("The quick brown jumps over the lazy dog"));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "the";
        string input = "The quick brown fox jumps over the lazy dog";

        // Act
        string output = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.That(output, Is.EqualTo("quick brown fox jumps over lazy dog"));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "dog";
        string input = "The quick brown fox jumps over the lazy dog";

        // Act
        string output = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.That(output, Is.EqualTo("The quick brown fox jumps over the lazy"));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "the";
        string input = "the the the the the";

        // Act
        string output = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.That(output, Is.EqualTo(""));
    }
}

