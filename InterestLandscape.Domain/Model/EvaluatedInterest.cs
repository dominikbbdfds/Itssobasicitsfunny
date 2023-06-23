namespace InterestLandscape.Domain.Model
{
    public record EvaluatedInterest(Interest Interest, GrowModelStage GrowModelStage, string Description, DateTimeOffset LastUpdated, int InterestInportance);
}