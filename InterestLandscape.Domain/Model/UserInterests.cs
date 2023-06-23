using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestLandscape.Domain.Model
{
    public class UserInterests
    {
        public UserInterests(string accountId, List<EvaluatedInterest> interests)
        {
            AccountId = accountId;
            Interests = interests;
        }

        public string AccountId {  get; private set; }
        public string Name { get; private set; }
        public List<EvaluatedInterest> Interests { get; set; }

        public List<EvaluatedInterest> InterestsByGrowModelStage (GrowModelStage stage)
        {
            return Interests.Where(interest => interest.GrowModelStage == stage).ToList();
        }

        public List<EvaluatedInterest> MostRecentInterests ()
        {
            return Interests.GroupBy(i => i.LastUpdated)
                            .Select(g => g.OrderByDescending(i => i.LastUpdated).First())
                            .ToList();
        }
    }
}
