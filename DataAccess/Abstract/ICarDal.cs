using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // Car nesnesi ile ilgili veri tabanında yapacağım  operasyonları içeren interface
    public interface ICarDal:IEntityRepository<Car>
    {



    }
}
