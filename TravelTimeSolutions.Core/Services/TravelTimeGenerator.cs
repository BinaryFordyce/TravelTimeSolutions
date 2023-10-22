using TravelTimeSolutions.Core.Entities;

namespace TravelTimeSolutions.Core.Services;

public class TravelTimeGenerator
{
    public TravelTimeEntry GenerateEntry(double hours, double kmPerJourney)
    {
        return new TravelTimeEntry()
        {
            Hours = 5,
            Kms = 100   
        };
    }
}