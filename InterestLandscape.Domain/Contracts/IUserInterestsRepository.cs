using InterestLandscape.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestLandscape.Domain.Contracts
{
    public interface IUserInterestsRepository
    {
        public void CreateUser(UserInterests user);
        public void UpdateUser(UserInterests user);
        public void DeleteUser(UserInterests user);
        public IEnumerable<UserInterests> GetAll(int page);
        public IEnumerable<UserInterests> GetBySharedInterest(Interest interest);
    }
}
