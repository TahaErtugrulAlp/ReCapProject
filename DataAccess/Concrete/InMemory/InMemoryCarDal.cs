using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    //Bellekte çalışacağız.
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars; //nameing convention

        //constructor
        public InMemoryCarDal()
        {
            _cars = new List<Car> {

                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=400,Description="Benzin",ModelYear=2019},
                new Car{CarId=2,BrandId=1,ColorId=1,DailyPrice=500,Description="Benzin+Lpg",ModelYear=2016},
                new Car{CarId=3,BrandId=2,ColorId=2,DailyPrice=800,Description="Benzin",ModelYear=2017},
                new Car{CarId=4,BrandId=2,ColorId=3,DailyPrice=900,Description="Dizel",ModelYear=2021},
                new Car{CarId=5,BrandId=3,ColorId=3,DailyPrice=660,Description="Dizel",ModelYear=2020}



            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        //Ürünleri silerken primary key'inin silmiş oluruz.
        public void Delete(Car car)
        {
           Car carToDelete = _cars.SingleOrDefault(c=>c.CarId ==c.CarId);
           _cars.Remove(carToDelete);


        }

        public List<Car> GetAll()
        {
            return _cars;
        }


        public List<Car> GetAllById(int CarId)
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }

        public List<Car> GetAllById()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            //Gönderdiğim ürüm id'sine sahip olan listedeki ürünü bul.
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == c.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
