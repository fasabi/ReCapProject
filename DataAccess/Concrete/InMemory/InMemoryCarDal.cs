﻿using Core.DataAccess;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        public InMemoryCarDal()
        {
        }
        public void Add(Car car)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var addedEntity = context.Entry(car);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Car car)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var updatedEntity = context.Entry(car);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }

        }

        public void Delete(Car car)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var deletedEntity = context.Entry(car);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<Car>().Where(p => p.BrandId == id).ToList();
            }
        }

        public List<Car> GetCarsByColorId(int id)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<Car>().Where(p => p.ColorId == id).ToList();
            }
        }

        public IDataResult<CarDetailsDto> GetCarDetails(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailsDto>> GetCarsDetails()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailsDto>> GetGetByDailyPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<CarDetailsDto>> ICarDal.GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<CarDetailsDto>> ICarDal.GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public Car Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
