using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        //Bir iş sınıfı başka sınıfları new'lemez.
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            //İş kodları yazılır(if else kullanılır)



            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int id)
        {
            return _carDal.GetAll(p=>p.BrandId==id);
        }

        public List<Car> GetAllByCarId(int id)
        {
            return _carDal.GetAll(p=>p.CarId==id);
        }

        public List<Car> GetByColorId(int id)
        {
            return _carDal.GetAll(p=>p.ColorId==id);
        }

        
    }
}
