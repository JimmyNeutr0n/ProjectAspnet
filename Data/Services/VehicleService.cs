using Data.Entities;
using Data.Interfaces;
using EntityFrameworkPaginateCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq.Expressions;
using System.Linq;
using AutoMapper;
using Data.Context;

namespace Data.Services
{
    public class VehicleService : IVehicleService
    {

        private readonly IMakeRepository _makeRepository;

        private readonly IModelRepository _modelRepository;
        private readonly ProjectDbContext _dbcontext;


        private readonly IQueryable<VehicleMakeEntity> source;

        public VehicleService(IMakeRepository makeRepository, IModelRepository modelRepository, IQueryable<VehicleMakeEntity> source)
        {
            _makeRepository = makeRepository;
            _modelRepository = modelRepository;
            this.source = source;
        }

        public IEnumerable<VehicleMakeEntity> GetRangeMake(int index, int count, Expression<Func<VehicleMakeEntity, int>> orderLambda)
        {
            return source.OrderBy(orderLambda).Skip(index * count).Take(count);
        }


        public IEnumerator<VehicleMakeEntity> GetEnumerator()
        {
            return source.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
