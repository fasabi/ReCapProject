﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRapositoryBase<CarImage, CarRentalContext>, ICarImageDal
    {
        public bool IsExist(int id)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.CarImages.Any(p => p.Id == id);
            }
        }
    }
}
