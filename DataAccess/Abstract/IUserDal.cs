using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Core.Entity.Concrete;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
