using InterestLandscape.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestLandscape.Domain.Contracts
{
    public interface IInterestRepository
    {
        public void New(Interest interest);
        public void Delete(Guid interestId);
        public IEnumerable<Interest> GetInterests(int page);
        public Interest Get(Guid interestId);
        public void UpdateInterestsWithRecentTechnologies();
    }
}
