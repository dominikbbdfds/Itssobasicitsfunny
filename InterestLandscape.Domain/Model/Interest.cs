namespace InterestLandscape.Domain.Model
{
    public record Interest(Guid InterestId, string InterestName, string InterestDescription, GrowModelPillar Pillar);
}