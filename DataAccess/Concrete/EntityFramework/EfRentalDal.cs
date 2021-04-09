using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental,RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetAllRentalDetailDtos()
        {
            
            using (RentACarContext context = new RentACarContext())
            {
                var result = from r in context.Rentals
                    join c in context.Cars on r.CarId equals c.Id
                    join b in context.Brands on c.BrandId equals b.Id
                    join cu in context.Customers on r.CustomerId equals cu.Id
                    join u in context.Users on cu.UserId equals u.Id

                    select new RentalDetailDto
                    {
                       Id = r.Id,
                       CarId = r.CarId,
                       CustomerId = r.CustomerId,
                       Brand = b.Name,
                       Model = c.Model,
                       ModelYear = c.ModelYear,
                       DailyPrice = c.DailyPrice,
                       CustomerName = u.FirstName + " " + u.LastName,
                       RentDate = r.RentDate,
                       ReturnDate = r.ReturnDate
                    };
                Console.WriteLine("buraya kadar geldi");
                Debug.Write("adadada-----" + result.ToList());
                return result.ToList();
            }
        }
    }
}
