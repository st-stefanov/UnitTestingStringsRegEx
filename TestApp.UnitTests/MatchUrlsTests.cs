using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";
        List<string> expected = new ();
        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert
        Assert.AreEqual(expected, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "No valid URLS!!!";
        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = "Single URL: https://softuni.bg";
        List<string> expected = new() { "https://softuni.bg" };
        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = "Multiple URLS: https://softuni.bg, http://digital.softuni.bg, https://creative.softuni.bg ";
        List<string> expected = new() { "https://softuni.bg", "http://digital.softuni.bg", "https://creative.softuni.bg" };
        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "Single URL: \"https://softuni.bg\"";
        List<string> expected = new() { "https://softuni.bg" };
        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert
        Assert.AreEqual(expected, result);
    }
}
