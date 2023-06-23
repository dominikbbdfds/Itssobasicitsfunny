using InterestLandscape.Domain.Contracts;
using InterestLandscape.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestLandscape.Infrastructure.Database
{
    public class InterestRepository : IInterestRepository
    {
        private List<Interest> Interests;

        public InterestRepository()
        {
            Interests = new List<Interest>();
        }

        public void Delete(Guid interestId)
        {
            var itemToRemove = Interests.SingleOrDefault(i => i.InterestId == interestId);
            Interests.Remove(itemToRemove);
        }

        public Interest Get(Guid interestId)
        {
            return Interests.FirstOrDefault(i => i.InterestId == interestId);
        }

        public IEnumerable<Interest> GetInterests(int page)
        {
            return Interests;
        }

        public void New(Interest interest)
        {
            Interests.Add(interest);
        }

        public void UpdateInterestsWithRecentTechnologies()
        {
            throw new NotImplementedException();
        }
    }
}
