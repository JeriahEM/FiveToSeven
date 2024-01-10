namespace FiveToSeven.Services.Five;
public class FiveServices : IFiveServices
{
    public string madLib(string name, string verbWithED, string verb, string timeFrame, string place, string adjWithLY, string adj, string noun, string noun1, string relationshipStatus, string timeFrame1, string verb1, string noun2, string food, string bodyPart, string noun3, string verb4, string verb2, string name1, string timeFrame2, string verb3)
    {
        return $"Dear {name} you may not know but I have {verbWithED} for your {verb} for many many {timeFrame}, Since we met at the {place} I knew that you were {adjWithLY} {adj}. I would give any amount of {noun} to be your {noun1}. I know we've been {relationshipStatus} for {timeFrame1}, but I know that if you let me {verb1} for your {noun2} id be your {noun1}. You are the {food} of my {bodyPart}, and I hope this {noun3} finds you in health. I promise to {verb2} you {name} for {timeFrame2}     Love, {name1}";
    }
}