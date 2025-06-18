using System.Text.RegularExpressions;
using Domain.Abstract;
using Group = Domain.Entities.Group;

namespace Domain.Repositories;

public interface IGroupRepository : IDbGuidRepository<Group>
{
    
}