using Data.Entities;
using EntityFrameworkPaginateCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Data.Interfaces
{
    public interface IVehicleService : IEnumerable<VehicleMakeEntity>
    {
        IEnumerable<VehicleMakeEntity> GetRangeMake(int index, int count, Expression<Func<VehicleMakeEntity, int>> orderLambda);
    }
}
