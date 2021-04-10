using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1,BrandId = 1,ColorId = 1,Model = "Golf",ModelYear = 2015,DailyPrice = 250,Description = "A/T Diesel"},
                new Car{Id = 2,BrandId = 1,ColorId = 2,Model = "Passat",ModelYear = 2020,DailyPrice = 350,Description = "A/T Gasoline"},
                new Car{Id = 3,BrandId = 1,ColorId = 3,Model = "Jetta",ModelYear = 2019,DailyPrice = 2200,Description = "M/T Diesel"},
            };
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Model = car.Model;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<CarDetailDto> GetAllCarDetailDtos(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetAllCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int Id)
        {
            return _cars.SingleOrDefault(c => c.Id == Id);
        }
    }
}
