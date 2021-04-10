using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetAllCarDetailDtos(Expression<Func<Car, bool>> filter = null);
    }
}
