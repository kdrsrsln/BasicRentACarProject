using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetAllCarDetailDtos(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in filter == null ? context.Cars : context.Cars.Where(filter)
                    join b in context.Brands on c.BrandId equals b.Id
                    join co in context.Colors on c.ColorId equals co.Id
                    select new CarDetailDto
                    {
                        BrandName = b.Name,
                        Model = c.Model,
                        ColorName = co.Name,
                        DailyPrice = c.DailyPrice,
                        Description = c.Description
                    };
                return result.ToList();
            }
        }
    }
}
