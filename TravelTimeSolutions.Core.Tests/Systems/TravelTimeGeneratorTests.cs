using FluentAssertions;

namespace TravelTimeSolutions.Core.Tests.Systems;

public class TravelTimeGeneratorTests
{
    [Fact]
    public void GenerateEntry_WithValidHoursAndKms_ReturnCorrectEntry()
    {
        // Arrange
        var generator = new TravelTimeGenerator();
        double hours = 5;
        double kmPerJourney = 100;

        // Act
        var entry = generator.GenerateEntry(1, 30);

        // Assert
        entry.Should().NotBeNull();
        Assert.Equal(hours, entry.Hours);
        Assert.Equal(kmPerJourney, entry.Kms);
    }
}